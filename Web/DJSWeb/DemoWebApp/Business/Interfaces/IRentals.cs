using DemoWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebApp.Business.Interfaces
{
    public interface IRentals
    {
        Task<LatestRents> GetLatestRents();
    }
}
