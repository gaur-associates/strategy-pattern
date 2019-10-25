using System;

namespace build_car
{
    public class ChainedStrategy : IStrategy
    {
        private readonly IStrategy _first;
        private readonly IStrategy _next;

        public ChainedStrategy(IStrategy first, IStrategy next)
        {
            _first = first;
            _next = next;
        }
        public Context Execute(Context ctx)
        {
            ctx = _next.Execute(_first.Execute(ctx));
            return ctx;
        }
    }
}
