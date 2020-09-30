using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{
    public class RectangleWall : Wall
    {
        public RectangleWall(string name, string color, int length, int height) : base(name, color)
        {
            
            this.Length = length;
            this.Height = height;
        }
        public override int GetArea()
        {
            return this.Length * this.Height;
        }
        public int Height { get; }

        public int Length { get; }

        public override string ToString()
        {
            return Name + " (" + this.Length +"x" + this.Height+") rectangle";
        }
    }
}
