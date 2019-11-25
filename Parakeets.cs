namespace DiggersAndFliers
{
    public class Parakeets : IFly, IMoveGround
    {
        public int FlightSpeed { get; set; }
        public int FlightDistance { get; set; }
        public int DistanceMigrated { get; set; }
        public int GroundSpeed { get; set; }

        public void Fly()
        {
            FlightSpeed = 150;
            FlightDistance = 221;
        }

        public void Scurry()
        {
            GroundSpeed = 2;
            DistanceMigrated = 35;
        }
    }
}