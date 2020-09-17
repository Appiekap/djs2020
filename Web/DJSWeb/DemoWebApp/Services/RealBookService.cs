using DemoWebApp.Models;
using DemoWebApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebApp.Services
{
    public class RealBookService : IBookService
    {
        public bool AddBook(Book book)
        {
            return true;
        }

        public async Task<IList<Book>> AllBooks()
        {
            await Task.Delay(1000);
            return new List<Book>();
        }

    }
}
