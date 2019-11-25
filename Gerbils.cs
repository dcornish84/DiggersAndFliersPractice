namespace DiggersAndFliers
{

    public class Gerbils : IMoveGround, IDigUnder
    {
        public int DistanceMigrated { get; set; }
        public int GroundSpeed { get; set; }
        public int DistanceUnderGround { get; set; }
        public int SpeedDigging { get; set; }

        public void Dig()
        {
            DistanceUnderGround = 25;
            SpeedDigging = 23;
        }

        public void Scurry()
        {
            DistanceMigrated = 56;
            SpeedDigging = 40;
        }
    }
}