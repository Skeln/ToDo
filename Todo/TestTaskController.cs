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
    class TestTaskController : ITodoController
    {

        #region old
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

            for (int i = 0; i < 50; i++)
            {
                tasks.Add(new MainTask("Task " + (i + 1).ToString(), "This a task description"));
            }

        }
        #endregion

        private List<MainTask> tasks;
        private IDataStorage dataStorage;

        public TestTaskController() 
        {
            tasks = new List<MainTask>();
            createTasks(); 
        }

        public int SaveMainTask(string subject, string description)
        {
            tasks.Add(new MainTask(tasks.Count, subject, description, new List<SubTask>(), false));
            return tasks.Count;
        }

        public int SaveMainTask(int id, string subject, string description)
        {
            MainTask mt = tasks.Find(delegate(MainTask m)
            {
                return m.ID == id;
            });

            mt.Subject = subject;
            mt.Description = description;

            return 0;
        }


        public int SaveSubTask(string subject, int mainTaskID)
        {
            return 0;
        }

        public int SaveSubTask(int id, string subject)
        {
            return 0;
        }

        public List<MainTask> GetAllMainTasks()
        {
            return tasks;
        }

        public void CheckMainTask(int id) { }
        public void CheckSubTask(int id) { }

        public void DeleteSubTask(int subTaskID) { }
        public void DeleteMainTask(int mainTaskID) { }
        public void DeleteAllTasks() { }

    }

}
