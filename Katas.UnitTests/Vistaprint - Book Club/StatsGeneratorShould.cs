using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Vistaprint.BookClub
{
    public class StatsGeneratorShould
    {
        private StatsGenerator statsGenerator;

        [OneTimeSetUp]
        public void Setup()
        {
            statsGenerator = new StatsGenerator();
        }

        [Test]
        public void ThrowArgumentNullException_WhenTheReceivedListIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => statsGenerator.GetStats((List<int>)null));
        }

        [Test]
        public void ReturnEmptyStats_WhenTheReceivedListIsEmpty()
        {
            var stats = statsGenerator.GetStats(new List<int>());

            Assert.AreEqual(Stats.Empty, stats);
            Assert.AreEqual(0, stats.count);
        }

        [Test]
        public void ReturnCountOfOne_WhenTheReceivedListHasOnlyOneElement()
        {
            var stats = statsGenerator.GetStats(new List<int>() { 1 });

            Assert.AreEqual(1, stats.count);
        }


        [TestCase("1,2", 2)]
        [TestCase("1,2,3", 3)]
        [TestCase("-1,-3", 2)]
        public void ReturnCountOfElements_WhenTheReceivedListHasMultipleElements(string values, int expectedCount)
        {
            var stats = statsGenerator.GetStats(Parse(values));

            Assert.AreEqual(expectedCount, stats.count);
        }

        [Test]
        public void ReturnElementAsMaximumValue_WhenTheReceivedListHasOnlyOneElement()
        {
            var stats = statsGenerator.GetStats(new List<int>() { 1 });

            Assert.AreEqual(1, stats.maximumValue);
        }

        [TestCase("1,2",2)]
        [TestCase("1,3", 3)]
        [TestCase("-1,-3", -1)]
        [TestCase("1,-3", 1)]
        public void ReturnMaximumValueOfElements_WhenTheReceivedListHasMultipleElements(string values, int expectedMaximumValue)
        {
            var stats = statsGenerator.GetStats(Parse(values));

            Assert.AreEqual(expectedMaximumValue, stats.maximumValue);
        }

        [Test]
        public void ReturnElementAsMinimumValue_WhenTheReceivedListHasOnlyOneElement()
        {
            var stats = statsGenerator.GetStats(new List<int>() { 1 });

            Assert.AreEqual(1, stats.minimumValue);
        }

        [TestCase("1,2", 1)]
        [TestCase("1,3", 1)]
        [TestCase("-1,-3", -3)]
        [TestCase("1,-3", -3)]
        public void ReturnMinimumValueOfElements_WhenTheReceivedListHasMultipleElements(string values, int expectedMinimumValue)
        {
            var stats = statsGenerator.GetStats(Parse(values));

            Assert.AreEqual(expectedMinimumValue, stats.minimumValue);
        }

        [Test]
        public void ReturnElementAsAverageValue_WhenTheReceivedListHasOnlyOneElement()
        {
            var stats = statsGenerator.GetStats(new List<int>() { 1 });

            Assert.AreEqual(1M, stats.averageValue);
        }

        private List<int> Parse(string values)
        {
            return values.Split(",").Select(value => int.Parse(value)).ToList();
        }
    }
}