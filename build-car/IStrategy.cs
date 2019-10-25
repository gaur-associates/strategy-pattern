using System;

namespace build_car
{

    public interface IStrategy
    {
        Context Execute(Context ctx);
    }
}
