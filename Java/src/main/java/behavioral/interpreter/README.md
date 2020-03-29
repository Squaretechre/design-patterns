# Interpreter Pattern #

Used to represent the grammar of a language, commonly used by tools to parse various aspects of a grammar.

## Concepts ##

- Represents grammar
- Interpret a sentence
- Map a domain
- AST

## Examples ##
`java.util.Pattern`

`java.text.Format`

## Design ##

- AbstractExpression
- Interpret
- TerminalExpression
- NonTerminalExpression
- Context
- AbstractExpression
- Client

## Pitfalls ##

- Complexity
- One class per rule, use other patterns to simplify
- Adding new variants can require extra maintenance
- Specific use case

## Contrast with Visitor ##

### Interpreter ###

- Access to properties as it contains the object
- Functions as methods, implement interpret interface
- Adding new functionality changes every variant

### Visitor ###

- Needs Observer functionality, implement observer / observable to gain access to properties
- Functionality in one place, in the visitors and not the expression objects
- Adding a new variant requires changing every visitor

## Summary ##

- Great for defining a grammar
- Use for rules or validation, validating objects
- Special case, limited use pattern, solves a specific problem
- Consider using the visitor pattern depending on areas of change