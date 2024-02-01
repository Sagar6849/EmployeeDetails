using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeTask.Models
{
    public class EmployeeModel
    {

        [Required]
        public string Name { get; set; }

        [Required]
        public string Designation { get; set; }

        [Required]
        public decimal Salary { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string District { get; set; }

        [Required]
        public int CityId { get; set; } 
        
        [ForeignKey("CityId")]
        public CityModel CityModel { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string MobileNo { get; set; }
    }
}
