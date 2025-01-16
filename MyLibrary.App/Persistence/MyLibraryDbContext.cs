using Microsoft.EntityFrameworkCore;
using MyLibrary.App.Entites;

namespace MyLibrary.App.Persistence;

public class MyLibraryDbContext : DbContext
{
    public MyLibraryDbContext(DbContextOptions<MyLibraryDbContext> options) : base(options) { }

    public DbSet<Book> Books { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Emprestimo> Emprestimo { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Book>(e =>
        {
            e.HasKey(b => b.Id);
        });

        builder.Entity<User>(e =>
        {

        });

        builder.Entity<Emprestimo>(e =>
        {

        });
    }
}