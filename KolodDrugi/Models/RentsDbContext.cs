using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolodDrugi.Models
{
    public class RentsDbContext : DbContext
    {
        public RentsDbContext(DbContextOptions opt)
            : base(opt)
        {

        }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}
