using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using PresentationLayer.Models;
using BusinessLogic.Repository;
using DataAccessLayer.EF;

namespace PresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Context _context;
        public HomeController(ILogger<HomeController> logger, Context context)
        {
            if (logger == null) throw new ArgumentNullException(nameof(logger));
            _logger = logger;
            if (context == null) throw new ArgumentNullException(nameof(context));
            _context = context;
        }

        public IActionResult Index()
        {
            EFCustomerRepository repo = new EFCustomerRepository(_context);
            List<BusinessLogic.Entities.Customer> customers = repo.GetAllCustomer().ToList();
            return View(customers);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
