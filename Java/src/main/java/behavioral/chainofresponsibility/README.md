# Chain of Responsibility Pattern #

Decouples a request from a handling object in a chain of handlers until it is finally recognised.

## Concepts ##

- Decoupling of sender and receiver
- Receiver contains reference to next receiver
- Promotes loose coupling
- No Handler - OK


## Examples ##

`java.utils.logging.Logger#log()`

`javax.servlet.Filter#doFilter()`

`Spring Security Filter Chain`

## Design ##

- Chain of receiver objects
- Handler is interface based
- ConcreteHandler for each implementation
- Each Handler has a reference to the next
- Handler, ConcreteHandler

## Pitfalls ##

- Handling/Handler guarantee, not guaranteed that someone will handle our request
- Runtime configuration risk
- Chain length/performance issues

## Contrast with Command ##

### Chain of Responsibility ###
- Handler is unique
- Has a successor
- Can utilize the Command pattern
- Assumption that someone will handle request

### Command ###
- Command also unique
- Encapsulates function
- Reversible or trackable in nature
- Does not attempt to delegate if can't fulfil request
- Know that someone can handle request