using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    class Car : Vehicle
    {
        public int NumberOfWindows { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"I'm driving a {GetType().Name} in an abstract method, it is a {GetType().BaseType.Name}");
        }

        public override void DriveVirtual()
        {
           
            Console.WriteLine($"I'm driving a {GetType().Name} in a virtual method, it is a {GetType().BaseType.Name}");
        }
    }
}