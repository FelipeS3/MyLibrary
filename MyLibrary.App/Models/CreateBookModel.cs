namespace MyLibrary.App.Models;

public class CreateBookModel
{
    public string Title { get; set; }
    public string Owner { get; set; }
    public string ISBN { get; set; }
    public int AnoPublicacao { get; set; }
}