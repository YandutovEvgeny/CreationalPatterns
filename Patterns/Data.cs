using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    [Serializable]
    class Data
    {
        public int Year { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }

        public Data Clone()
        {
            return new Data() { Year = Year, Day = Day, Month = Month };
        }
    }
}
