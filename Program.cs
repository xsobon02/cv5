using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv5
{
    class Program
    {
        static void Main(string[] args)
        {
            Personal sedan = new Personal (3, 5, 40, 60, Vehicle.FuelType.gasoline);
            sedan.Refuel(5.0 , Vehicle.FuelType.gasoline);
            Truck truck = new Truck(2000, 3000, 40, 60, Vehicle.FuelType.diesel);
            
            sedan.SetRadio(true);
            sedan.SetPreset(2, 93.6);
            sedan.SetPreset(5, 89.5);
            sedan.ChangePreset(5);
            

            Console.WriteLine(sedan);
            Console.WriteLine(truck);
            Console.WriteLine(sedan.radio);

            sedan.ChangePreset(2);
            Console.WriteLine(sedan.radio);
            Console.ReadLine();
            
        }
    }
}
