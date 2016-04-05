using AimsAcademy2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AimsAcademy2.Context
{
    public class AcademyContext : DbContext
    {
        public AcademyContext() : base("AimsAcademyContext")
        {

        }
        public DbSet<Student> Student { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }

    }
}