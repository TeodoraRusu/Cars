﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class car
    {
        public string color;
        public string name;
        public int maxSpeed;
        public int year;
        public void fullThrottle()
        {
            Console.WriteLine(name + "is going at the seed of" + maxSpeed);
        }
    }
}
