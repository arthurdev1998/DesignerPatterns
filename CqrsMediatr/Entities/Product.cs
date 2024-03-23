namespace CqrsMediatr.Entities;

public class Product
{
    public string? Title { get; set; }
    public string? Description { get; set; }

    public Product(string title, string description)
    {
        Title = title;
        Description = description;
    }
}
