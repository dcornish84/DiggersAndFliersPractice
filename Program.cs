using System;
using System.Collections.Generic;

namespace DiggersAndFliers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IFly> flyers = new List<IFly>();
            List<ISwim> swimmers = new List<ISwim>();
            List<IDigUnder> crawlers = new List<IDigUnder>();

            var myAnts = new Ants();
            var myBettaFish = new BettaFish();
            var myCopperheadSnake = new CopperHeadSnake();
            var myEarthworms = new Earthworms();
            var myFinches = new Finches();
            var myGerbils = new Gerbils();
            var myMice = new Mice();
            var myParakeets = new Parakeets();
            var myTerrapins = new Terrapins();
            var myTimberRattlesnake = new TimberRattlesnake();

            flyers.Add(myParakeets);
            flyers.Add(myFinches);

            swimmers.Add(myBettaFish);
            swimmers.Add(myTerrapins);

            crawlers.Add(myAnts);
            crawlers.Add(myCopperheadSnake);
            crawlers.Add(myEarthworms);
            crawlers.Add(myGerbils);
            crawlers.Add(myMice);
            crawlers.Add(myTimberRattlesnake);

        }
    }
}