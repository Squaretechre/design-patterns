# State Pattern #

Used to represent state in an application.

A state machine knows about the different states it can be in, but the individual states only know about the one they can transition to.

## Concepts ##
- Localize state specific behavior
- Application state stored in an object
- Separate what state we're in from where we are in the application
- Aligned with Open/Close Principal
    - Object closed for changes but states open for extension

## Design ##
- Abstract class or interface based
- Each state is class based and represented by a concrete class per state
- Context / subject that has multiple states is unaware of various states using this pattern
    - Extract if / else blocks from subject to own state objects
- Context, State, ConcreteState

## Pitfalls ##
- Must know your states
- The pattern necessitates additional classes
- Keep logic out of the context, keep it in the states
- Clearly identify what triggers a state change

## Contrast with Strategy Pattern ##

### State ###
- Interface based with collection of concrete states
- Each state only knows about the next state that it can transition to
- Each state is contained in its own class

### Strategy ###
- Interface based
- Focuses on algorithms / strategies rather than state representation
- Strategies don't know about the next state, algorithms are independent
- Class per algorithm

## Summary ##
- Simplifies cyclomatic complexity
- Adding of additional states made much easier
- More classes involved using the State pattern, though typically lightweight
- Similar implementation to the Strategy pattern
    - One focused on algorithms the other on state