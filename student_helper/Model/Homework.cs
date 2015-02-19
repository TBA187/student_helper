using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Homework : Task
    {
        public DateTime Deadline { get; set; }

        public Homework(string description, string subject, DateTime deadline)
        {
            Description = description;
            Subject = subject;
            Deadline = deadline;
        }
    }
}
