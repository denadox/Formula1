using System.ComponentModel.DataAnnotations;

namespace Formula1.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        public string Name { get; set; } = null!;
    }
}
