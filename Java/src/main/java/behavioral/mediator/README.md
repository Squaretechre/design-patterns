# Mediator Pattern #

Defines how objects interact with one another without having them refer to each other explicitly.

## Concepts ##
- Loose coupling
- Well defined objects that communicate in complex ways
- Reusable components
- Acts as a hub / router

## Examples ##
- java.util.Timer
- java.lang.reflect.Method#invoke()

## Design ##
- Interface based
- Concrete class
- Minimizes inheritance
- Mediator knows about colleagues rather than colleagues knowing about each other
- Mediator, ConcreteMediator

## Pitfalls ##
- Potential for deity objects

## Contrast with Observer ##

### Mediator ###
- Defines interaction
- Decouples objects by eliminating references to each other, only reference to mediator
- More specific, in comparison to observer

### Observer ###
- One-to-many broadcast, broadcasts instead of defining interaction
- Decouples objects via broadcasting messages
- More generic, add additional listeners as appose to editing the actual mediator

## Summary ##
- Loose coupling
- Simplified communication between complex objects
- Be mindful of mediator complexity
- Use with command pattern, though both stand independently