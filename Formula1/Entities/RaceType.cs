using System.ComponentModel.DataAnnotations;

namespace Formula1.Entities
{
    public class RaceType
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Type { get; set; } = null!;
    }
}
