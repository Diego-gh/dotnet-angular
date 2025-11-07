using Microsoft.AspNetCore.Mvc;
using Backend.Models;

namespace Backend.Controllers;

[ApiController]
[Route("api/[controller]")] // Define the route for the controller

public class BooksController : ControllerBase
{
  private static readonly List<Book> Books = new List<Book>
    {
        new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald" },
        new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee" },
        new Book { Id = 3, Title = "1984", Author = "George Orwell" }
    };

  [HttpGet]
  public ActionResult<List<Book>> GetBooks()
  {
    return Ok(Books);
  }

  [HttpGet("{id}")]
  public ActionResult<Book> GetBook(int id)
  {
    var book = Books.FirstOrDefault(b => b.Id == id);
    if (book == null)
    {
      return NotFound();
    }
    return Ok(book);
  }

  [HttpPost]
  public ActionResult<Book> AddBook(Book newBook)
  {
    if (newBook == null || string.IsNullOrEmpty(newBook.Title) || string.IsNullOrEmpty(newBook.Author))
    {
      return BadRequest("Invalid book data.");
    }

    newBook.Id = Books.Max(b => b.Id) + 1;
    Books.Add(newBook);
    return CreatedAtAction(nameof(GetBook), new { id = newBook.Id }, newBook);
  }
}