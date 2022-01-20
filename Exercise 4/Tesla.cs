using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Tesla : ICar, IElectricCar
    {
        public Tesla()
        {
        }

        public Tesla(string model, string color, int battery)
        {
            Battery = battery;
            Model = model;
            Color = color;
        }

        public int Battery { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public string Start() => "Engine start";


        public string Stop() => "Breaaak!";

        public override string ToString() => $"{Color} Tesla {Model} with {Battery} Batteries\n{Start()} \n{Stop()}";
    }
}
