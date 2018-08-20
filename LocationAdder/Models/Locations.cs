using System.ComponentModel.DataAnnotations;

namespace LocationAdder.Models
{
    public class Locations
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter city name")]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter city latitude")]
        public double Latitude { get; set; }
        [Required(ErrorMessage = "Please enter city longitude ")]
        public double Longitude { get; set; }
        public string Description { get; set; }
    }
}