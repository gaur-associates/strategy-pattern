using System;
using System.Collections.Generic;
using System.Linq;
using static build_car.MyExtensions;

namespace build_car.steps
{
    public class AllSteps : IStrategy
    {
        IEnumerable<IStrategy> _steps;
        private readonly IStrategy _alternateWay;
        private Context _ctx;

        public Context Execute(Context ctx)
        {
            // foreach (var step in _steps)
            // {
            //     ctx = step.Execute(ctx);
            // }

            ctx = _alternateWay.Execute(ctx);

            return ctx;
        }

        public AllSteps(Context ctx)
        {
            _ctx = ctx;

            // _steps = new List<IStrategy> {
            //     new Tires(_ctx),
            //     new Body(),
            //     new Paint()

            // };
            _alternateWay = new Tires(ctx)
                                             .Then(new Body())
                                             .Then(new Tires(ctx))
                                             .Then(new Paint())
                                             .Then(new Tires(ctx));

        }
    }
}
