using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Todo
{
    class TodoTUI
    {
        private ITodoController todoController;

        private String appDescription = "ToDo was developed as a stundent project at OSZ IMT Berlin" + 
                                     "by Alexander Lipinski, Manuel Rutter and Markus Waitl";


        private Dictionary<string, string> commands = new Dictionary<string,string> { 
                                                   { "help", "show all commands" },
                                                   { "show {taskID}", "shows the selected task and its subTasks" },
                                                   { "delete [task/subtask/all] [taskID]", "deletes selected task(s) by option"},
                                                   { "add [task/subtask]", "lets you add a task or subtask"},
                                                   { "edit [task/subtask] [taskId]", "edits task or a subTask"},
                                                   { "toggleDone [task/subtask] [taskID]", "toggle task done"},
                                                   { "info", "shows some information about the app"}
                                               };

        public TodoTUI(ITodoController t,string[] args) 
        {
            todoController = t;

            if(args.Length < 1)
            {
                Console.WriteLine("Please enter a command.");
                Help();
                return;
            }

            ArgParser(args);

        }

        /// <summary>
        /// List all available commands
        /// </summary>
        public void Help()
        {
            Console.WriteLine("The available commands are:\n");
            Console.WriteLine("--------------------------------------------------------------------------");
            foreach (KeyValuePair<string, string> pair in commands)
            {
                Console.WriteLine(String.Format("{0, -35}:{1}", pair.Key, pair.Value));

            }
            Console.WriteLine("--------------------------------------------------------------------------");
        }

        /// <summary>
        /// Executes the action by given arguments
        /// </summary>
        /// <param name="args"></param>
        private void ArgParser(string[] args) 
        { 

            switch(args[0])
            {
                case "help":
                    Help();
                    break;
                case "show":
                    ListTask(args);
                    break;
                case "add":
                    AddTask(args);
                    break;
                case "delete":
                    DeleteTask(args);
                    break;
                case "edit":
                    EditTask(args);
                    break;
                case "toggleDone":
                    ToggleDone(args);
                    break;
                case "info":
                    Info();
                    break;
                default:
                    Console.WriteLine("Command not found");
                    Help();
                    return;
                    break;
            }
        }

        public void ListTask(string[] args) 
        { 

            int length = args.Length;
            if(length == 1) 
            {
                    Console.WriteLine(String.Format("{0, -5}{1,-20}{2,-40}{3, -10}{4, -5}", "ID", "Subject", "Description", "SubTasks", "Done"));
                    foreach(MainTask m in todoController.GetAllMainTasks())
                    {
                        Console.WriteLine(String.Format("{0, -5}{1, -20}{2,-40}{3, -10}{4, -5} ", m.ID, m.Subject, m.Description, m.SubTasks.Count, m.Done));
                    }
            } 
            else if( length > 1 )
            {     
                int id     = int.Parse(args[1]);
                if(length == 2) {
                    try
                    {
                        MainTask mt = todoController.GetMainTask(id);
                        Console.WriteLine(String.Format("{0, -5}{1,-20}{2,-40}{3, -10}{4, -5}", "ID", "Subject", "Description", "SubTasks", "Done"));
                        Console.WriteLine(String.Format("{0, -5}{1, -20}{2,-40}{3, -10}{4, -5} ", mt.ID, mt.Subject, mt.Description, mt.SubTasks.Count, mt.Done));
                        if (mt.SubTasks.Count > 0)
                        {
                            Console.WriteLine("---------------------------------------------------------------");
                            Console.WriteLine("SubTasks");
                            Console.WriteLine("---------------------------------------------------------------");
                            Console.WriteLine(String.Format("{0, -5}{1,-20}{2, -5}", "ID", "Subject", "Done"));
                            foreach (SubTask s in mt.SubTasks)
                            {
                                Console.WriteLine(String.Format("{0, -5}{1, -20}{2,-5} ", s.ID, s.Subject, s.Done));
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                } 
                else 
                {
                    int sid     = int.Parse(args[2]);
                    try
                    {
                        SubTask st = todoController.GetSubTask(sid);
                        Console.WriteLine(String.Format("{0, -5}{1,-20}{2, -5}", "ID", "Subject", "Done"));
                        Console.WriteLine(String.Format("{0, -5}{1, -20}{2,-5} ", st.ID, st.Subject, st.Done));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
               
                }
            }
        }

        public void AddTask(string[] args)
        {
            if (args.Length > 1 && (args[1] == "task" || args[1] == "subtask"))
            {
                int id = 0;
                string description = "";

                Console.Write("Enter a subject (can't be empty):");
                string subject = Console.ReadLine().ToString();

                if (args[1] == "task")
                {
                    Console.Write("Enter a description: ");
                    description = Console.ReadLine().ToString();
                    Console.WriteLine();
                    Console.Write("Add task " + subject + " - " + description + " ? (y/n) ");

                }
                else if (args[1] == "subtask")
                {
                    Console.Write("what is the mainTask Id: ");
                    id = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Add subtask " + subject + " to Task " + id + " ? (y/n) ");
                }

                string save = Console.ReadLine().ToString();
                if (save == "y")
                {
                    try
                    {
                        if (args[1] == "task")
                        {
                            todoController.SaveMainTask(subject, description.ToString());
                        }
                        else
                        {
                            todoController.SaveSubTask(subject, id);
                        }

                        Console.WriteLine("Task was saved.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
                else 
                { 
                    Console.WriteLine("Task was not saved.");
                }
            }
            else
            {
                Console.WriteLine("Please spezify what Task you want to add.");
                Console.WriteLine("example 'add task' or 'add subtask'");
                return;
            }
        }

        public void DeleteTask(string[] args)
        {
            if (args.Length > 1)
            {
                string confirm = "";

                switch (args[1])
                {
                    case "all":
                        Console.Write("Are you sure you want to delete all tasks ? (y/n) ");
                        confirm = Console.ReadLine().ToString();
                        if (confirm == "y")
                        {
                            try
                            {
                                todoController.DeleteAllTasks();
                                Console.WriteLine("All Tasks deleted");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        break;
                    case "task":
                        if (args.Length < 3)
                        {
                            Console.WriteLine("Please spezify a task");
                            return;
                        }
                        Console.Write("Are you sure you want to delete task " + args[2] + " ? (y/n) ");
                        confirm = Console.ReadLine().ToString();
                        if (confirm == "y")
                        {
                            try
                            {
                                todoController.DeleteMainTask(int.Parse(args[2]));
                                Console.WriteLine("Task deleted");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        break;
                    case "subtask":
                        if (args.Length < 3)
                        {
                            Console.WriteLine("Please spezify a task and a subtask");
                            return;
                        }
                        Console.Write("Are you sure you want to delete subtask " + args[3] + " ? (y/n) ");
                        confirm = Console.ReadLine().ToString();
                        if (confirm == "y")
                        {
                            try
                            {
                                todoController.DeleteSubTask(int.Parse(args[3]));
                                Console.WriteLine("Task deleted");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("No valid option");
                        Console.WriteLine("valid options: all, task, subtask");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Not enough arguments");
                Console.WriteLine("valid options: all, task, subtask");
                Console.WriteLine("examnple: delete task 1");           
            }
        }

        public void EditTask(string[] args)
        {
            if (args.Length > 2)
            {
                string confirm = "";
                switch (args[1]) 
                { 
                    case "task":
                        try
                        {
                            MainTask m = todoController.GetMainTask(int.Parse(args[2]));
                            Console.Write("Enter new subject (old subject:" + m.Subject + "): ");
                            string newSubject = Console.ReadLine();
                            Console.Write("Enter new description (old description:" + m.Description + "): ");
                            string newDescription = Console.ReadLine();
                            Console.Write("Save changes ? (y/n) ");
                            confirm = Console.ReadLine().ToString();
                            if (confirm == "y")
                            {
                                todoController.SaveMainTask(m.ID, newSubject, newDescription);
                                Console.WriteLine("Speichern erfolgreich");
                            }
                            else
                            { 
                                Console.WriteLine("Änderungen verworfen");
                            }
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "subtask":
                        try
                        {
                            SubTask s = todoController.GetSubTask(int.Parse(args[2]));
                            Console.Write("Enter new subject (old subject:" + s.Subject + "): ");
                            string newSubject = Console.ReadLine();
                            Console.Write("Save changes ? (y/n) ");
                            confirm = Console.ReadLine().ToString();
                            if (confirm == "y")
                            {
                                todoController.SaveSubTask(s.ID, newSubject);
                                Console.WriteLine("Speichern erfolgreich");
                            }
                            else
                            { 
                                Console.WriteLine("Änderungen verworfen");
                            }
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    default:
                        Console.WriteLine("Unknown argumet:" + args[1]);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Not enough arguments");
                Console.WriteLine("valid options: task, subtask");
                Console.WriteLine("examnple: edit task 1");               
            }

        }

        public void ToggleDone(string[] args) 
        {

            if (args.Length > 2)
            {
                string confirm = "";
                 switch (args[1]) 
                { 
                    case "task":
                        try
                        {
                            MainTask m = todoController.GetMainTask(int.Parse(args[2]));
                            Console.Write("Set done of task " + m.Subject+ " to " + !m.Done + " ? (y/n) ");
                            confirm = Console.ReadLine().ToString();
                            if (confirm == "y")
                            {
                                todoController.CheckMainTask(m.ID);
                                Console.WriteLine("Speichern erfolgreich");
                            }
                            else
                            { 
                                Console.WriteLine("Änderungen verworfen");
                            }
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "subtask":
                        try
                        {
                            SubTask s = todoController.GetSubTask(int.Parse(args[2]));
                            Console.Write("Set done of task " + s.Subject+ " to " + !s.Done + " ? (y/n) ");
                            confirm = Console.ReadLine().ToString();
                            if (confirm == "y")
                            {
                                todoController.CheckSubTask(s.ID);
                                Console.WriteLine("Speichern erfolgreich");
                            }
                            else
                            { 
                                Console.WriteLine("Änderungen verworfen");
                            }
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                     default:
                        Console.WriteLine("Unknown argumet:" + args[1]);
                        break;
                }               
            }
            else
            {
                Console.WriteLine("Not enough arguments");
                Console.WriteLine("valid options: task, subtask");
                Console.WriteLine("examnple: toggleDone task 1");               
            }

        }

        public void Info()
        {
            Console.WriteLine(appDescription);
        }

    }
}
