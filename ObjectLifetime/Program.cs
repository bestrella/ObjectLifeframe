using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            //set properties

            Car myOtherCar = myCar;


            myOtherCar = null;

            myCar = null;
        }

        class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }
            public double originalPrice { get; set; }


            public Car()
            {
                this.Make = "NISSAN";

            }

            public Car(String make, String model, int year, string color)
            {

                Make = make;
                Model = model;
                Year = year;
                Color = color;

            }

        }
    }
}
