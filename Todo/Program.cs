using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo
{
    class Program
    {
        static void Main(string[] args)
        {

            SQLiteDatabaseConnector dataStorage = new SQLiteDatabaseConnector();
            Application.Run(new TodoGUI(new TaskController(dataStorage)));
            //TodoTUI t = new TodoTUI(new TaskController(dataStorage), args);

        }

    }
}
