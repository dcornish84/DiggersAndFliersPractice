namespace DiggersAndFliers
{
    public interface IFly
    {

        int FlightSpeed { get; set; }

        int FlightDistance { get; set; }
        void Fly();
    }

}