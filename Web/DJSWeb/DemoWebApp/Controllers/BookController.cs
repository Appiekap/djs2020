using DemoWebApp.Business.Interfaces;
using DemoWebApp.Models;
using DemoWebApp.Services;
using DemoWebApp.Services.Interfaces;
using DemoWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoWebApp.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IRentals _rentals;

        public BookController(IBookService bookService, IRentals rentals)
        {
            _bookService = bookService;
            _rentals = rentals;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _bookService.AllBooks());
        }

        public async Task<IActionResult> Dashboard()
        {
            return View(await _rentals.GetLatestRents());
        }

        public IActionResult Create()
        {
            return View();
        }

        //[ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Create(/* [Bind("Title,Author")] */Book book)
        {
            if(!ModelState.IsValid)
            {
                return View(book);
            }

            _bookService.AddBook(book);
            return RedirectToAction(nameof(Index));
        }
    }
}
