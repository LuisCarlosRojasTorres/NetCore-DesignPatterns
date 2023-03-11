// See https://aka.ms/new-console-template for more information
using FacadePattern;


// 1. Class which implements the common functionalities shall be created.
ICommonFunctionalities commonClass = new Class2();

// 2. A FacadeClass shall contain the commonClass
FacadeClass facade = new FacadeClass(commonClass);

// 3. A client class can access to different functionalities through the Facadeclass
ClientClass client = new ClientClass(facade);

client.execute1();
client.execute2();
