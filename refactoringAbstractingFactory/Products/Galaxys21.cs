namespace refactoringAbstractingFactory.Products;

public class Galaxys21
{
    public string? Nome { get; init; } = "Galaxy s21Turbo";
    public decimal Preco { get; set; } = 8000;
    public string? Info { get => $"Nome: {Nome}, Preco{Preco}"; }
}