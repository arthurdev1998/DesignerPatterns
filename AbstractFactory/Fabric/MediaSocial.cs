namespace AbstractFactory.Fabric;

public interface IMediaSocial<T>
{
    public T CreateMediaSocial()
    {
        var typeOfInterface = typeof(T).GetInterfaces();

        if (typeOfInterface.Any(x => typeof(Facebook) == x))
        {
            return (T)(object)new Facebook();
        }

        else if (typeOfInterface.Any(x => typeof(Twitter) == x))
        {
            return (T)(object)new Twitter();
        }

        throw new Exception();
    }
}