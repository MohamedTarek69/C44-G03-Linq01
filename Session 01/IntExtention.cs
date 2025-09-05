using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01
{
    internal static class IntExtention
    {
        public static int Reverse(this int Number)
        {
            int ReversedNumber = 0, Remainder;
            while (Number != 0)
            {
                Remainder = Number % 10;
                ReversedNumber = ReversedNumber * 10 + Remainder;
                Number = Number / 10;
            }
            return ReversedNumber;
        }

        public static long Reverse(this long Number)
        {
            long ReversedNumber = 0, Remainder;
            while (Number != 0)
            {
                Remainder = Number % 10;
                ReversedNumber = ReversedNumber * 10 + Remainder;
                Number = Number / 10;
            }
            return ReversedNumber;
        }

    }
}
