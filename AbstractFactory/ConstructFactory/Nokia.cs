using AbstractFactory.Interfaces;
using AbstractFactory.Products.NormalPhones;
using AbstractFactory.Products.Smartphones;

namespace AbstractFactory.ConstructFactory;

public class Nokia : ITelemovel
{
    public INormalPhone BuscarnormalPhone()
    {
        return new NokiaTijolo1();
    }

    public ISmartPhone BuscarsmartPhone()
    {
        return new Galaxys24();
    }
}