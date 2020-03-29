# Specification

Notes from Steve Smith's explanation of [Specification on Pluralsight](https://app.pluralsight.com/player?course=patterns-library&author=steve-smith&name=patterns-library-m33&clip=0&mode=live).

Steve Smith - https://ardalis.com/ - [@ardalis](https://twitter.com/ardalis)

## Intent

- State a constraint on the state of an object.
- Test any object of the appropriate type to see if it satisfies certain criteria.
- Specify, in an object the work to be done by an operation.
- Separate the specification of the work from performing the work itself.

## Candidate problems

- Queries:

  - Specify criteria for selection.
  - Frequently combined with the Repository pattern.
  - May be applied to data as well as object capabilities.

- Requirements:

  - Object creation instructions.
  - Contraints on an existing object.
  - Requirements for a factory.

- Validation:
  - Is it suitable for a certain set of requirements?

## Implementation

- Specification has method `IsSatisfiedBy`.
  - This accepts an object and if it meets the criteria defined in the specification it returns true.
- A specification can be applied to a collection of objects, acting as a filter.
- Implement as a Value Object
  - One specification is equal to another if they have the same critiera.

```
   ---------------                        --------
  | Specification |  -- IsSatisfiedBy -> | Object |
   ---------------                        --------

   The specification object should be implemented
   as a Value Object.
```

## Where does complex query logic belong?

- Rules may involve multiple Entities or Value Objects, or may clutter such types.
- Don't want to move querying logic outside of the domain model.
  - This pushes important rules outside of the domain model, reducing its value.
  - Makes query logic more complex to reason about and test.
- Working with complex predicates is not ideal:
  - Doesn't communicate intent.
  - Difficult to test.
  - Often not primary focus of code in which they reside.

## Notes

- `ISpecification<T>` is best used against in memory collections of objects.
  - This is fine for most validation scenarios, however falls short for querying.
- For querying it's preferable to use predicates within specifications.
  - This allows EF / other ORMs to convert the rules into SQL.
- Force clients to go through specification in order to define the query to execute.
  - This constrains and consolidates query logic, keeping predicates and database concerns out of other layers of the application.
- Specifications can be combined together into composite specifications.

## Summary

- Specification is generally used for validation, filtering, or build-to-order scenarios.
- A specification defines a method or predicate that matches qualifying objects.
- The specification pattern can help separate concerns and decouple code.
- Specifications can be more expressive than other approaches.
