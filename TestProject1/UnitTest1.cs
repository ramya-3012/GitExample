using NUnit.Framework;
using GitExample;
using System;

namespace TestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        Emp obj=new Emp();
        [Test]
        public void TestAdd()
        {
            int actual = obj.add(4, 5);
            Assert.AreEqual(9, actual);
        }
        [Test]
        public void TestMessage()
        {
            string actual = obj.Message("Ramya");
            string expected = "Hello Ramya";
            Assert.AreEqual(expected, actual);
        }
        


    }
}
