using System;

namespace build_car.steps
{
    public class Tires : IStrategy
    {
        public Tires(Context ctx)
        {

        }

        public Context Execute(Context ctx)
        {
            if (ctx.Continue) Console.WriteLine("Ordered Tires");
            return ctx;
        }
    }
}
