# Iterator Pattern #

Provides navigation without exposing the structure of an object.

## Concepts ##
- Traverse a container, collection
- Doesn't expose underlying structure
- Decouples data from algorithm used to traverse it
- Sequential in nature
- Iterator handles navigation in order that best represents it's sequence

## Examples ##
- java.util.Iterator
- java.util.Enumeration


## Design ##
- Interface based
- Use factory method to get instance of the iterator
- Independent, but fail fast
    - Two iterators can't change the underlying object without an error being thrown
- Enumerators are fail safe
- Iterator, ConcreteIterator

## Pitfalls ##
- No access to index, sometimes

## Summary ##
- Efficient way to traverse
- Hides algorithm from the client
- Simplify client