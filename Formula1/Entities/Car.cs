namespace Formula1.Entities
{
    public class Car
    {
        public int DriverId { get; set; }

        public Driver Driver { get; set; }

        public int TyreId { get; set; }

        public Tyre Tyre { get; set; }
    }
}
