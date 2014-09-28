using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Threading.Tasks;

namespace Todo
{
  //class SQLiteDatabase : IDataStorage
  class SQLiteDatabase
  {

    private SQLiteConnection dbConnection;


    public SQLiteDatabase()
    {
      string dbFilename = @"d:\programme\sqlite\test.db";
      this.dbConnection = new SQLiteConnection("Data Source=" + dbFilename + ";Version=3;");
      this.dbConnection.Open();
    }



    public MainTask getMainTask(int mainTaskID) 
    {
      string query = string.Format("select * from MainTasks where mainTask_id = {0}", mainTaskID);

      SQLiteDataReader sqlData =  this.doQuery(query);
      sqlData.Read();
      if (!sqlData.HasRows) { throw new Exception(string.Format("keine MainTask mit der ID {0} gefunden!", mainTaskID)); }


      return new MainTask(
        Convert.ToInt32( sqlData["mainTask_id"] ),
        Convert.ToString( sqlData["subject"] ), 
        Convert.ToString( sqlData["description"] ), 
        Convert.ToBoolean( sqlData["done"] )
      );
    }

    



    private SQLiteDataReader doQuery(String query)
    {
      SQLiteCommand cmd = new SQLiteCommand(query, this.dbConnection);
      SQLiteDataReader reader = cmd.ExecuteReader();

      return reader;
    }
  }
}
