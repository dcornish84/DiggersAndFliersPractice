namespace DiggersAndFliers
{
    public class Terrapins : ISwim, IMoveGround
    {
        public int SwimmingSpeed { get; set; }
        public int SwimmingDistance { get; set; }
        public int DistanceMigrated { get; set; }
        public int GroundSpeed { get; set; }

        public void Scurry()
        {
            DistanceMigrated = 10;
            GroundSpeed = 1;
        }

        public void Swim()
        {
            SwimmingSpeed = 15;
            SwimmingDistance = 600;
        }
    }
}