# NetCore-DesignPatterns
A repository of Design Pattern templates 

Status:
- (In Progress)
- (`Available`)
- (Not Available)

##  1. <a name='ListofDesignPatterns'></a>List of Design Patterns

###  1.1. <a name='CreationalPatterns'></a>Creational Patterns
Creational Patterns:
- Handle the creation or clonning of new objects.

1. Abstract Factory 
2. Builder 
3. Factory Method 
4. Prototype 
5. Singleton 
   
###  1.2. <a name='StructuralPatterns'></a>Structural Patterns
Structural Patterns:
- Describes:
  -  how objects are connected to each other 
  -  how subcclasses and baseclasses interact through `inheritance.`  
- Relates to the design principles of `decomposition` and `generalization`.

So, a **Structural Pattern describes how classes should work to achieve a particular design goal**. (like ingredient in a food to achieve a specific flavor)

1. [Adapter](/README.md#31-adapter) (`Available`)
2. Bridge 
3. Composite 
4. Decorator 
5. [Façade](/README.md#35-façade) (`Available`)
6. Flywight 
7. Proxy 

###  1.3. <a name='BehaviouralPatterns'></a>Behavioural Patterns
Behavioral Patterns:
- Focus on How objects distribute work
- Describe how each object does a single cohesive function
- also Focus on How independent objects work towards a common goal.

So, a **a Behavioral Pattern lays out the overall goal and purpose for each object**. (like a racing car pit crew in a track)

1. Chain of Responsability 
2. Command 
3. Interpreter 
4. Iterator 
5. Mediator 
6. Memento 
7. Observer 
8. [State] 
9. Strategy 
10. Template method 
11. Visitor 

##  2. <a name='CreationalPatterns-1'></a>Creational Patterns

###  2.1. <a name='AbstractFactory'></a>Abstract Factory 
###  2.2. <a name='Builder'></a>Builder 
###  2.3. <a name='FactoryMethod'></a>Factory Method 
###  2.4. <a name='Prototype'></a>Prototype 
###  2.5. <a name='Singleton'></a>Singleton 

##  3. <a name='StructuralPatterns-1'></a>Structural Patterns

###  3.1. <a name='Adapter'></a>Adapter
![UMLdiagram](/uploads/StructuralDP-Adapter.png)
- Purpose: 
  - Provides communication between two existing classes (`ClientClass` and `AdapteeClass`) by providing a compatible interface `TargetInterface`.
  - When a pre-existing software (`ClientClass`) needs to use third-party libraries (`AdapteeClass`) or needs to connect to a external sw/hw.
- Parts:
  - `ClientClass`: Class which is part of your software and wants to use third-party libraries or external sw/hw.
  - `AdapteeClass`: This is the third-party class or external sw/hw.
  - `AdapterClass`:
    - It is what the `ClientClass` expects. It implements the `TargetInterface`.
    - It traslates the `ClientClass` requests into a message that the `AdapteeClass` can understand.
  - `TargetInterface`: It is used by the `ClientClass` to send a request to the adapter,
- Steps:
  - Design the `TargetInterface`
  - Implements the `AdapterClass`
  - Send the request from the `ClientClass` to the `AdapterClass` using the `TargetInterface` 
- LINK to Repository Project: [Here](https://github.com/LuisCarlosRojasTorres/NetCore-DesignPatterns/tree/main/StructuralPatterns/AdapterPattern)
  
###  3.2. <a name='Bridge'></a>Bridge
![UMLdiagram]()
- Purpose:
- Parts:  
- Steps:
- LINK: [Here]()


###  3.3. <a name='Composite'></a>Composite
![UMLdiagram]()
- Purpose:
- Parts:  
- Steps:
- LINK: [Here]()

###  3.4. <a name='Decorator'></a>Decorator
![UMLdiagram]()
- Purpose:
- Parts:  
- Steps:
- LINK: [Here]()
  
###  3.5. <a name='Faade'></a>Façade
![UMLdiagram](/uploads/StructuralDP-Facade.png)
- Purpose:
  - Provides a single, simplified `interface` for `ClientClasses` to interact with a subsystem.  
  - If there is a need for a class to instantiate other classes within your system and to provide these instances to another class.
- Parts:
  - `ICommonFunctionalities`  : defines the methods which are common to all the classes to be refactored/created.
  - `FaçadeClass`: 
    - It is a wrapper class that encapsulates a subsystem and hides its complexity.
      - It uses `aggregation`.
    - It allows the `ClientClass` to interact with the subsystem though a `façade`.
  - `ClientClass`: Calls the methods defined in `ICommonFunctionalities` and implemented in the different `Class1`, `Class2` and `CSlass3` using only the `FaçadeClass`
- Steps:
  - Design the `interface` extracting common methods to be used by the `ClientClass`
  - Implement the `interface` with one or more classes
  - Create the `FaçadeClass` and wrap the classes that implement the `interface`
  - Use the `FaçadeClass` to access the subsystem.
  - Implement the `ClientClass` to call the methods of the subsystem through the `FaçadeClass`.
- LINK to Repository Project: [Here](https://github.com/LuisCarlosRojasTorres/NetCore-DesignPatterns/tree/main/StructuralPatterns/FacadePattern)
###  3.6. <a name='Flywight'></a>Flywight
![UMLdiagram]()
- Purpose:
- Parts:  
- Steps:
- LINK: [Here]()

###  3.7. <a name='Proxy'></a>Proxy
![UMLdiagram]()
- Purpose:
- Parts:  
- Steps:
- LINK: [Here]()

##  4. <a name='BehavioralPatterns'></a>Behavioral Patterns

###  4.1. <a name='ChainofResponsability'></a>Chain of Responsability
![UMLdiagram]()
- Purpose:
- Parts:  
- Steps:
- LINK: [Here]()

###  4.2. <a name='Command'></a>Command
![UMLdiagram]()
- Purpose:
- Parts:  
- Steps:
- LINK: [Here]()

###  4.3. <a name='Interpreter'></a>Interpreter
![UMLdiagram]()
- Purpose:
- Parts:  
- Steps:
- LINK: [Here]()

###  4.4. <a name='Iterator'></a>Iterator
![UMLdiagram]()
- Purpose:
- Parts:  
- Steps:
- LINK: [Here]()

###  4.5. <a name='Mediator'></a>Mediator
![UMLdiagram]()
- Purpose:
- Parts:  
- Steps:
- LINK: [Here]()

###  4.6. <a name='Memento'></a>Memento
![UMLdiagram]()
- Purpose:
- Parts:  
- Steps:
- LINK: [Here]()

###  4.7. <a name='Observer'></a>Observer
![UMLdiagram]()
- Purpose:
- Parts:  
- Steps:
- LINK: [Here]()

###  4.8. <a name='State'></a>State 
![UMLdiagram]()
- Purpose: A Finite State Machine on steroids.
   - Finite State Machine:
      - A class with an `enum` which represents the `states`
      - The constructor will set the initial state.
      - A main function has a while loop which call different methods according to the current object state.
      - Each `state` has a method associated. The output of this methods will change the state to another one.  
      - LINK to FSM Repository Project: [Here](https://github.com/LuisCarlosRojasTorres/NetCore-DesignPatterns/tree/main/BehavioralPattern/FiniteStateMachineExample)
- Parts:  
- Steps:
- LINK: [Here]()

###  4.9. <a name='Strategy'></a>Strategy
![UMLdiagram](/uploads/BehavioralDP-Strategy.png)
- Purpose: 
  - To define a family of encapsulated and interchangeable algorithms, i.e. they are `client` independent. Each algorithm is called of `strategy`.
  - to use different variants of an algorithm within an object and be able to switch from one algorithm to another during runtime .
  - to isolate the business logic of a class from the implementation details of algorithms that may not be as important in the context of that logic
  - To replace an humongous, general and plenty-of-conditionals main algorithm.
- Parts:
  - `ContextClass`  
    - It has a reference to a `Strategy` object 
      -  It calls the `Strategy` methods through the interface
   - It has a setter to change the `strategy` object at runtime
    -  It does not know 
       -  what type of strategy it works with
       -  how the algorithm is executed
  - `IStrategy`: 
    - It defines a common `interface` for all the algorithms.
    - It is used by the `ContextClass` to call a `ConcreteStrategy`
  - `ConcreteStrategy1`, ... `ConcreteStrategyN`: Implements an algorithm using the `IStrategy` interface.
  - `ClientClass`:
    - Creates the strategy object and passes it to the `ContextClass`
    - It can change the `Strategy` object of the context class at runtime.
- Steps:
- LINK: [Here]()

###  4.10. <a name='Templatemethod'></a>Template method 
![UMLdiagram]()
- Purpose:
- Parts:  
- Steps:
- LINK: [Here]()

###  4.11. <a name='Visitor'></a>Visitor 
![UMLdiagram]()
- Purpose:
- Parts:  
- Steps:
- LINK: [Here]()
