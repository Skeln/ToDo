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
            //Application.Run(new TaskGUI());
            Application.Run(new TodoGUI(new TestTaskController()));

            dataStorage.deleteMainTask(2);
            MainTask mt = new MainTask("Subject", "Description");
            //mt = dataStorage.getMainTask(dataStorage.saveMainTask(mt));
            mt.addSubTask("SubTaskSubject");
            mt = dataStorage.getMainTask(dataStorage.saveMainTask(mt));
            mt.removeSubTask(2);
            mt = dataStorage.getMainTask(dataStorage.saveMainTask(mt));
            //printMainTask(mt);
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
            Console.WriteLine("ID: \t" + mainTask.ID);
            Console.WriteLine("Subj: \t" + mainTask.Subject);
            Console.WriteLine("Desc: \t" + mainTask.Description);
            Console.WriteLine("Done: \t" + mainTask.Done);
            Console.WriteLine("SubTasks:");

            foreach (SubTask subTask in mainTask.SubTasks)
            {
                Console.WriteLine("\tID: \t" + subTask.ID);
                Console.WriteLine("\tMTID: \t" + subTask.MainTaskID);
                Console.WriteLine("\tSubj: \t" + subTask.Subject);
                Console.WriteLine("\tDone: \t" + subTask.Done);
            }

            Console.WriteLine("\n\n");
        }

    }
}
