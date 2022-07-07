using ASP_CRUD.Data;
using ASP_CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_CRUD.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Book> bookList = _db.books.ToList();
            return View(bookList);
        }
    }
}
