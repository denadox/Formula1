using System.ComponentModel.DataAnnotations;

namespace Formula1.Entities
{
    public class Tyre
    {
        public int Id { get; set; }


        //Hards,Mediums,Softs,Wets,Inters
        [Required]
        public string Type { get; set; } = null!;

        [Required]
        public string Abbreviation { get; set; } = null!;
    }
}
