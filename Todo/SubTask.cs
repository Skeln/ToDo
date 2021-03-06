﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    class SubTask : Task
    {
        public int MainTaskID { get; set; }

        // Constructors
        public SubTask(string subject, int mainTaskID)
        {
            this.Subject = subject;
            this.MainTaskID = mainTaskID;
            this.Done = false;
        }
        // Constructor for database parsing
        public SubTask(int id, int mainTaskID, string subject, bool done)
        {
            this.ID = id;
            this.MainTaskID = mainTaskID;
            this.Subject = subject;
            this.Done = done;
        }

        public bool validate()
        {
            if (this.Subject.Length == 0) { return false; }

            return true;
        }

    }
}
