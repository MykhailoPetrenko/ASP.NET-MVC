using KolodDrugi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolodDrugi.DAL
{
    public interface IDbRent
    {
        IEnumerable<Rent> GetRents();
        IEnumerable<Car> GetCars();
        void AddNewRent(Rent newRent);
        int GetRentCar(Rent newRent);
    }
}
