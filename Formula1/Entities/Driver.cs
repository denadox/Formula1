namespace Formula1.Entities
{
    public class Driver
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Abbreviation { get; set; } = null!;

        public int TotalPoints { get; set; }

        public string Team { get; set; } = null!;

        public int CarNumber { get; set; }

        public string Country { get; set; } = null!;
    }
}
