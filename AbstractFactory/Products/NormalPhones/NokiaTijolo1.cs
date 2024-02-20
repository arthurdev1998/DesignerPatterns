using AbstractFactory.Interfaces;

namespace AbstractFactory.Products.NormalPhones;

public class NokiaTijolo1 : INormalPhone
{
    public string? Nome { get; set; } = "NokiaTijolo1";
    public decimal? Preco { get; set; } = 500;

    public string? Info {get => $"Nome: {Nome}, preco {Preco!.Value}";}

    public string BuscarDetalhesModelo()
    {
        return Info!;
    }
}
