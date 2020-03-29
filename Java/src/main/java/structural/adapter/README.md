# Adapter Pattern #
A good pattern for connecting new code to legacy code without having to change the working contract that was produced from the legacy code originally.

## Concepts ##
- Have client talk to an existing interface
- Convert interface into another interface
- Converting to legacy module that is difficult or not possible to change
- Translates requests from the client to the code we're adapting to
- Client, Adapter, Adaptee

## Examples ##
- Arrays.asList
- Streams

## Design ##
- Client centric
- Integrate new with old
- Interface, but not required, could be a new class
- Adaptee can be the implementation

## Pitfalls ##
- Don't add functionality, if adding functionality consider a decorator
- Don't over complicate adapters

## Contrast with Bridge ##

### Adapter ###
- Makes things work after they were designed
- Helps when dealing with legacy code
- Mostly retrofitted to make unrelated classes work together
- Provides different interface to legacy code than was originally intended

### Bridge ###
- Designed upfront
- Allows abstraction and implementation to vary independently
- Built in advance to provide a layer of abstraction to let both systems be flexible while implementing them
- Both Adapter and Bridge are intended to adapt multiple disparate systems and work in concert with one another

## Summary ##
- Simple solution to a specific problem
- Easy to implement
- Typically used to integrate with legacy code that we can't or don't want to change
- Can provide multiple adapters
