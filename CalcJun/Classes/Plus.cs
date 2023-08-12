﻿using System;
using CalcJun.Interfaces;

namespace CalcJun
{
    public class Plus : IOperation
    {
        private string name = "+";

        public string Name
        {
            get { return name; }
        }

        public float Execute(float a, float b)
        {
            return a + b;
        }
    }
}

