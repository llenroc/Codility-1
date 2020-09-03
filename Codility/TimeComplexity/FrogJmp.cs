﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Codility
{
    public class FrogJmp
    {
        public int solution(int X, int Y, int D)
        {
            if (X == Y)
                return 0;
            var distance =(double)( Y - X );
            double d = Math.Ceiling( distance / (double)D);
            return System.Convert.ToInt32(d);
        }
    }
}
