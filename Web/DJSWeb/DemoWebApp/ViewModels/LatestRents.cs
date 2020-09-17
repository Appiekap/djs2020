using DemoWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebApp.ViewModels
{
    public class LatestRents
    {
        public Book CurrentLoan { get; set; }
        public IList<Book> RecentLoans { get; set; }
        public string FavoriteCategory { get; set; }
    }
}
