// See https://aka.ms/new-console-template for more information
using FacadePattern;

FacadeClass facade = new FacadeClass("Client2");

ClientClass client = new ClientClass(facade);

client.execute1();
client.execute2();
