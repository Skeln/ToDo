using System;
using System.IO;
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

      //string dbFilename = @"d:\programme\sqlite\test.db";
      string dbFilename = "ToDo.db";


      if (!File.Exists(dbFilename)) { this.setupSQLiteDatabase(dbFilename); }

      this.dbConnection = new SQLiteConnection("Data Source=" + dbFilename + ";Version=3;");
      this.dbConnection.Open();
    }



    public MainTask getMainTask(int mainTaskID) 
    {
      string query = String.Format("select * from MainTasks where mainTask_id = {0}", mainTaskID);

      SQLiteDataReader sqlData =  this.doQuery(query);
      sqlData.Read();
      if (!sqlData.HasRows) { throw new Exception(String.Format("keine MainTask mit der ID {0} gefunden!", mainTaskID)); }


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

    private void setupSQLiteDatabase(string dbFilename)
    {
      SQLiteConnection.CreateFile(dbFilename);
      SQLiteConnection dbConnection = new SQLiteConnection("Data Source="+dbFilename+";Version=3;");
      SQLiteCommand command = new SQLiteCommand(dbConnection);
      
      string activateForeignKeyConstraints = "PRAGMA foreign_keys = ON;";
      command.CommandText = activateForeignKeyConstraints;
      
      string createMainTaksTable = 
        "CREATE TABLE MainTasks (" +
          "mainTask_id integer PRIMARY KEY," +
          "subject text NOT NULL," +
          "description text," +
          "done boolean CHECK(done <=1 AND done >=0) DEFAULT 0" +
        ");"
      ;
      command.CommandText += createMainTaksTable;

      string createSubTaksTable =
        "CREATE TABLE SubTasks (" +
          "subTask_id integer PRIMARY KEY," +
          "mainTask_id integer NOT NULL," +
          "subject text NOT NULL," +
          "done boolean CHECK(done <=1 AND done >=0) DEFAULT 0," +
          "FOREIGN KEY (mainTask_id) REFERENCES MainTasks(mainTask_id) ON DELETE CASCADE" +
        ");"
      ;
      command.CommandText += createSubTaksTable;

      string insertWelcomeTask =
        "INSERT INTO MainTasks (subject, description)"+
        " VALUES " +
        "('Welcome', 'This is a MainTask');"
      ;
      command.CommandText += insertWelcomeTask;


      dbConnection.Open();
      command.ExecuteNonQuery();
      dbConnection.Close();
    }
  }
}
