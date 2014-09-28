using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
  class Program
  {
    static void Main(string[] args)
    {

      MainTask bla = new MainTask(1, "Test123");

      Console.WriteLine(bla.Subject);


      SQLiteDatabase dataStorage = new SQLiteDatabase();

      MainTask blubb = dataStorage.getMainTask(1);

      Console.WriteLine(blubb.Subject);

    }
  }
}
