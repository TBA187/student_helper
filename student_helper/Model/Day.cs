using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Day
    {
        public int DayID { get; set; }
        public string DayName { get; set; }
        public List<Event> Events;
        public List<Homework> Homework;

        public Day(int dayID, string dayName)
        {
            dayID = DayID;
            dayName = DayName;
            Events = new List<Event>();
            Homework = new List<Homework>();
        }
    }
}
