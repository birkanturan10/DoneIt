using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoneIt.EntityLayer
{
    public class TaskItem
    {
        public int TaskID { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public DateTime Date { get; set; }

        public bool IsCompleted { get; set; }

        public string? Category { get; set; }

        public DateTime Deadline { get; set; }
    }
}
