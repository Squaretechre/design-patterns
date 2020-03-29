# Composite Pattern #
A hierarchical pattern that deals with tree structures of information.

## Concepts ##
- Treat components the same whether it is part of a structure, the whole structure itself
- Compose objects into tree structures
- Individual objects treated as a composite
- Use operations on individual and composites in the same way

## Examples ##
- java.awt.Component
- JSF widgets
- RESTful service GETs

## Design ##
- Tree structured
- Root of the tree starts with a component
- Components are either a leaf or a composite of objects with the same operations
- Leaf just has operations
- Composite has same operations as a leaf but also knows about its child components
- Component, Leaf, Composite

## Pitfalls ##
- Can overly simplify a system
    - Building a hierarchy can make it difficult to restrict what we want to add to it
- Implementation can be costly dealing with a large composite

## Contrast with Decorator ##

### Composite ###
- Tree structure
- Intent is to make leaf and composite have the same interface to the client
- Provides unity between objects

### Decorator ###
- Contains another entity, composition
- Modifies the behavior of the contained entity by adding to it
- Usually adding functionality to an entity that it didn't originally have
- Doesn't change the underlying entity

## Summary ##
- Generalises a hierarchical structure
- It can over simplify things which makes it difficult to restrict what can later be added to the structure
- Makes things easier for the client, leaf and composite are treated the same
- Composite is not exactly the same as composition
    - The composite pattern models a hierarchical tree structure
    - Composition is one object containing another
