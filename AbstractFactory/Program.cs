using AbstractFactory;
using AbstractFactory.ConstructFactory;

TelemovelCliente cliente = new TelemovelCliente(new Nokia());
Console.WriteLine(cliente.BuscarsmartPhoneModeloDetalhes());
Console.WriteLine(cliente.BuscarNormalPhoneModeloDetalhes());
