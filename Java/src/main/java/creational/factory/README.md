# Factories #

## Intent ##

- Separate object creation from the decision of which object to create
- Factory encapsulates instantiation and decision making about construction
- Add new classes and functionality without breaking OCP
    - Factory-produced objects
    - Factories themselves
- Store which object to create outside of the program so we can make runtime based decision
    - In a database
    - In configuration, i.e. ASP.NET membership provider

## Simple Factory ##

- Encapsulate object creation
- Defer object creation
- Allows for late-bound decisions regarding instantiation
    - Configuration-based
    - Other persistent storage
    - Input or other dynamic data
- Caller class knows what concrete factory it needs

## Factory Method ##

"Define an interface for creating an object, but let the subclasses decide
which class to instantiate. Factory Method lets a class defer instantiation
to subclasses." - _GoF Design Patterns_

- Adds an interface to the factory itself from Simple Factory
- Defers object creation to multiple factories that share an interface
- Derived classes implement or override the _factory method_ of the base

### Advantages ###

- Eliminate references to concrete classes
    - Factories
    - Objects created by factories
- Factories can be inherited to provide even more specialised object creation
- Rules for object initialisation is centralised

### Disadvantages ###

- May need to create a factory just to get a concrete class delivered
- The inheritance hierarchy gets deeper with coupling between concrete factories and created classes

## Abstract Factory ##

"Provide an interface for creating families of related or dependent objects without
specifying their concrete classes." - _GoF Design Patterns_

- Factories create different types of concrete objects (products)
- A factory now represents a "family" of objects that it can create
- Factories may have more than one factory method

### Consequences ###

- Add new factories and classes without breaking OCP
- Defer choosing classes to classes that specialise in making that decision
- Using private or internal constructors hides direct construction with the new keyword
