using System;
using build_car.steps;

namespace build_car
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Context ctx = new Context();
            var buildCar = new AllSteps(ctx);
            buildCar.Execute(ctx);
        }
    }
}
