using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv5
{
    public abstract class Vehicle
    {
        public enum FuelType {gasoline,diesel};
        public VehicleRadio radio = new VehicleRadio();

        
        public FuelType SetFuel { get; protected set; }
        public Vehicle(double status,double size, FuelType fuel)
        {
            tankStatus = status;
            tankSize = size;
            SetFuel = fuel;
        }
        public double tankSize { get; protected set; }
        public double tankStatus { get; protected set; }
        public void Refuel(double amount, FuelType fuel)
        {
            if(fuel != SetFuel)
            {
                throw new Exception("You're using the wrong type of fuel.");
            }
            if ((tankStatus+amount) <= tankSize)
            {
                tankStatus = tankStatus + amount;
            }
            else
            {
                throw new Exception("This amount of fuel won't fit into the tank.");
            }
        }
        public void SetRadio(bool x)
        {
            radio.SetRadio(x);
        }

        public void SetPreset(int number, double freq)
        {
            radio.SetPreset(number, freq);
        }

        public void ChangePreset(int number)
        {
            radio.ChangePreset(number);
        }
        
    }
}
