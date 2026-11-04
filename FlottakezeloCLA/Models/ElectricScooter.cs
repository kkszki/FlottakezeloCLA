using FlottakezeloCLA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlottakezeloCLA.Models
{
    internal class ElectricScooter:IVehicle, IElectric
    {
        bool isRunning;
        int batteryLevel;
        string brand;

        public ElectricScooter(bool isRunning, int batteryLevel, string brand)
        {
            this.isRunning = isRunning;
            this.batteryLevel = batteryLevel;
            this.brand = brand;
        }
        public ElectricScooter()
        {
            this.isRunning = false;
            this.batteryLevel = 0;
            this.brand ="";
        }


        public bool IsRunning { get => isRunning; set => isRunning = value; }
        public int BatteryLevel { get => batteryLevel; set => batteryLevel = value; }
        public string Brand { get => brand; set => brand = value; }

        public  void StartEngine()
        {
            if (IsRunning)
            {
                Console.WriteLine("Már jár a motor!");
            }
            else

            {
                Console.WriteLine("Motor elindult");
                IsRunning = true;
            }
        }
        public void StopEngine()
        {
            if (!IsRunning)

            {
                Console.WriteLine("A motor már áll!");
            }
            else
            {
                Console.WriteLine("Motor leállt.");
                IsRunning = false;
            }
        }
        public void Charge(double percentage)
        {
            if (percentage != 0)
            {
                batteryLevel += (int)percentage;
            }
            else
            {
                batteryLevel = 1;
            }
        }

    }
}
