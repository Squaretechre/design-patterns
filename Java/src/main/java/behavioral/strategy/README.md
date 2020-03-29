# Strategy Pattern #

Use when you need the algorithm / strategy to be selected at runtime.

## Concepts ##
- Eliminate conditional statements
- Encapsulates algorithm options in individual classes
- Client is aware of the strategies that are available
- Client chooses the strategy

## Examples ##
- java.util.Comparator

## Design ##
- Interface or abstract class based
- Each concrete class implements what is unique to that strategy
- Removes if/else conditionals
- Client knows about strategies, but strategies don't know about each other
- Context, Strategy, ConcreteStrategy

## Pitfalls ##
- Client aware of strategies
- Increased number of classes

## Contrast with State Pattern ##

### Strategy ###
- Similar to state but focuses on encapsulating algorithms / strategies rather than state transitions
- Interface based
- Unlike the state pattern, algorithms are independent
    - Strategies don't know about alternative strategies
- Class per algorithm

### State ###
- Interface based with a collection of concrete states we can transition to
- Each state only knows about the next state it can transition to
- Class per state

## Summary ##
- Use to externalize algorithms
- Client knows about the different strategies that can be used
- Class per strategy
- Reduces conditional statements