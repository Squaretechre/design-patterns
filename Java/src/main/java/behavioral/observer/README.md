# Observer Pattern #

A decoupling pattern used when a subject needs to be observed by one or more observers.

## Concepts ##
- When a subject has one to many observers
- Decoupling objects
- Event handling

## Examples ##
- java.util.Observer
- java.util.EventListener
- javax.jms.Topic

## Design ##
- Subject that needs to be observed, an interface / abstract class
- Observers register themselves with the subject
- Observer interfaced based with various concrete implementations
- Subject, ConcreteSubject, Observer, ConcreteObserver

## Pitfalls ##
- Subject doesn't know about it's observers, potential for unexpected updates
- Performance penalties through large sized updates
- Not knowing what has changed in the subject that triggered an update

## Contrast with Mediator ##

### Observer ###
- One-to-many, one subject and many observers of its state
- Primarily used to decouple an object from those than want to watch it
- Uses a pub/sub or broadcast mechanism

### Mediator ###
- One-to-one-to-many, an object talks to a mediator and then the mediator is in charge of communication with other objects
- Also used for decoupling
- Primarily used for complex communication


## Summary ##
- Decouple communication, decoupled communication via broadcasting messages
- Built in functionality in the Java API
- Can be used with the mediator pattern
