using DemoWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace DemoWebApp.Controllers
{
    public class BookController : Controller
    {
        private IList<Book> books;
        
        public BookController()
        {
            books = new List<Book>
            {
                new Book { Id = 1, Title = "Cooking with Rick", Author = "Rick" },
                new Book { Id = 2, Title = "Cooking with Hasan", Author = "Hasan" },
                new Book { Id = 3, Title = "Cooking with Hisham", Author = "Hisham" }
            };

            // TODO 17 september
            // Display/Validation Book
            // Update Index Book
            // Create Book
            // Creating Services for Dummy Books.
            // Types of services + Dependency Injection.
            // Async Await
        }

        public IActionResult Index()
        {
            return View(books);
        }
    }
}
