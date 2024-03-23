namespace CqrsMediatr;

public class ServiceResult<T>
{
    public ServiceResult()
    {      
    }

    public T? Data { get; set; } = default;
    public bool IsSucess { get; set; } = true;
    public List<string>? ErrorMessage { get; set; } = [];

    public ServiceResult(T data)
    {
        Data = data;
    }
}
