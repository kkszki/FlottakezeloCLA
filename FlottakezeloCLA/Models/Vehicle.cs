using FlottakezeloCLA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlottakezeloCLA.Models
{
    internal abstract class Vehicle : IVehicle
    {

        private string brand;
        private string model;
        private double speed;
        private bool isRunning = false;

        protected Vehicle(string brand, string model, double speed, bool isRunning)
        {
            this.brand = brand;
            this.model = model;
            this.speed = speed;
            this.isRunning = isRunning;
        }

        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public double Speed { get => speed; set => speed = value; }
        public bool IsRunning { get => isRunning; set => isRunning = value; }

        public virtual void StartEngine()
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
             
       public virtual void StopEngine()
        {
            if (!IsRunning)
            
                {
                    Console.WriteLine("A motor már áll!");
                }
            else
            {
                Console.WriteLine("Motor leállt.");
                IsRunning= false;
            }
        }
        public virtual void Accelerate(double amount)
        {
            if (IsRunning)
            {
                speed += amount;
            }
        }

        public void ShowSped()
        {
            Console.WriteLine($"Sebesség: {speed:F1}");
        }



    }
}
