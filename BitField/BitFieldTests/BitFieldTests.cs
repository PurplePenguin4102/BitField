using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utility;

namespace BitFieldTests
{
    [TestClass]
    public class BitFieldTests
    {
        [TestMethod]
        public void Int_Constructor()
        {
            var bf = new BitField(1);
            Assert.IsTrue(bf[0]);
            Assert.IsFalse(bf[1]);
            Assert.AreEqual(bf.NumFlags, 32);
        }

        [TestMethod]
        public void Short_Constructor()
        {
            var bf = new BitField((short)1);
            Assert.IsTrue(bf[0]);
            Assert.IsFalse(bf[1]);
            Assert.AreEqual(bf.NumFlags, 16);
        }

        [TestMethod]
        public void Byte_Constructor()
        {
            var bf = new BitField((byte)1);
            Assert.IsTrue(bf[0]);
            Assert.IsFalse(bf[1]);
            Assert.AreEqual(bf.NumFlags, 8);
        }


    }
}
