using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTests
    {
        [TestMethod]
        public void ReturnTrueOnWeekend()
        {
            CigarParty weekendParty = new CigarParty();
            bool result = weekendParty.HaveParty(45, true);

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void ReturnFalseOnWeekend()
        {
            CigarParty weekendParty = new CigarParty();
            bool result = weekendParty.HaveParty(35, true);

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ReturnFalseForWeekday()
        {
            CigarParty weekendParty = new CigarParty();
            bool result = weekendParty.HaveParty(35, false);

            Assert.AreEqual(false, result);
        }

    }
}
