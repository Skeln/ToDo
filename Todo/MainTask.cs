using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    class MainTask
    {
        public int ID { get; private set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public List<SubTask> SubTasks { get; private set; }
        private bool _done;
        public bool Done
        {
            get { return _done; }
            set
            {
                _done = value;
                if (value == true)
                {
                    foreach (SubTask subTask in this.SubTasks)
                    {
                        subTask.Done = true;
                    }
                }
            }
        }


        // Constructors
        public MainTask(string subject)
        {
            this.Subject = subject;
            this.SubTasks = new List<SubTask>();
            this.Done = false;
        }
        public MainTask(string subject, string description)
        {
            this.Subject = subject;
            this.Description = description;
            this.SubTasks = new List<SubTask>();
            this.Done = false;
        }
        // Constructor for database parsing
        public MainTask(int id, string subject, string description, List<SubTask> subTasks, bool done)
        {
            this.ID = id;
            this.Subject = subject;
            this.Description = description;
            this.SubTasks = subTasks;
            this.Done = done;
        }

        // Methods
        public void addSubTask(string subject)
        {
            SubTask newSubTask = new SubTask(subject, this.ID);
            this.SubTasks.Add(newSubTask);
        }
        public void removeSubTask(int subTaskID)
        {
            SubTask foundSubTask = this.SubTasks.Find(
              delegate(SubTask subTask)
              {
                  return subTask.ID == subTaskID;
              }
            );

            if (foundSubTask != null)
            {
                this.SubTasks.Remove(foundSubTask);
            }
        }
    }
}