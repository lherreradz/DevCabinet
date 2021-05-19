using CRUDNetCore5.Data;
using CRUDNetCore5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDNetCore5.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Http Get Index
        public IActionResult Index()
        {
            IEnumerable<Book> bookList = _context.Book;
            return View(bookList);
        }

        //Http Get Create
        public IActionResult Create()
        {
            return View();
        }

        //Http Post Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Book.Add(book);
                _context.SaveChanges();

                TempData["message"] = "Success, book created!!";

                return RedirectToAction("Index");
            }

            return View();
        }

        //Http Get Edit
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            var book = _context.Book.Find(id);

            if(book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        //Http Post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Book.Update(book);
                _context.SaveChanges();

                TempData["message"] = "Success, book edited!!";

                return RedirectToAction("Index");
            }

            return View();
        }

        //Http Get Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var book = _context.Book.Find(id);

            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        //Http Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteBook(int? id)
        {
            var book = _context.Book.Find(id);

            if (book == null)
            {
                return NotFound();
            }

            _context.Book.Remove(book);
            _context.SaveChanges();

            TempData["message"] = "Success, book deleted!!";

            return RedirectToAction("Index");
        }
    }
}
