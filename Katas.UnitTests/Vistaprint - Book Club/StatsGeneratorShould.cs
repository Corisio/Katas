using NUnit.Framework;
using System;
using System.Collections.Generic;

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

        [Test]
        public void ReturnCountOfElements_WhenTheReceivedListHasMultipleElement()
        {
            var stats = statsGenerator.GetStats(new List<int>() { 1, 2 });


            Assert.AreEqual(2, stats.count);
        }
    }
}