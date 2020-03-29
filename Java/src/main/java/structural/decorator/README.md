# Decorator Pattern #
Hierarchical pattern that builds functionality at each level using composition from similar data types.

## Concepts ##
- Wrap another object to add functionality to it
- Add behavior to an object without affecting other parts of the hierarchy
- More than inheritance, wrap object in complimentary objects not overriding like with inheritance
- Single Responsibility Principle
- Compose behavior dynamically by combining subclasses that decorate an object

## Examples ##
- java.io.InputStream
- UI components in AWT / Swing

## Design ##
- Inheritance based
- Utilizes composition and inheritance to achieve this
- Alternative to subclassing
- Constructor requires an instance from the hierarchy to extend through composition
- Component, ConcreteComponent, Decorator, ConcreteDecorator

## Pitfalls ##
- New class for every feature you would like to decorate
- Multiple little objects

## Contrast with Composite ##

### Decorator ###
- Contains another entity
- Modifies behavior of contained entity via composition
- Doesn't change underlying object

### Composite ###
- Tree structure
- Leaf and Composite have the same interface
- Provides unity between objects

## Summary ##
- Original object stays the same
- Unique way to add functionality
- Can be more complex for clients, exposes knowledge of composition to the client
