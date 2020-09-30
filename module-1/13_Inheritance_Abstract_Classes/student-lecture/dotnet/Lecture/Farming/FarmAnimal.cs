using System;
using System.Collections.Generic;

namespace Lecture.Farming
{
    /// <summary>
    /// A base farm animal class.
    /// </summary>
    public abstract class FarmAnimal : IMakesNoise
    {       
        public string Name { get; set; }

        protected FarmAnimal(string name)
        {
            this.Name = name;
        }
        //public abstract string MakeSoundOnce(bool isEvening);

       public string MakeSoundOnce(bool isEvening)
        {
            // Maybe the default behavior should care if it's evening?
            if(isEvening)
            {
                return "Zzzzz";
            }
            return this.MakeSound();
            // What if we had a separate MakeSound method that each inheriting class had to implement?
        }
        public abstract string MakeSound();
        public string MakeSoundTwice(bool isEvening)
        {
            return this.MakeSoundOnce(isEvening) + " " + this.MakeSoundOnce(isEvening);
        }

        public void Pet()
        {

        }

        public void Butcher()
        {
            // Sorry
        }
    }
}
