using System;
using System.Linq;
using System.IO;
using GeoCoordinatePortable;

namespace LoggingKata
{
    class Program
    {
        static readonly ILog logger = new TacoLogger();
        const string csvPath = "TacoBell-US-AL.csv";

        static void Main(string[] args)
        {
            logger.LogInfo("Log initialized");

            var lines = File.ReadAllLines(csvPath);

            logger.LogInfo($"Lines: {lines[0]}");

            var parser = new TacoParser();

            var locations = lines.Select(parser.Parse).ToArray();

            ITrackable locA = null;
            ITrackable locB = null;
            ITrackable locI = null;
            ITrackable locX = null;
            double distance = 0;

            for(int i = 0; i < locations.Length; i++)
            {
                locA = locations[i];
                GeoCoordinate corA = new GeoCoordinate(locA.Location.Latitude, locA.Location.Longitude);

                for(int x = i + 1; x < locations.Length; x++)
                {
                    locB = locations[x];
                    GeoCoordinate corB = new GeoCoordinate(locB.Location.Latitude, locB.Location.Longitude);
                    double currentDistance = corA.GetDistanceTo(corB);

                    if(currentDistance > distance)
                    {
                        distance = currentDistance;
                        locI = locA;
                        locX = locB;
                    }
                }
            }

            Console.WriteLine(locI.Name + locI.Location + locX.Name + locX.Location + distance);

                
            // TODO:  Find the two Taco Bells that are the furthest from one another.
            // HINT:  You'll need two nested forloops
            Console.ReadKey();
        }
    }
}