using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    interface IDataStorage
    {
        int SaveMainTask(MainTask mainTask);
        int SaveSubTask(SubTask subTask);

        MainTask GetMainTask(int mainTaskID);
        List<MainTask> GetAllMainTasks();
        SubTask GetSubTask(int subTaskID);

        void DeleteSubTask(int subTaskID);
        void DeleteMainTask(int mainTaskID);
    }
}
