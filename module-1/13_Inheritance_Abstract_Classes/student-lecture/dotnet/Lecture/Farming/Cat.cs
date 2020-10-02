using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public abstract class Cat : FarmAnimal
    {
        //this.Documentation == null
        public Cat() : base("CAT")
        {

        }
        public abstract void Purr();
       
        
    }
    public sealed class CheshireCat : Cat
    {
        public override string MakeSound()
        {
            return "purrr";
        }
        public override void Purr()
        {
            
        }
    }
    //public class PurpleCheshireCat : CheshireCat
    //{

    //}
}
