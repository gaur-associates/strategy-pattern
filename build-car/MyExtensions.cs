using System;

namespace build_car
{
    public static class MyExtensions
    {
        static public IStrategy Then(this IStrategy first, IStrategy next)
        {

            var chained = new ChainedStrategy(first, next);
            return chained;
        }
    }
}
