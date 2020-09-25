using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /**
    * This class represents a dog that can sleep, wake, and make a sound, so it's pretty much like most dogs,
    * with a few essential methods missing. Thankfully.
    */
    public class Dog
    {
        
        /// <summary>
        /// All new dogs are awake by default.
        /// </summary>
        public bool IsSleeping { get; private set; }

        /// <summary>
        /// Returns "Zzzz... if the dog is asleep. Returns "Woof!" if the dog is awake.
        /// </summary>
        /// <returns></returns>
        public string MakeSound()
        {
            if(IsSleeping == true)
            {
                return "Zzzzz...";
            }
            if(IsSleeping == false)
            {
                return "Woof!";
            }
            else
            {
                return "";
            }

        }
        /// <summary>
        /// Sets IsSleeping to true;
        /// </summary>
        public void Sleep()
        {
            this.IsSleeping = true;
        }

        /// <summary>
        /// Sets IsSleeping to false;
        /// </summary>
        public void WakeUp()
        {
            this.IsSleeping = false;

        }

    }
}
