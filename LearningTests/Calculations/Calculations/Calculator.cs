﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Calculations
{
    public class Calculator
    {
        public List<int> FiboNumbers => new List<int> { 1, 1, 2, 3, 5, 8, 13 };
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
