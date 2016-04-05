using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AimsAcademy2.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        [Required]
        public string studentName { get; set; }
        [Required]
        public string fatherName { get; set; }
        [Required]
        public string fatherContact { get; set; }
        [Required]
        public string rollNo { get; set; }
        [Required]
        public string cnic { get; set; }
        [Required]
        public double feePerMonth { get; set; }
        [Required]
        public double dues { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime date { get; set; }
        [Required]
        [EnumDataType(typeof(groups))]
        public groups group { get; set; }
        [Required]
        [EnumDataType(typeof(sessions))]
        public sessions session { get; set; }
        public enum groups
        {
            Science, Arts
        }
        public enum sessions
        {
            Fall, Spring
        }

        public Address Address { get; set; }
        public int AddressID { get; set; }
    }
}