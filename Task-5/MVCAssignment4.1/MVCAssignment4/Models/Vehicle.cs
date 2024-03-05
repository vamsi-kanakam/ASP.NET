namespace MVCAssignment4.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }


        //Foreign Key
        public int? OwnerId { get; set; }
        public virtual Owner Owner { get; set; }
    }
}
