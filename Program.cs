using System;

namespace ConsoleApp2
{
    class Program
    {

        class Vehicle
        {
            public int wheelSize;
            public int nOfDoors;
            public int milespergal;
            public string colorOfBody;

            public void PrintBase()
            {
                Console.WriteLine("Wheel Size: " + wheelSize);
                Console.WriteLine("Number of Doors: " + nOfDoors);
                Console.WriteLine("Miles per Gallon: " + milespergal);
                Console.WriteLine("Color of Vehicle: " + colorOfBody);
            }

        }

        class BigVehicle : Vehicle
        {
            public string sizeOfVehicle;

            public void Honk()
            {
                Console.WriteLine("HONK HONK!!");
            }
        }
        static void Main(string[] args)
        {
            BigVehicle ford = new BigVehicle();
            ford.wheelSize = 16;
            ford.nOfDoors = 4;
            ford.milespergal = 30;
            ford.colorOfBody = "Red";
            ford.sizeOfVehicle = "Mid-Size";
            ford.PrintBase();
            ford.Honk();

            Console.ReadKey();
        }

       
    }
}