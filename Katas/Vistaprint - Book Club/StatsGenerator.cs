using System;
using System.Collections.Generic;

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

            return Stats.Empty;
        }
    }
}