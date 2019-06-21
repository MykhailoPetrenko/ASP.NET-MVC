using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KolodDrugi.Models
{
    public class Rent
    {
        [Key]
        public int IdRent { get; set; }
        [Required]
        [MaxLength(255)]
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Required]
        [MaxLength(255)]
        [Display(Name = "Client")]
        public string Client { get; set; }
        [Display(Name = "Date from")]
        public DateTime DateFrom { get; set; }
        [Display(Name = "Date to")]
        public DateTime DateTo { get; set; }

        [Display(Name = "Car")]
        public int IdCar { get; set; }
        [ForeignKey("IdCar")]
        public Car Car { get; set; }
    }
}
