using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Repository;
using DataAccessLayer.EF;
using AutoMapper;

namespace PresentationLayer.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Context _context;
        private readonly IMapper _mapper;
        public CustomersController(ILogger<HomeController> logger, Context context, IMapper mapper)
        {
            if (logger == null) throw new ArgumentNullException(nameof(logger));
            _logger = logger;
            if (context == null) throw new ArgumentNullException(nameof(context));
            _context = context;
            if (mapper == null) throw new ArgumentNullException(nameof(mapper));
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            FakeData fake = new FakeData();
            List<PLCustomer> customers = _mapper.Map<List<PLCustomer>>(fake.GetAllCustomer().ToList());

            return View(customers);
        }
    }
}
