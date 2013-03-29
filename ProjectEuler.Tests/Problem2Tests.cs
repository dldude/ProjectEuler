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

        [Test]
        public void GenerateFibonacciSequence_ForTermsTrueAndInput10_Sum231()
        {
            _class.ForTerms = true;
            var result = _class.GenerateFibonacciSequence(10);
            Assert.AreEqual(231, result.Sum());
        }

        [Test]
        public void GenerateFibonacciSequence_ForCeilingAndInput10_ListContains5Elements()
        {
            _class.ForCeiling = true;
            var result = _class.GenerateFibonacciSequence(10);
            Assert.AreEqual(5, result.Count());
        }

        [Test]
        public void GenerateFibonacciSequence_ForCeilingAndInput10_Sum19()
        {
            _class.ForCeiling = true;
            var result = _class.GenerateFibonacciSequence(10);
            Assert.AreEqual(19, result.Sum());
        }

        [Test]
        public void GenerateFibonacciSequence_ForCeilingAndInput4Million_ListContains32Elements()
        {
            _class.ForCeiling = true;
            var result = _class.GenerateFibonacciSequence(4000000);
            Assert.AreEqual(32, result.Count());
        }

        [Test]
        public void GenerateFibonacciSequence_ForCeilingAndInput4Million_Sum()
        {
            _class.ForCeiling = true;
            var result = _class.GenerateFibonacciSequence(4000000);
            Assert.AreEqual(9227463, result.Sum());
        }
        
    }
}