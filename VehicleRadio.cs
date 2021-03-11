using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv5
{
    public class VehicleRadio
    {
        public double currentFreq { get; protected set; }
        public bool radioStatus { get; protected set; }
        private Dictionary<int, double> presets;

        public VehicleRadio()
        {
            presets = new Dictionary<int, double>();
            radioStatus = false;
            currentFreq = 87.0; //87-108MHz
        }
        public void SetRadio(bool onOff)
        {
            radioStatus=onOff;
                
        }
        public void SetPreset(int number, double freq)
        {
            
            if (!radioStatus)
            {
                throw new Exception("Radio is not on.");
            }
            if (freq<87.0||freq>108.0)
            {
                throw new Exception("This frequency is out of set range.");
            }
            presets.Add(number, freq);
        }

        public void ChangePreset(int number)
        {
            if (!presets.ContainsKey(number))
            {
                throw new Exception("This preset doesn't have a frequency set to it.");
            }
            if (!radioStatus)
            {
                throw new Exception("Radio is not on.");
            }
            currentFreq = presets[number];
        }

        public override string ToString()
        {
            if (radioStatus)
            {
                return String.Format($"Radio is ON, Current Frequency: {currentFreq} MHz");
            }
            else
                return String.Format($"Radio is OFF.");
        }
    }
}
