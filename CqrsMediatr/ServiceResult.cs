namespace CqrsMediatr;

public class ServiceResult<T>
{
    public ServiceResult()
    {
        
    }

    public T? Data { get; set; }
    public bool IsSucess { get; set; } = true;
    public List<string>? ErrorMessage { get; set; } = new List<string>();

    public ServiceResult(T data)
    {
        Data = data;
    }
}
