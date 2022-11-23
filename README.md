<!-- vscode-markdown-toc -->
* 1. [List of Design Patterns](#ListofDesignPatterns)
	* 1.1. [Creational Patterns](#CreationalPatterns)
	* 1.2. [Structural Patterns](#StructuralPatterns)
	* 1.3. [Behavioural Patterns](#BehaviouralPatterns)
* 2. [Creational Patterns](#CreationalPatterns-1)
	* 2.1. [Abstract Factory](#AbstractFactory)
	* 2.2. [Builder](#Builder)
	* 2.3. [Factory Method](#FactoryMethod)
	* 2.4. [Prototype](#Prototype)
	* 2.5. [Singleton](#Singleton)
* 3. [Structural Patterns](#StructuralPatterns-1)
	* 3.1. [Adapter](#Adapter)
	* 3.2. [Bridge](#Bridge)
	* 3.3. [Composite](#Composite)
	* 3.4. [Decorator](#Decorator)
	* 3.5. [Façade](#Faade)
	* 3.6. [Flywight](#Flywight)
	* 3.7. [Proxy](#Proxy)
* 4. [Behavioral Patterns](#BehavioralPatterns)
	* 4.1. [Chain of Responsability](#ChainofResponsability)
	* 4.2. [Command](#Command)
	* 4.3. [Interpreter](#Interpreter)
	* 4.4. [Iterator](#Iterator)
	* 4.5. [Mediator](#Mediator)
	* 4.6. [Memento](#Memento)
	* 4.7. [Observer](#Observer)
	* 4.8. [State](#State)
	* 4.9. [Strategy](#Strategy)
	* 4.10. [Template method](#Templatemethod)
	* 4.11. [Visitor](#Visitor)

<!-- vscode-markdown-toc-config
	numbering=true
	autoSave=true
	/vscode-markdown-toc-config -->
<!-- /vscode-markdown-toc --># NetCore-DesignPatterns
A repository of Design Pattern templates 

Status:
- (In Progress)
- (`Available`)
- (Not Available)

##  1. <a name='ListofDesignPatterns'></a>List of Design Patterns

###  1.1. <a name='CreationalPatterns'></a>Creational Patterns
1. Abstract Factory 
2. Builder 
3. Factory Method 
4. Prototype 
5. Singleton 
   
###  1.2. <a name='StructuralPatterns'></a>Structural Patterns
1. [Adapter](/README.md#31-adapter) (`Available`)
2. Bridge 
3. Composite 
4. Decorator 
5. Façade 
6. Flywight 
7. Proxy 

###  1.3. <a name='BehaviouralPatterns'></a>Behavioural Patterns
1. Chain of Responsability 
2. Command 
3. Interpreter 
4. Iterator 
5. Mediator 
6. Memento 
7. Observer 
8. State 
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
- LINK: [Here](https://github.com/LuisCarlosRojasTorres/NetCore-DesignPatterns/tree/main/StructuralPatterns/AdapterPattern)
  
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
![UMLdiagram]()
- Purpose:
- Parts:  
- Steps:
- LINK: [Here]()
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
- Purpose:
- Parts:  
- Steps:
- LINK: [Here]()

###  4.9. <a name='Strategy'></a>Strategy
![UMLdiagram]()
- Purpose:
- Parts:  
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
