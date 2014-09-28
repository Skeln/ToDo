using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
  class Program
  {
    static void Main(string[] args)
    {

      SQLiteDatabaseConnector dataStorage = new SQLiteDatabaseConnector();
      MainTask task1 = dataStorage.getMainTask(1);
      Console.WriteLine(task1.ID);
      Console.WriteLine(task1.Subject);
      Console.WriteLine(task1.Description);
      Console.WriteLine(task1.Done);
      Console.WriteLine("SubTasks:");

      foreach (SubTask subTask in task1.SubTasks)
      {
        Console.WriteLine(subTask.ID);
        Console.WriteLine(subTask.MainTaskID);
        Console.WriteLine(subTask.Subject);
        Console.WriteLine(subTask.Done);
      }

    }
  }
}
