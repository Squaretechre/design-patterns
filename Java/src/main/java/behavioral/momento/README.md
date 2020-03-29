# Momento Pattern #

Used to externalise an object's state, usually to provide rollback functionality.

## Concepts ##
- Restore an objects previous state
- Externalise internal state
- Undo/rollback
- Shields complex internals from other objects

## Examples ##
- java.util.Date
- java.io.Serializable

## Design ##
- Class based
- Originator, the object to create a copy / save point of, creates a momento
- Caretaker, manages the created moments, the list of undos
- Memento, the copy of the originator that can be restored
    - Magic Cookie, the combination fields that it takes to recreate or copy the state of the object, stored inside the momento

## Pitfalls ##
- Can be expensive if the momento is a large copy of the originator's data
- Caretaker should consider how much history it needs to maintain
- Be careful when exposing originator information

## Contrast with the Command pattern ##

### Momento ###
- Used to capture state
- Captured state is independent
- Builds history with the Caretaker object

### Command ###
- Focused on requests rather than the state of an object
- Independent requests
- History is a side benefit of using commands

## Summary ##
- Captures state
- Can get heavy with history
- Recreate state of an object
- Similar to Command but with an emphasis on history and state rather than requests