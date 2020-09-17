using DemoWebApp.Business.Interfaces;
using DemoWebApp.Services.Interfaces;
using DemoWebApp.ViewModels;
using System.Threading.Tasks;

namespace DemoWebApp.Business
{
    public class Rentals : IRentals
    {
        private readonly IBookService _bookService;

        public Rentals(IBookService bookService)
        {
            _bookService = bookService;
        }

        public async Task<LatestRents> GetLatestRents()
        {
            var books = await _bookService.AllBooks();

            var latestRents = new LatestRents();
            latestRents.CurrentLoan = books[3];
            latestRents.RecentLoans = books;
            latestRents.FavoriteCategory = "Cooking!";

            return latestRents;
        }
    }
}
