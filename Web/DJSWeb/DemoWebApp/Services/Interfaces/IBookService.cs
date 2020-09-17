using DemoWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebApp.Services.Interfaces
{
    public interface IBookService
    {
        Task<IList<Book>> AllBooks();

        bool AddBook(Book book);
    }
}
