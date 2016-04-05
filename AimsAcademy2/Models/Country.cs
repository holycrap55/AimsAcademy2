using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AimsAcademy2.Models
{
    public class Country
    {
        public int CountryID { get; set; }
        public string countryName { get; set; }
        public string countryCode { get; set; }
        public ICollection<City> cities { get; set; }
    }
}