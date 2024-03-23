namespace refactoringAbstractingFactory.Products;

public class NokiaTijolao
{
    public string? Nome { get; init; } = "NokiaTijolao";
    public decimal Preco { get; set; } = 8000;
    public string? Info { get => $"Nome: {Nome}, Preco{Preco}"; }
}