using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{
    public class SquareWall : RectangleWall
    {
        public SquareWall(string name, string color, int sideLength) : base(name, color, sideLength, sideLength)
        {
            this.Sidelength = sideLength;

        }
        public override string ToString()
        {
            return Name + " (" + this.Sidelength + "x" + this.Sidelength + ") square";
        }
        public int Sidelength { get;  }
    }
}
