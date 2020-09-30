using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    class Griffyn : FarmAnimal
    {
        public Griffyn() : base("GRIFFYN")
        {

        }
        public override string MakeSound()
        {
            return "Yo, I have the head of a hawk";
        }
    }
}
