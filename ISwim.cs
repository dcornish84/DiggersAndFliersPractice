namespace DiggersAndFliers
{
    public interface ISwim
    {

        int SwimmingSpeed { get; set; }

        int SwimmingDistance { get; set; }
        void Swim();
    }

}