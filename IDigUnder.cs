namespace DiggersAndFliers
{
    public interface IDigUnder
    {

        int DistanceUnderGround { get; set; }

        int SpeedDigging { get; set; }
        void Dig();
    }

}