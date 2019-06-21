using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KolodDrugi.DAL;
using KolodDrugi.Models;
using Microsoft.AspNetCore.Mvc;

namespace KolodDrugi.Controllers
{
    public class RentController : Controller
    {
        private readonly IDbRent _context;
        public RentController(IDbRent context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Rents = _context.GetRents();
            ViewBag.Cars = _context.GetCars();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Rent newRent)
        {
            var p = _context.GetRentCar(newRent);

            Console.WriteLine(p);
            if (!ModelState.IsValid || p > 0 || (newRent.DateFrom>newRent.DateTo))
            {

                ViewBag.Rents = _context.GetRents();
                ViewBag.Cars = _context.GetCars();

                return View("Index", newRent);
            }
            _context.AddNewRent(newRent);
            return RedirectToAction("Index");
        }
    }
}