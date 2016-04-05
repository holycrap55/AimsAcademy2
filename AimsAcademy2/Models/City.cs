using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AimsAcademy2.Models
{
    public class City
    {
        [Key]
        public int CityID { get; set; }
        public string cityName { get; set; }
        public Country countries { get; set; }

        public ICollection<Address> addresses { get; set; }
    }
}