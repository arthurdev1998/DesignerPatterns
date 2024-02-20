using AbstractFactory.Interfaces;

namespace AbstractFactory.Products.Smartphones;

public class Galaxys24 : ISmartPhone
{
    public string? Nome { get; set; } = "Galaxys24";
    public decimal? Preco { get; set; } = 8000;

    public string? Info {get => $"Nome: {Nome}, preco {Preco!.Value}";}

    public string BuscarDetalhesModelo()
    {
        return Info!;
    }
}