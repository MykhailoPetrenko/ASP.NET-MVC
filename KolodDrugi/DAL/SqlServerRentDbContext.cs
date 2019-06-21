using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KolodDrugi.Models;
using Microsoft.EntityFrameworkCore;

namespace KolodDrugi.DAL
{
    public class SqlServerRentDbContext : IDbRent
    {
        private readonly RentsDbContext _context;

        public SqlServerRentDbContext(RentsDbContext context)
        {
            _context = context;
        }

        public void AddNewRent(Rent newRent)
        {
            _context.Rents.Add(newRent);
            _context.SaveChanges();
        }

        public IEnumerable<Car> GetCars()
        {
            return _context.Cars
                         .OrderBy(c => c.Model)
                         .ToList();
        }

        public int GetRentCar(Rent newRent)
        {
            return _context.Rents
                   .Include(c => c.Car)
                   .Where(c => c.Car.IdCar == newRent.IdCar && (c.DateFrom <= newRent.DateFrom && c.DateTo >= newRent.DateTo) || (c.DateFrom >= newRent.DateFrom && c.DateTo >= newRent.DateTo))
                   .Count();
        }

        public IEnumerable<Rent> GetRents()
        {
            return _context.Rents
                         .Include(c => c.Car)
                         .OrderBy(c => c.DateFrom)
                         .ToList();
        }
    }
}
