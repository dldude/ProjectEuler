using System;
using System.Linq;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Problem2Tests
    {
        private Problem2 _class;

        [SetUp]
        public void Setup()
        {
            _class = new Problem2();
        }

        [Test]
        public void GenerateFibonacciSequence_ForTermsFalseAndInputTen_Zero()
        {
            var result = _class.GenerateFibonacciSequence(10);
            Assert.AreEqual(0, result.Sum());
        }

        [Test]
        public void GenerateFibonacciSequence_ForTermsTrueAndInputZero_Zero()
        {
            _class.ForTerms = true;
            var result = _class.GenerateFibonacciSequence(0);
            Assert.AreEqual(0, result.Sum());
        }

        [Test]
        public void GenerateFibonacciSequence_ForTermsTrueAndInput10_ListContains10Elements()
        {
            _class.ForTerms = true;
            var result = _class.GenerateFibonacciSequence(10);
            Assert.AreEqual(10, result.Count);
        }
    }
}