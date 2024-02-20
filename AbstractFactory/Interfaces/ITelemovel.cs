namespace AbstractFactory.Interfaces;

public interface ITelemovel
{
    ISmartPhone BuscarsmartPhone();
    INormalPhone BuscarnormalPhone();
}