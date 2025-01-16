namespace MyLibrary.App.Entites;

public class Emprestimo : BaseEntity
{
    public Emprestimo()
    {
        DataEmprestimo = DateTime.Now;
    }
    public int IdUser { get; set; }
    public int IdBook { get; set; }
    public DateTime DataEmprestimo { get; set; }
}