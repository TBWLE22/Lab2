using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle
{
    public abstract class Vehicle
    {
        public abstract void StartEngine();
        public void StopEngine()
        {
            Console.WriteLine("Engine Stopped");
        }
    }
    public class Airplane: Vehicle
    {
        private string model;
        private string manufacturer;
        private int maxcapacity;

        public Airplane (string model, string manufacturer, int maxcapacity)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.maxcapacity = maxcapacity;
        }

        public override void StartEngine()
        {
            Console.WriteLine("Starting airplane engine.");
        }

        public void Takeoff()
        {
            Console.WriteLine("Airplane taking off.");
        }

        public void Land()
        {
            Console.WriteLine("Airlplane Landing.");
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Manufacturer: {manufacturer}");
            Console.WriteLine($"Maximum Capacity: {maxcapacity}");
        }
    }
}
