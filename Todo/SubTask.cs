using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
  class SubTask : Task
  {
    public SubTask(int taskID, String subject) : base(taskID, subject) { }
  }
}
