﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Tractor : IMakesNoise
    {
        public void PlowField()
        {

        }

        public string Name
        {
            get
            {
                return "Tractorzilla";
            }
        }

        public string MakeSoundOnce()
        {
            return "vvvvvvvvvvvvvvvroooooom";
        }

        public string MakeSoundTwice()
        {
            return "VRRRRRROOOOOOOOOOOOM";
        }
    }
}

