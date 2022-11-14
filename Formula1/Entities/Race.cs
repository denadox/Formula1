using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Formula1.Entities
{
    public class Race
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(15)]
        public string Country { get; set; } = null!;

        public int RaceTypeId { get; set; }

        [ForeignKey(nameof(RaceTypeId))]
        public RaceType RaceType { get; set; }
    }
}
