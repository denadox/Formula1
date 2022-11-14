using Formula1.Entities;
using System.ComponentModel.DataAnnotations;

namespace Formula1.Views
{
    public class AddConstructorView
    {        

        [Required]
        [StringLength(20)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string EngineSupplier { get; set; } = null!;

        public int CountryId { get; set; }

        public List<Driver> Drivers { get; set; } = new List<Driver>();
    }
}
