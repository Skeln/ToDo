using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo
{
  class Program
  {
    static void Main(string[] args)
    {

      SQLiteDatabaseConnector dataStorage = new SQLiteDatabaseConnector();
      Application.Run(new TaskGUI());

      //MainTask mt = new MainTask("Subject", "Description");
      //Console.WriteLine(mt.ID);

      //MainTask task1 = dataStorage.getMainTask(1);
      //printMainTask(task1);
      //task1.Subject = "all new Subject!";
      //dataStorage.saveMainTask(task1);
      //task1 = dataStorage.getMainTask(1);
      //printMainTask(task1);


      //Console.WriteLine("\n\n\n\n\n\n\n");
      //printMainTaskList(dataStorage.getAllMainTasks());

    
    }

    static void printMainTaskList(List<MainTask> mainTasks)
    {
      foreach (MainTask mainTask in mainTasks)
      {
        printMainTask(mainTask);
      }
    }
    
    static void printMainTask(MainTask mainTask)
    {
      Console.WriteLine(mainTask.ID);
      Console.WriteLine(mainTask.Subject);
      Console.WriteLine(mainTask.Description);
      Console.WriteLine(mainTask.Done);
      Console.WriteLine("SubTasks:");

      foreach (SubTask subTask in mainTask.SubTasks)
      {
        Console.WriteLine("\t" + subTask.ID);
        Console.WriteLine("\t" + subTask.MainTaskID);
        Console.WriteLine("\t" + subTask.Subject);
        Console.WriteLine("\t" + subTask.Done);
      }

      Console.WriteLine("\n\n");
    }
    
  }
}
