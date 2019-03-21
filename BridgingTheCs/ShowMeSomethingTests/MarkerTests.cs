using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShowMeSomething;

namespace ShowMeSomethingTests
{
    [TestClass]
    public class MarkerTests
    {
        [TestMethod]
        public void MarkerMoves()
        {
            var marker = new Marker(4, 6);

            Assert.AreEqual(4, marker.X);
            Assert.AreEqual(6, marker.Y);

            marker.Move(1, 0);
            Assert.AreEqual(5, marker.X);
            Assert.AreEqual(6, marker.Y);

            marker.Move(-1, 0);
            Assert.AreEqual(4, marker.X);
            Assert.AreEqual(6, marker.Y);

            marker.Move(0, 1);
            Assert.AreEqual(4, marker.X);
            Assert.AreEqual(7, marker.Y);

            marker.Move(0, -1);
            Assert.AreEqual(4, marker.X);
            Assert.AreEqual(6, marker.Y);
        }
    }
}
