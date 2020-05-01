using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50,ErrorMessage ="Name can not exceed 50 characters")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z0-9_.]+@[A-Za-z0-9-.]+\.[A-Za-z0-9]+$",ErrorMessage ="Invalid Email Formt")]
         [Display(Name="Office Email")]
        public string Email { get; set; }

        public Dept Department { get; set; }

        public string Photopath { get; set; }

    }
}
