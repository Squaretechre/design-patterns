# Command Pattern #

## Intent ##

- Encapsulates each request as an object.
- Represents an action as an object.
- Decouples clients that execute the command from the details and dependencies of the command logic
- Enables delayed execution
    - Can queue commands for later execution
    - If command objects are also persistent, can delay across process restarts

## Concepts ##

- Encapsulate request as an object
- Object-oriented callback
- Decouple sender from processor
- Often used for "undo" functionality

Client has a reference to a command object that implements a method called execute, or something similar.
The method is void and takes no arguments, i.e the client doesn't provide any context. All the client does
is execute the command. The command itself may references to dependencies in order to get it's work done.
The client however should be shielded from those dependencies.

The main idea of the command pattern is that some client has a method they can call without having any
extra data to call it with.

You can extend the pattern with additional methods:
- Execute
- Validate
- Undo

## Consequences ##

- Commands must be completely self contained
    - The client doesn't pass in any arguments
    - Different from strategy in that the client doesn't provide any context
- Easy to add new commands
    - Just add a new class (open/closed principle)

## Examples ##

`java.lang.Runnable`

`javax.swing.Action`

## Design ##

- Object per command
- Command interface
- Execute method
- "Unexecute" method
- Reflection
- Command, Invoker, ConcreteCommand

## Pitfalls ##

- Dependence on other patterns
- Multiple commands
- Make use of Memento for state
- If tracking history, look at Prototype for copies

## Related Patterns ##

- Factory Pattern
    - Factories are often useful to construct command objects
- Null Object
    - Often times returning a "null command" can be useful instead of returning null
- Composite
    - A _composite command_ can be useful
    - Construct it with several "child" commands
    - Execute() on the composite will call Execute() on the child commands

## Contrast with Strategy ##

### Command ###
- Object per command
- Class contains the "what"
- Encapsulates action

### Strategy ###
- Object per strategy
- Class contains the "how"
- Encapsulates algorithm

### Summary ###
- Encapsulates each request as an object
- Decouple sender from processor
- Often used for undo functionality

Consider the command pattern:
- When you want to decouple the client that executes the command from the command logic and its dependencies
- When you're building a command-line application
- When you're implementing validation
- When you're implementing undo