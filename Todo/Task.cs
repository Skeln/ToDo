using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Todo
{
    abstract class Task
    {
        public int ID { get; set; }
        public string Subject { get; set; }
        public virtual bool Done { get; set; }
    }
}
