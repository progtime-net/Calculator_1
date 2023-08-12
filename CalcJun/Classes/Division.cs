﻿using System;
using CalcJun.Interfaces;

namespace CalcJun.Classes
{
    public class Division : IOperation
    {
        private string name = "/";

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

