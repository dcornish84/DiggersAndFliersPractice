namespace DiggersAndFliers
{
    public class BettaFish : ISwim
    {
        public int SwimmingSpeed { get; set; }
        public int SwimmingDistance { get; set; }

        public void Swim()
        {
            SwimmingSpeed = 35;
            SwimmingDistance = 10000;
        }
    }

}