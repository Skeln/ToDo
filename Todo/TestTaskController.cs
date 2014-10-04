/// <summary>
/// This class is only here for creating Test Data 
/// </summary>
/// <author>
/// Markus Waitl
/// </author>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
  class TestTaskController
  {
      private List<MainTask> _Tasks = null;

      public List<MainTask> Tasks
      {
          get
          {

              if (_Tasks == null)
              {
                  this._Tasks = new List<MainTask>();
                  createTasks();
              }

              return this._Tasks;

          }
      }

      public void createMainTask(string subject)
      {

      }

      public void createMainTask(string subject, string description)
      {

      }

      /// <summary>
      /// creates 5 test tasks and adds them to the tasks list
      /// </summary>
      public void createTasks()
      {

          for (int i = 0; i < 10; i++)
          {
              _Tasks.Add(new MainTask("Task " + (i + 1).ToString(), "This a task description"));
          }

      }

  }

}
