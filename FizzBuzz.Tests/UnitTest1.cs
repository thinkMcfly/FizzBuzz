using FizzBuzzLib;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace FizzBuzz.Tests
{
    public class Tests
    {
        Solution _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new Solution();
        }

        [Test]
        public void IfTheWordMappingIsEmptyShouldReturnAnErrorMessage()
        {
            _solution = new Solution(null);
            var test = _solution.PrintFizzBuzz(It.IsAny<int>());

            Assert.IsTrue(test.GetEnumerator().Current == null);
        }

        [Test]
        [TestCase(0)]
        [TestCase(-123)]
        public void UpperBoundMustBePositiveNumber(int upperBound)
        {
            var test = _solution.PrintFizzBuzz(upperBound);
            Assert.IsTrue(test.GetEnumerator().Current == null);
        }


        [Test]
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        public void IfInputIsDivisbleBy3ShouldReturnFizz(int number)
        {
            Assert.IsTrue(_solution.FizzBuzz(number) == "Fizz");
        }


        [Test]
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        [TestCase(500)]
        public void IfInputIsDivisbleBy5ShouldReturnBuzz(int number)
        {
            Assert.IsTrue(_solution.FizzBuzz(number) == "Buzz");
        }


        [Test]
        [TestCase(15)]
        [TestCase(150)]
        public void IfInputIsDivisbleBy15ShouldReturnFizzBuzz(int number)
        {
            Assert.IsTrue(_solution.FizzBuzz(number) == "FizzBuzz");
        }



        // The tests below refer to an alternative word mapping that might be provided by the user.

        [Test]
        [TestCase(4)]
        [TestCase(8)]
        [TestCase(12)]
        [TestCase(16)]
        public void IfInputIsDivisbleBy4ShouldReturnClap(int number)
        {
            var mappings = new Dictionary<int, string>()
            {
                {4, "Clap" },
                {7, "Bloop" }
            };

            _solution = new Solution(mappings);

            Assert.IsTrue(_solution.FizzBuzz(number) == "Clap");
        }

        [Test]
        [TestCase(7)]
        [TestCase(14)]
        [TestCase(21)]
        public void IfInputIsDivisbleBy7ShouldReturnBloop(int number)
        {
            var mappings = new Dictionary<int, string>()
            {
                {4, "Clap" },
                {7, "Bloop" }
            };

            _solution = new Solution(mappings);

            Assert.IsTrue(_solution.FizzBuzz(number) == "Bloop");
        }

        [Test]
        [TestCase(28)]
        [TestCase(56)]
        public void IfInputIsDivisbleBy28ShouldReturnClapBloop(int number)
        {
            var mappings = new Dictionary<int, string>()
            {
                {4, "Clap" },
                {7, "Bloop" }
            };

            _solution = new Solution(mappings);
            Assert.IsTrue(_solution.FizzBuzz(number) == "ClapBloop");
        }


        [Test]
        [TestCase(420)]
        [TestCase(840)]
        public void IfInputIsDivisbleBy420ShouldReturnFizzBuzzClapBloop(int number)
        {
            var mappings = new Dictionary<int, string>()
            {
                {3, "Fizz" },
                {5, "Buzz" },
                {4, "Clap" },
                {7, "Bloop" }
            };

            _solution = new Solution(mappings);
            Assert.IsTrue(_solution.FizzBuzz(number) == "FizzBuzzClapBloop");
        }
    }
}