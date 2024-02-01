using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCTask.Models
{
    public class CityModel
    {

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string District { get; set; }

        [Required]
        public string State { get; set; }
    }
}
