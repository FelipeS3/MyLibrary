namespace MyLibrary.App.Entites;

public class Book : BaseEntity
{
    public string Title { get; set; }
    public string Owner { get; set; }
    public string ISBN { get; set; }
    public int AnoPublicacao { get; set; }

    public void Update(string title, string owner, string isbn, int anoPublicacao)
    {
        Title = title;
        Owner = owner;
        ISBN = isbn;
        AnoPublicacao = anoPublicacao;
    }
}