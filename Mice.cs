namespace DiggersAndFliers
{
    public class Mice : IMoveGround, IDigUnder
    {
        public int DistanceMigrated { get; set; }
        public int GroundSpeed { get; set; }
        public int DistanceUnderGround { get; set; }
        public int SpeedDigging { get; set; }

        public void Dig()
        {
            SpeedDigging = 29;
            DistanceUnderGround = 10;
        }

        public void Scurry()
        {
            DistanceMigrated = 45;
            GroundSpeed = 60;
        }
    }
}