using System;
using System.Collections.Generic;
using System.Linq;

namespace Vistaprint.BookClub
{
    public class StatsGenerator
    {
        public Stats GetStats(List<int> numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers));
            }

            if (numbers.Count == 0)
            {
                return Stats.Empty;
            }

            return new Stats()
            {
                count = numbers.Count,
                maximumValue = numbers.Max()
            };
        }
    }
}