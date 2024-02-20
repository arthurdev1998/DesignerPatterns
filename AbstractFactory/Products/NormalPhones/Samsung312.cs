using AbstractFactory.Interfaces;

namespace AbstractFactory.Products.NormalPhones;

public class Samsung312 : INormalPhone
{
    public string? Nome { private get; init ; } = "Samsung312"; 
    public decimal? Preco { private get; init; } = 400;

    public string? Info {get => $"Nome: {Nome}, preco {Preco!.Value}";}

    public string BuscarDetalhesModelo()
    {
        return Info!;
    }
}