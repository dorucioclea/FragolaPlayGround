﻿using System.Numerics;

namespace FragolaPlayGround.SolidityLibs
{
    public static class UnsafeMath
    {
        public static BigInteger DivRoundingUp(BigInteger x, BigInteger y)
        {
            var z = x / y;
            if (x % y > 0)
                z += 1;
            return z;
        }
    }
}
