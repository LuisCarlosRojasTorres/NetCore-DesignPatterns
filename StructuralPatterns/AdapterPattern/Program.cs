// See https://aka.ms/new-console-template for more information

using AdapterPattern;

Adaptee adapteeInstance = new Adaptee();
Adapter adapterInstance = new Adapter(adapteeInstance);
Client clientInstance = new Client(adapterInstance);

clientInstance.ClientFunctionality(0);
