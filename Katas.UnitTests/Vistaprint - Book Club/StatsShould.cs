using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Vistaprint.BookClub
{
    public class StatsShould
    {
        private Stats stats;

        [OneTimeSetUp]
        public void Setup()
        {
            stats = new Stats();
        }

        [Test]
        public void ThrowNullReferenceException_WhenTheReceivedListIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => stats.GetStats((List<int>)null));
        }
    }
}