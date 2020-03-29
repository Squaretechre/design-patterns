# Bridge Pattern #
Similar to the adapter pattern but is designed to work with new code rather than legacy code.

## Concepts ##
- Decouple abstraction and implementation
- Makes use of multiple techniques, encapsulation, composition and inheritance
- Changes in the abstraction won't affect the client
- Use when details won't be right to begin with, bridge allows for flexibility through additional indirection

## Examples ##
- Drivers
- JDBC

## Design ##
- Uses interfaces and abstract classes
- Composition over inheritance
- More than just composition
- Application expects change from both sides
- Abstraction, Implementor, RefinedAbstraction, ConcreteImplementor

## Pitfalls ##
- Increases complexity
- Conceptually difficult to plan

## Contract with Adapter ##

### Bridge ###
- Designed upfront
- Abstraction and implementation can vary
- Built in advance
- Adds complexity

### Adapter ###
- Works after code is designed
- Intended for legacy applications
- Retrofitted
- Provides a different interface for existing code

## Summary ##
- Design for uncertainty
- Can be complex
- Adds complexity, but provides flexibility
- More than composition
