using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;




namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTests
    {
        [TestMethod]

        public void RhinoShouldReturnCrash()
        {
            //arrange
        
            AnimalGroupName groupName = new AnimalGroupName();
            string result = groupName.GetHerd("Rhino");
            //act
            groupName.GetHerd("Rhino");
            
            //assert
            Assert.AreEqual("Crash", result);
        }

        [TestMethod]
        public void RHINOShouldReturnCrash()
        {
            //arrange

            AnimalGroupName groupName = new AnimalGroupName();
            string result = groupName.GetHerd("RHINO");
            //act
            groupName.GetHerd("RHINO");

            //assert
            Assert.AreEqual("Crash", result);
        }
        [TestMethod]
        public void EmptyStringShouldReturnUnknown()
        {
            //arrange

            AnimalGroupName groupName = new AnimalGroupName();
            string result = groupName.GetHerd("Rooster");
            //act
            groupName.GetHerd("Rooster");

            //assert
            Assert.AreEqual("unknown", result);
        }

    }
}
