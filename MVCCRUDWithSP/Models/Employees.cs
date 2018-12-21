using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCRUDWithSP.Models
{
    public class Employees
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(20)]
        public string City { get; set; }
        [Required]
        [Display(Name = "Department")]
        public string Department { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}
