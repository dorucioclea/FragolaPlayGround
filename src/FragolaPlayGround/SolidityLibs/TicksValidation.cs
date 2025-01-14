﻿using System;

namespace FragolaPlayGround.SolidityLibs
{
    public static class TicksValidation
    {
        public static void CheckTick(int tick)
        {
            if (tick is not (>= TickMath.MinTick and <= TickMath.MaxTick))
                throw new ArgumentException();
        }

        public static void CheckTicks(int tickLower, int tickUpper)
        {
            if (tickLower >= tickUpper)
                throw new ArgumentException("TLU");
            if (tickLower < TickMath.MinTick)
                throw new ArgumentOutOfRangeException(nameof(tickLower), tickLower, "tickLower lower minimum");
            if (tickUpper > TickMath.MaxTick)
                throw new ArgumentOutOfRangeException(nameof(tickUpper), tickUpper, "tickUpper upper maximum");
        }
    }
}
