using System;

namespace ChallengeSixClassLibrary
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int MaxMileRange { get; set; }

        public Car(string make, string model, int maxMileRange)
        {
            Make = make;
            Model = model;
            MaxMileRange = maxMileRange;
        }
        public Car()
        {

        }
    }
}
