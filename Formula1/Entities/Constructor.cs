using System.ComponentModel.DataAnnotations;

namespace Formula1.Entities
{
    public class Constructor
    {
       
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string EngineSupplier { get; set; } = null!;

        public int CountryId { get; set; }

        public Country Country { get; set; }

        [Required]
        public string IconUrl { get; set; } = null!;

        public List<Driver> Drivers { get; set; } = new List<Driver>();
    }
}
