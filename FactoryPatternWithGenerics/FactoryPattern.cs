namespace FactoryPatternWithGenerics;

public static class FactoryPattern<T,U> where T: class, U, new()
{
    public static U GetInterface()
    {
        U obj;
        return (U)(object)new T();
    }
}
