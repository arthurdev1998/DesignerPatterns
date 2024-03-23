namespace refactoringAbstractingFactory.Products;

public class Samsung321
{
    public string? Nome { get; init; } = "Samsung321";
    public decimal Preco { get; set; } = 8000;
    public string? Info { get => $"Nome: {Nome}, Preco{Preco}"; }
}