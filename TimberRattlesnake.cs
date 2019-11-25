namespace DiggersAndFliers
{
    public class TimberRattlesnake : IMoveGround, IDigUnder
    {
        public int DistanceMigrated { get; set; }
        public int GroundSpeed { get; set; }
        public int DistanceUnderGround { get; set; }
        public int SpeedDigging { get; set; }

        public void Dig()
        {
            DistanceUnderGround = 19;
            SpeedDigging = 33;
        }

        public void Scurry()
        {
            DistanceMigrated = 20;
            GroundSpeed = 40;
        }
    }
}