using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KolodDrugi.Models
{
    public class Car
    {
        [Key]
        public int IdCar { get; set; }
       
        public string RegisterNumber { get; set; }
        [Required]
        [MaxLength(150)]
        public string Model { get; set; }

        public string ModelRegist => Model + " " + RegisterNumber;

        public ICollection<Rent> Rents { get; set; }
    }
}
