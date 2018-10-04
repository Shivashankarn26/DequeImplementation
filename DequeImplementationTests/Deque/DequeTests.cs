using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DequeImplementation.Tests
{
    [TestClass()]
    public class DequeTests
    {
        [TestMethod()]
        public void AddToFrontTestException()
        {
            IDeque deque = new Deque();
            try
            {
                deque.AddToFront("9999999999999");
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Input OutofRange");
                return;
            }
            Assert.Fail("No exception");
        }

        [TestMethod()]
        public void AddToBackTestException()
        {
            IDeque deque = new Deque();
            try
            {
                deque.AddToBack("9999999999999");
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Input OutofRange");
                return;
            }
            Assert.Fail("No exception");
        }

        [TestMethod()]
        public void RemoveFromBackTest()
        {
            IDeque deque = new Deque();
            try
            {
                deque.RemoveFromBack();
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Empty Deque");
                return;
            }
            Assert.Fail("No exception");
        }

        [TestMethod()]
        public void RemoveFromFrontTest()
        {
            IDeque deque = new Deque();
            try
            {
                deque.RemoveFromFront();
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Empty Deque");
                return;
            }
            Assert.Fail("No exception");
        }
    }
}