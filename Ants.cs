namespace DiggersAndFliers
{
    public class Ants : IDigUnder, IMoveGround, ISwim
    {
        public int DistanceUnderGround { get; set; }
        public int SpeedDigging { get; set; }
        public int DistanceMigrated { get; set; }
        public int GroundSpeed { get; set; }
        public int SwimmingSpeed { get; set; }
        public int SwimmingDistance { get; set; }

        public void Dig()
        {;
            SpeedDigging = 150;
            DistanceUnderGround = 100;
        }

        public void Scurry()
        {
            GroundSpeed = 2;
            DistanceMigrated = 35;
        }

        public void Swim()
        {
            SwimmingSpeed = 3;
            SwimmingDistance = 300;
        }
    }

}