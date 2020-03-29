# Visitor Pattern #

Use to separate an algorithm from an object structure.

## Concepts ##
- Separate algorithm from object structure
- Adding new features, expecting change but can't modify existing object structure
- Maintain Open/Closed principle
- Visitor class contains the changes and specialisations rather than changing the original object

## Examples ##
- java.lang.model.element.Element
- java.lang.model.element.ElementVisitor

## Design ##
- Interface based
- Design around the visitor from the beginning
    - It is hard to retrofit after the fact
- Application has elements which we expect to change and need to add functionality to over time
    - Implement a visitor in each of the elements
- Each element has a visit method
- Each visitor knows of every element
- Visitor, ConcreteVisitor, Element, ConcreteElement

## Pitfalls ##
- Have to plan for adaptability, risk of over architecting the solution
- Indirection potentially confusing

## Contrast with Iterator ##

### Visitor ###
- Interface based
- Focus on adaptability by externalising changes
- Add multiple visitors is easy and encouraged

### Iterator ###
- Interface based
- Encapsulates navigation, but doesn't necessarily externalise it

## Summary ##
- Use when expecting changes but not sure what they'll be upfront
- Adds minor complexity to the application
- Use to externalise change if unable to change base API

