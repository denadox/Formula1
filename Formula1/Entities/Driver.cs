using System.ComponentModel.DataAnnotations;

namespace Formula1.Entities
{
    public class Driver
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string LastName { get; set; } = null!;

        [Required]
        [StringLength(3)]
        public string Abbreviation { get; set; } = null!;

        public int TotalPoints { get; set; }

        [Required]
        [StringLength(15)]
        public string Team { get; set; } = null!;

        public int CarNumber { get; set; }

        [Required]
        [StringLength(20)]
        public string Country { get; set; } = null!;
    }
}
