using NUnit.Framework;
using OccurencesOfArray;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateIndex_InputNull_ReturnNull()
        {

            Assert.AreEqual(new int[] { 2, 4 }, Kata.FindAll(new int[] { 6, 9, 3, 4, 3, 82, 11 }, 3));
            Assert.AreEqual(new int[] { 1, 9 }, Kata.FindAll(new int[] { 10, 16, 20, 6, 14, 11, 20, 2, 17, 16, 14 }, 16));
            Assert.AreEqual(new int[] { 0, 1, 8 }, Kata.FindAll(new int[] { 20, 20, 10, 13, 15, 2, 7, 2, 20, 3, 18, 2, 3, 2, 16, 10, 9, 9, 7, 5, 15, 5 }, 20));
        }
    }
}