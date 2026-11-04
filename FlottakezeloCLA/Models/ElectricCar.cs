using FlottakezeloCLA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FlottakezeloCLA.Models
{
    internal class ElectricCar: Vehicle, IElectric
    {
        public int BatteryLevel { get; set; } = 1;

        public ElectricCar() : base("", "", 0, false)
        {
        }

        public ElectricCar(int batteryLevel, string brand, string model, double speed, bool isRunning) :base(brand, model, speed, isRunning)
        {
            BatteryLevel = batteryLevel;
        }

        public override void StartEngine()
        {
            if (BatteryLevel > 0)
            {
                base.StartEngine();
            }
            else
            {
                Console.WriteLine("Az akkumulátor lemerült!");
            }
        }

        public void Charge(double percentage)
        {
           
            if (BatteryLevel == 0)
            {
                BatteryLevel = 1;
            }
            else
            {
                BatteryLevel += (int)percentage;
            }

        }
    }
}
