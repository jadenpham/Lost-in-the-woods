using System.ComponentModel.DataAnnotations;
namespace LostInTheWoods.Models
{
    public class Trail
    {
        [Key]
        public long Id {get; set;}

        [Required]
        [MinLength(3)]
        public string Name {get; set;}

        [Required]
        [MinLength(10)]
        public string Description {get; set;}

        [Required]
        public double Length {get; set;}

        [Required]
        public int Elevation {get; set;}

        [Required]
        [Range(-180, 180)]
        public double Longitude {get; set;}

        [Required]
        [Range(-90, 90)]
        public double Latitude {get; set;}
    }
}