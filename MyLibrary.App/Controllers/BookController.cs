using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyLibrary.App.Entites;
using MyLibrary.App.Persistence;

namespace MyLibrary.App.Controllers;

[ApiController]
[Route("api/books")]
public class BookController : ControllerBase
{
    private readonly MyLibraryDbContext _context;

    public BookController(MyLibraryDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var books = _context.Books.ToList();
        return Ok(books);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var book = _context.Books.SingleOrDefault(x => x.Id == id);
        return Ok(book);
    }

    [HttpPost]
    public IActionResult Post(Book model, int id)
    {
        var book = _context.Books.Add(model);

        return CreatedAtAction(nameof(GetById), new { id = model.Id }, model);
    }

    [HttpPut]
    public IActionResult Put(int id, Book input)
    {
        var book = _context.Books.SingleOrDefault(b => b.Id == id);

        if (book is null) NotFound("Livro não encontrado");

        _context.Update(input);

        return NoContent();
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        var book = _context.Books.SingleOrDefault(b => b.Id == id);

        if (book is null) return NotFound("Livro não encontrado.");
        
        _context.Books.Remove(book);
        _context.SaveChanges();

        return NoContent();
    }

}