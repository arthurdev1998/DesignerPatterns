namespace FactoryPatternWithGenerics.Interfaces;

public interface ICategoryBase
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int CategoryId { get; set; }
}
