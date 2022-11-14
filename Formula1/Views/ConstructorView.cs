using Formula1.Entities;
using System.ComponentModel.DataAnnotations;

namespace Formula1.Views
{
    public class ConstructorView
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string EngineSupplier { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string Country { get; set; } = null!;

    }
}
