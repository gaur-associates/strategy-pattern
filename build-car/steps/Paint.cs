using System;

namespace build_car.steps
{
    public class Paint : IStrategy
    {
        public Context Execute(Context ctx)
        {
            if (ctx.Continue) Console.WriteLine("Painter Car");
            return ctx;
        }
    }
}
