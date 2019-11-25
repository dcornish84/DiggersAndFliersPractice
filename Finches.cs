namespace DiggersAndFliers
{
    public class Finches : IFly, IMoveGround
    {
        public int FlightSpeed { get; set; }
        public int FlightDistance { get; set; }
        public int DistanceMigrated { get; set; }
        public int GroundSpeed { get; set; }

        public void Fly()
        {
            FlightSpeed = 111;
            FlightDistance = 211;
        }

        public void Scurry()
        {
            GroundSpeed = 10;
            DistanceMigrated = 1000;
        }
    }
}