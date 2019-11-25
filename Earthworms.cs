namespace DiggersAndFliers
{
    public class Earthworms : IDigUnder, IMoveGround
    {
        public int DistanceUnderGround { get; set; }
        public int SpeedDigging { get; set; }
        public int DistanceMigrated { get; set; }
        public int GroundSpeed { get; set; }

        public void Dig()
        {
            SpeedDigging = 1;
            DistanceUnderGround = 11;
        }

        public void Scurry()
        {
            GroundSpeed = 1;
            DistanceMigrated = 1;
        }
    }
}