// See https://aka.ms/new-console-template for more information

using AdapterPattern;

// The third-party functionality
Adaptee adapteeInstance = new Adaptee(); 

//The plug
Adapter adapterInstance = new Adapter(adapteeInstance);

// Class that needs to use the third-party Functionality
Client clientInstance = new Client(adapterInstance);

// Client Functionality which uses clientDS type however internally is converted to adapteeDS
clientInstance.ClientFunctionality(0);
