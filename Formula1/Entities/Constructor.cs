namespace Formula1.Entities
{
    public class Constructor
    {
        public Constructor()
        {
            Drivers = new List<Driver>();
        }

        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string EngineSupplier { get; set; } = null!;

        public List<Driver> Drivers { get; set; }
    }
}
