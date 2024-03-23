namespace refactoringAbstractingFactory.Products;

public class WindowsPhone
{
    public string? Nome { get; init; } = "WindowsPhone";
    public decimal Preco { get; set; } = 8000;
    public string? Info { get => $"Nome: {Nome}, Preco{Preco}"; }
}