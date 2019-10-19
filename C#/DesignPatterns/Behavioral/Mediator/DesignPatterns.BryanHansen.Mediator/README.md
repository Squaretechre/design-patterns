# Mediator #

## Contrast with observer ##

| Mediator                                                                                         | Observer                                                                                   |
|--------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------|
| Defines how objects interact                                                                     | One-to-many broadcast, listener chooses whether they want to do something with the message |
| Decouple objects by eliminating references to each other and just have reference to the mediator | Object decoupling via broadcast                                                            |
| More specific, must modify the mediator itself                                                   | More generic, only need to subscribe as a listener to receive message                      |
