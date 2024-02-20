using AbstractFactory.Interfaces;

namespace AbstractFactory;

public class TelemovelCliente
{
    ISmartPhone smartPhone;
    INormalPhone normalPhone; 

    public TelemovelCliente(ITelemovel telemovelfactory)
    {
        smartPhone = telemovelfactory.BuscarsmartPhone();
        normalPhone = telemovelfactory.BuscarnormalPhone();
    }

    public string BuscarsmartPhoneModeloDetalhes()
    {
        return smartPhone.BuscarDetalhesModelo();
    }  

    public string BuscarNormalPhoneModeloDetalhes()
    {
        return normalPhone.BuscarDetalhesModelo();
    } 
}