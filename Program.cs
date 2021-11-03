using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  ClassExercise

{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vehicles

            List<Vehicle> vehicles = new List<Vehicle>();

            Vehicle car1 = new Car() { Year = "2016", Make = "nissian", Model = "altima", NumberOfTires = 4, NumberOfWindows = 5 };
            Car car2 = new Car() { Year = "2022", Make = "Ford", Model = "Fuison", NumberOfTires = 4, NumberOfWindows = 2 };
            Motorcycle motor1 = new Motorcycle() { Year = "2013", Make = "Harley-Davidson", Model = "Cruiser", EngineNoise = "vrrrrroom" };
            Vehicle motor2 = new Motorcycle(); 

            vehicles.Add(car1);
            vehicles.Add(car2);
            vehicles.Add(motor1);
            vehicles.Add(motor2);

            foreach (var item in vehicles)
            {
                
                Console.WriteLine($"{item.Year} {item.Make} {item.Model}");
                Console.WriteLine();
            }

            
            car1.DriveAbstract();
            Console.WriteLine();
            car1.DriveVirtual();
            Console.WriteLine();
            motor1.DriveAbstract();
            Console.WriteLine();
            motor1.DriveVirtual();

            #endregion

            Console.ReadLine();
        }
    }
}