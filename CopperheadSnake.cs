namespace DiggersAndFliers
{
    public class CopperHeadSnake : IDigUnder, IMoveGround
    {
        public int DistanceUnderGround { get; set; }
        public int SpeedDigging { get; set; }
        public int DistanceMigrated { get; set; }
        public int GroundSpeed { get; set; }

        public void Dig()
        {
            DistanceUnderGround = 15;
            SpeedDigging = 66;
        }

        public void Scurry()
        {
            DistanceMigrated = 1000;
            GroundSpeed = 35;
        }
    }
}