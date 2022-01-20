﻿
namespace Exercise_4
{
    class Seat : ICar
    {
        public Seat()
        {
        }

        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Model { get; set; }
        public string Color { get; set; }

        public string Start() => "Engine start";


        public string Stop() => "Breaaak!";


        public override string ToString() => $"{Color} Seat {Model} \n{Start()} \n{Stop()}";

    }
}
