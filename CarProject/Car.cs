using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    public class Car
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }

        public Car(string brand, string color)
        {
            Brand = brand;
            Color = color;

            // Console.WriteLine($"Car created: {Brand} in {Color}");
            Console.WriteLine("Car created: " + Brand + " in " + Color);
        }

        public void Accelerate(int Amount)
        {
            Speed += Amount;
            Console.WriteLine($"Accelerating... Current Speed: {Speed} km/h"); 

        }

    }
}
