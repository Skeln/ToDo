using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
  interface IDataStorage
  {
    void saveMainTask(MainTask mainTask);

    MainTask createMainTask(String subject);
    MainTask createMainTask(String subject, String description);

    MainTask getMainTask(int mainTaskID);

    List<MainTask> getAllMainTasks();

    void checkMainTask(int mainTaskID);

    void checkSubTask(int subTaskID);

    void addSubTaskToTask(int mainTaskID, String subTaskSubject);

    void removeSubTask(int subTaskID);
  }
}
