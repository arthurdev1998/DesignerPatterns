using FactoryPatternWithGenerics.Interfaces;

namespace FactoryPatternWithGenerics;

public interface ProductBase : IPrimaryProperties
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}