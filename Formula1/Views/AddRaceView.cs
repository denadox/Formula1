using Formula1.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Formula1.Views
{
    public class AddRaceView
    {
        [Required]
        [StringLength(20)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(15)]
        public string Country { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        public int RaceTypeId { get; set; }

        public IEnumerable<RaceType> RaceTypes { get; set; } = new List<RaceType>();

    }
}
