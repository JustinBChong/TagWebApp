using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLibrary;

namespace TestTagLibrary
{
    [TestClass]
    public class TagLibraryTests
    {
        [TestMethod]
        public void ThingGetsObjectValFromNumber()
        {
            Assert.AreEqual(42, new Thing().Get(42));
        }
    }
}
