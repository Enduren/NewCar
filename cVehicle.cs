using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExercise
{
    interface cVehicle
    {
        string Make { get; set; }
        string Model { get; set; }
        int NumberOfTires { get; set; }
        int Year { get; set; }
    }
}
