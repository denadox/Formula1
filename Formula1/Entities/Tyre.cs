using System.ComponentModel.DataAnnotations;

namespace Formula1.Entities
{
    public class Tyre
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(10)]
        public string Type { get; set; } = null!;

        [Required]
        [StringLength(1)]
        public string Abbreviation { get; set; } = null!;
    }
}
