﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    class TaskController : ITodoController
    {

        #region fields
        private List<MainTask> tasks;
        private IDataStorage dataStorage;
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dataStorage"></param>
        public TaskController(IDataStorage dataStorage)
        {
            this.dataStorage = dataStorage;
        }

        #region save
        public int SaveMainTask(string subject, string description)
        {
            return dataStorage.SaveMainTask(new MainTask(subject, description));
        }

        public int SaveMainTask(int id, string subject, string description)
        {
            MainTask mainTask = dataStorage.GetMainTask(id);
            mainTask.Subject = subject;
            mainTask.Description = description;
            return dataStorage.SaveMainTask(mainTask);
        }

        public int SaveSubTask(string subject, int mainTaskID)
        {
            return dataStorage.SaveSubTask(new SubTask(subject, mainTaskID));
        }

        public int SaveSubTask(int id, string subject)
        {
            SubTask subTask = dataStorage.GetSubTask(id);
            subTask.Subject = subject;
            return dataStorage.SaveSubTask(subTask);
        }
        #endregion

        #region get
        public List<MainTask> GetAllMainTasks()
        {
            return dataStorage.GetAllMainTasks(); ;
        }

        public MainTask GetMainTask(int mainTaskID) 
        {
            return dataStorage.GetMainTask(mainTaskID);
        }

        public SubTask GetSubTask(int subTaskID) 
        { 
            return dataStorage.GetSubTask(subTaskID);
        }
        #endregion

        #region check
        public void CheckMainTask(int id)
        {
            MainTask mainTask = dataStorage.GetMainTask(id);
            if (mainTask.Done == true)
            {
                mainTask.Done = false;
            }
            else
            {
                mainTask.Done = true;
            }

            dataStorage.SaveMainTask(mainTask);
        }

        public void CheckSubTask(int id)
        {
            SubTask subTask = dataStorage.GetSubTask(id);
            if (subTask.Done == true)
            {
                subTask.Done = false;
            }
            else
            {
                subTask.Done = true;
            }
            dataStorage.SaveSubTask(subTask);
        }
        #endregion

        #region delete
        public void DeleteSubTask(int subTaskID)
        {
            dataStorage.DeleteSubTask(subTaskID);
        }

        public void DeleteMainTask(int mainTaskID)
        {
            dataStorage.DeleteMainTask(mainTaskID);
        }

        public void DeleteAllTasks()
        {
            List<MainTask> mainTasks = dataStorage.GetAllMainTasks();
            foreach (MainTask mainTask in mainTasks)
            {
                dataStorage.DeleteMainTask(mainTask.ID);
            }
        }
        #endregion
    }
}
