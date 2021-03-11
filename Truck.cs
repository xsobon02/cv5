using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv5
{
    public class Truck : Vehicle
    {
        public Truck(int load, int max, double status, double size, FuelType fuel) : base(status, size, fuel)
        {
            maxLoad = max;
            presentLoad = load;
            if (load > max)
            {
                throw new Exception("This load won't fit into the car.");
            }
            if (status > size)
            {
                throw new Exception("The tank is not big enough for this amount of fuel.");
            }
        }
        public int maxLoad { get; protected set; }
        public int presentLoad { get; protected set; }
        public override string ToString()
        {
            return String.Format($"Load in the truck: {presentLoad}kg out of {maxLoad}kg \nAmount of fuel in the tank: {tankStatus}l out of {tankSize}l \nFuel Type: {SetFuel}");
        }
    }
}
