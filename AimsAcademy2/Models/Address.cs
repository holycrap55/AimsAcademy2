using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AimsAcademy2.Models
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }
        public string streetNo { get; set; }
        public string houseNo { get; set; }

        public City city { get; set; }
        public int StudentID { get; set; }
    }
}