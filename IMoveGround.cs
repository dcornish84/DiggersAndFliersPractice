namespace DiggersAndFliers
{
    public interface IMoveGround
    {

        int DistanceMigrated { get; set; }

        int GroundSpeed { get; set; }
        void Scurry();
    }

}