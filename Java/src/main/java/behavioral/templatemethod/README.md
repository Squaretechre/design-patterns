# Template Method Pattern #

Used to define an algorithm that will allow subclasses to redefine parts of the algorithm without changing its structure.

Allow for customisation of an algorithm while ensuring the order of operations.

## Concepts ##
- Algorithm emphasis
    - Force an algorithm but allow pieces to be configured
- Code reuse
- Common in frameworks/libraries

## Examples ##
- java.util.Collections#sort()
- java.util.AbstractList#indexOf()

## Design ##
- Abstract base class
- Base calls child
- Hooks put in place that may be overriden in children
- Operations put in place that must be overriden
- AbstractBase, ConcreteClass

## Pitfalls ##
- Restrict access
- Can create confusing class hierarchies
- Can create difficult program flow

## Contrast with Strategy ##

### Template Method ###
- Both focused on the algorithm, template method is the same algorithm with different implementations
- Class based, sub classes implement hooks / pieces of the algorithm in the base class
- Chosen at compile time

### Strategy ###
- Implements entire algorithm per strategy
- More about the contract / interface
- Used to pick the algorithm at run time

## Summary ##
- Guarantees algorithm adherence
- An algorithm / method that provides hooks for customisation
