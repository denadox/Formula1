namespace Formula1Test.Entities
{
    public class Constructor
    {
        public Constructor()
        {
            this.Drivers = new List<Driver>();
        }

        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string EngineSupplier { get; set; } = null!;

        public List<Driver> Drivers { get; set; } 
    }
}
