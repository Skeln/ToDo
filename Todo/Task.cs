using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
  abstract class Task
  {

    public virtual int TaskID { get; private set; }
    public virtual String Subject { get; set; }
    public virtual bool Done { get; set; }

    public Task(int taskID, String subject)
    {
      this.TaskID = taskID;
      this.Subject = subject;
      this.Done = false;
    }

    public Task(int taskID, String subject, bool done)
    {
      this.TaskID = taskID;
      this.Subject = subject;
      this.Done = done;
    }




  }
}
