using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    interface IDataStorage
    {
        int saveMainTask(MainTask mainTask);
        int saveSubTask(SubTask subTask);


        MainTask getMainTask(int mainTaskID);
        List<MainTask> getAllMainTasks();

        void deleteSubTask(int subTaskID);
        void deleteMainTask(int mainTaskID);
    }
}
