using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Event : Task
    {
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public String Teacher { get; set; }

        public Event(string description, string subject, DateTime timeStart, DateTime timeEnd, string teacher)
        {
            Description = description;
            Subject = subject;
            TimeStart = timeStart;
            TimeEnd = timeEnd;
            Teacher = teacher;
        }
    }
}
