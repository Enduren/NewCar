using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    class Motorcycle : Vehicle
    {
        public string EngineNoise { get; set; }

        public Motorcycle()
        {
            NumberOfTires = 2;
        }

        public override void DriveAbstract()
        {
            Console.WriteLine($"I'm driving a {GetType().Name} which is a {GetType().BaseType.Name} in an abstract method");
        }

        public override void DriveVirtual()
        {
            
            base.DriveVirtual();
        }
    }
}