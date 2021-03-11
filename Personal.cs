using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv5
{
    public class Personal : Vehicle
    {

        public Personal(int present, int max, double status,double size, FuelType fuel) : base(status, size, fuel)
        {
            maxPeople = max;
            presentPeople = present;
            if (present > max)
            {
                throw new Exception("This number of people won't fit into the car.");
            }
            if (status > size)
            {
                throw new Exception("The tank is not big enough for this amount of fuel.");
            }
        }
        public int maxPeople { get; protected set; }
        public int presentPeople { get; protected set; }
        public override string ToString()
        {
            return String.Format($"People in the personal vehicle: {presentPeople} out of {maxPeople} \nAmount of fuel in the tank: {tankStatus}l out of {tankSize}l \nFuel Type: {SetFuel}");
        }
    }
    
}
