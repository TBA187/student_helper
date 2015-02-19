using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Week
    {
        public int WeekNumber { get; set; }
        public List<Day> Days;

        public Week(int weekNumber)
        {
            WeekNumber = weekNumber;
            Days = new List<Day>();
        }
    }
}
