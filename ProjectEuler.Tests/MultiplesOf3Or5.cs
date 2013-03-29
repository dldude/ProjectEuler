using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class MultiplesOf3Or5
    {

        private ProjectEuler.MultiplesOf3Or5 _class1;

        [SetUp]
        public void Setup()
        {
            _class1 = new ProjectEuler.MultiplesOf3Or5();
        }

        [Test]
        public void GetSumOfMultiplesBelow_Zero_Zero()
        {
            var results = _class1.GetSumOfMultiplesBelow(0);
            Assert.AreEqual(0, results);
            
        }

        [Test]
        public void GetSumOfMultiplesBelow_One_Zero()
        {
            var results = _class1.GetSumOfMultiplesBelow(1);
            Assert.AreEqual(0, results);
        }

        [Test]
        public void GetSumOfMultiplesBelow_Two_Zero()
        {
            var results = _class1.GetSumOfMultiplesBelow(2);
            Assert.AreEqual(0, results);
        }

        [Test]
        public void GetSumOfMultiplesBelow_Five_Three()
        {
            var results = _class1.GetSumOfMultiplesBelow(5);
            Assert.AreEqual(3, results);
        }

        [Test]
        public void GetSumOfMultiplesBelow_Six_Eight()
        {
            var results = _class1.GetSumOfMultiplesBelow(6);
            Assert.AreEqual(8, results);
        }
        
        [Test]
        public void GetSumOMultipleBelow_Ten_TwentyThree()
        {
            var results = _class1.GetSumOfMultiplesBelow(10);
            Assert.AreEqual(23, results);
        }

        [Test]
        public void GetSumOfMultiples_OneThousand_ExpectedResult()
        {
            var results = _class1.GetSumOfMultiplesBelow(1000);
            Assert.AreEqual(233168, results);
        }
    }
}
