using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    interface ITodoController
    {

        int saveMainTask(string subject, string description);
        int saveMainTask(int id, string subject, string description);
        int saveSubTask(string subject);
        int saveSubTask(int id, string subject);

        List<MainTask> getAllMainTasks();

        void checkMainTask(int id);
        void checkSubTask(int id);

        void deleteSubTask(int subTaskID);
        void deleteMainTask(int mainTaskID);
        void deleteAllTasks();

    }
}
