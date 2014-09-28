using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
  class MainTask : Task
  {
    private List<SubTask> subTasks;
    public String Description { get; set; }

    public override bool Done
    {
      set
      {
        if (value == true)
        {
          foreach (SubTask subTask in this.subTasks)
          {
            subTask.Done = value;
          }
        }
      }
    }


    public MainTask(int taskID, String subject) : base(taskID, subject) { }
    public MainTask(int taskID, String subject, String description)
      : base(taskID, subject)
    {
      this.Description = description;
    }
    public MainTask(int taskID, String subject, String description, bool done)
      : base(taskID, subject, done)
    {
      this.Description = description;
    }
    
    public List<SubTask> getSubTasks()
    {
      return this.subTasks;
    }

    public void addSubtask(SubTask subTask)
    {
      this.subTasks.Add(subTask);
    }

    public void removeSubTask(SubTask subTask)
    {
      this.subTasks.Remove(subTask);
    }
  }
}
