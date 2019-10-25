using System;

namespace build_car.steps
{
    public class Body : IStrategy
    {
        public Context Execute(Context ctx)
        {
            if (ctx.Continue) Console.WriteLine("Body Chassis ordered");

            return ctx;
        }
    }
}
