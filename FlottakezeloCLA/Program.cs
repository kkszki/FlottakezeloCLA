using FlottakezeloCLA.Interfaces;
using FlottakezeloCLA.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlottakezeloCLA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IVehicle> jarmuvek = new List<IVehicle>();

            jarmuvek.Add(new GasolineCar(30, "Toyota", "Corolla", 0.0, true));
            jarmuvek.Add(new ElectricCar(70, "Toyota", "Prius", 20.3, false));
            jarmuvek.Add(new ElectricScooter(true, 20, "Xiaomi"));

            List<string> electricVehicles = new List<string>();

            foreach (IVehicle vehicle in jarmuvek)
            {
                vehicle.StartEngine();

                if (vehicle is IElectric electric)
                {
                    electric.Charge(100);

                    if (vehicle is ElectricCar v)
                    {
                        electricVehicles.Add(v.Brand);
                    }
                    else if (vehicle is ElectricScooter scooter)
                    {
                        electricVehicles.Add(scooter.Brand);
                    }
                }
            }

            File.WriteAllLines("electric.txt", electricVehicles);
        }
    }
}
