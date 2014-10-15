using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    interface ITodoController
    {

        int SaveMainTask(string subject, string description);
        int SaveMainTask(int id, string subject, string description);
        int SaveSubTask(string subject);
        int SaveSubTask(int id, string subject);

        List<MainTask> GetAllMainTasks();

        void CheckMainTask(int id);
        void CheckSubTask(int id);

        void DeleteSubTask(int subTaskID);
        void DeleteMainTask(int mainTaskID);
        void DeleteAllTasks();

    }
}
