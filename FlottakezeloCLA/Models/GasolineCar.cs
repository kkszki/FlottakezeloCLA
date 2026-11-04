using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlottakezeloCLA.Models
{
    internal class GasolineCar:Vehicle
    {
        private int fuelTankLevel;

        public int FuelTankLevel {  get { return fuelTankLevel; } set { if (value>=0 && value<=100) { fuelTankLevel = value; } } }

        public GasolineCar() : base("", "", 0, false)
        {
            FuelTankLevel = 0;
        }
        public GasolineCar(int fuelTankLevel, string brand, string model, double speed, bool isRunning) : base(brand, model, speed,isRunning)
        {
            FuelTankLevel = fuelTankLevel;
        }


        public override void Accelerate(double amount)
        {
            if (fuelTankLevel > 0)
            {
                base.Accelerate(amount);
            }
        }

    }
}
