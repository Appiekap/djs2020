using DemoWebApp.Models;
using DemoWebApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebApp.Services
{
    public class DummyBookService : IBookService
    {
        private IList<Book> books;

        public DummyBookService()
        {
            books = new List<Book>
            {
                new Book { Id = 1, Title = "Cooking with Rick", Author = "Rick", PublishedDate = DateTime.Now },
                new Book { Id = 2, Title = "Cooking with Hasan", Author = "Hasan", PublishedDate = DateTime.Now },
                new Book { Id = 3, Title = "Cooking with Hisham", Author = "Hisham", PublishedDate = DateTime.Now },
                new Book { Id = 4, Title = "Cooking with Nesreen", Author = "Nesreen", PublishedDate = DateTime.Now }
            };
        }

        public bool AddBook(Book book)
        {
            books.Add(book);
            return true;
        }

        public async Task<IList<Book>> AllBooks()
        {
            var result = await DoSomething();
            return books;
        }

        public async Task<int> DoSomething()
        {
            await Task.Delay(2000);
            return 42;
        }
    }
}
