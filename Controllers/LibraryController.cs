using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class LibraryController : ControllerBase
{
    private static readonly Library[] Libraries =
    {
        new Library { Name ="קרית ספר", Address = "נתיבות המשפט 111" },
        new Library { Name = "ברכפלד", Address = "רשבי" }
    };

    private static readonly Book[] Books =
    {
        new Book { Title = "סוף הקיץ", Author = "נ' ארי", Year = 2026, Amount = 10 },
        new Book { Title = "אשא עיני", Author = " ליבי קליין ", Year = 2024, Amount = 23 },
        new Book { Title = "נשמה ביד", Author = "ל' סירוקה  ", Year = 2026, Amount = 14 }
    };

    private readonly ILogger<LibraryController> _logger;

    public LibraryController(ILogger<LibraryController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetLibraries")]
    public IEnumerable<Library> GetLibraries()
    {
        return Libraries;
    }

    [HttpGet("books", Name = "GetBooks")]
    public IEnumerable<Book> GetBooks()
    {
        return Books;
    }
}
