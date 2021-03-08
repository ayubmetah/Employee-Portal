using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Portal.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your nationality")]
        public string Nationality { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)] 
        public DateTime DOB { get; set; }

        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Invalid input, only integers accepted")]
        [Range(16, 60, ErrorMessage = "Age is out of range, 20-60 only")]
        public int Age { get; set; }
        
        [Required(ErrorMessage = "Please enter your Passport number")]
        public string Passport { get; set; }

        [Column(TypeName = "int(11")]
        public decimal QID { get; set; }

        [RegularExpression(@"^[MF]+$", ErrorMessage = "Select any one option")]
        public Char Gender { get; set; }

        [RegularExpression(@"^[MF]+$", ErrorMessage = "Select any one option")]
        public Char MaritalStatus { get; set; }

        [Display(Name = "Joining Date")]
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }

        [Column(TypeName = "decimal(18, 0)")]
        public decimal Salary { get; set; }

        public string Department { get; set; }

        [Required(ErrorMessage = "Please enter your academic qualification")]
        public string Education { get; set; }

    }
}
