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
  class SQLiteDatabaseConnector : IDataStorage
  //class SQLiteDatabaseConnector
  {

    private SQLiteConnection dbConnection;

    // Constructor
    public SQLiteDatabaseConnector()
    {
      //string dbFilename = "ToDo.db";
      string dbFilename = @"d:\programme\sqlite\test.db";

      if (!File.Exists(dbFilename)) { this.setupSQLiteDatabase(dbFilename); }

      this.dbConnection = new SQLiteConnection("Data Source=" + dbFilename + ";foreign keys=true;Version=3;");
      this.dbConnection.Open();
    }


    // PUBLIC Methods
    public MainTask getMainTask(int mainTaskID) 
    {
      SQLiteCommand query = new SQLiteCommand("select * from MainTasks where mainTask_id = @mainTaskID");
      query.Parameters.AddWithValue("@mainTaskID", mainTaskID);

      SQLiteDataReader sqlData =  this.doQuery(query);
      sqlData.Read();
      if (!sqlData.HasRows) { throw new Exception(String.Format("keine MainTask mit der ID {0} gefunden!", mainTaskID)); }

      List<SubTask> subTasks = this.getAllSubTasksForMainTask(mainTaskID);
      return new MainTask(
        Convert.ToInt32( sqlData["mainTask_id"] ),
        Convert.ToString( sqlData["subject"] ), 
        Convert.ToString( sqlData["description"] ), 
        subTasks,
        Convert.ToBoolean( sqlData["done"] )
      );
    }
    public List<MainTask> getAllMainTasks()
    {
      List<MainTask> mainTasks = new List<MainTask>();

      SQLiteCommand query = new SQLiteCommand("select mainTask_id from MainTasks");
      SQLiteDataReader sqlData = this.doQuery(query);

      while (sqlData.Read())
      {
        int mainTaskID = Convert.ToInt32(sqlData["mainTask_id"]);
        mainTasks.Add( this.getMainTask(mainTaskID) );
      }

      return mainTasks;
    }
    public void deleteMainTask(int mainTaskID)
    {
      SQLiteCommand query = new SQLiteCommand("delete from MainTasks where mainTask_id = @mainTaskID");
      query.Parameters.AddWithValue("@mainTaskID", mainTaskID);

      this.doQuery(query);
    }
    public void deleteSubTask(int subTaskID)
    {
      SQLiteCommand query = new SQLiteCommand("delete from SubTasks where subTask_id = @subTaskID");
      query.Parameters.AddWithValue("@subTaskID", subTaskID);

      this.doQuery(query);
    }
    public void saveMainTask(MainTask mainTask)
    {
      if (mainTask.ID > 0)
      {
        this.updateMainTask(mainTask);
      }
      else
      {
        this.insertMainTask(mainTask);
      }
    }
    public void saveSubTask(SubTask subTask)
    {
      if (subTask.ID > 0)
      {
        this.updateSubTask(subTask);
      }
      else
      {
        this.insertSubTask(subTask);
      }
    }


    // PRIVATE Methods
    private void updateMainTask(MainTask mainTask)
    {
      SQLiteCommand query = new SQLiteCommand(
        "update MainTasks set " +
        "subject = @subject," +
        "description =  @description," +
        "done = @done "+
        "where mainTask_id = @mainTaskID"
      );
      query.Parameters.AddWithValue("@subject", mainTask.Subject);
      query.Parameters.AddWithValue("@description", mainTask.Description);
      query.Parameters.AddWithValue("@done", Convert.ToInt32(mainTask.Done));
      query.Parameters.AddWithValue("@mainTaskID", mainTask.ID);

      //delete subTasks!
      //foreach (SubTask subTask in mainTask.SubTasks)
      //{
      //  this.updateSubTask(subTask);
      //}

      this.doQuery(query);        
    }
    private void insertMainTask(MainTask mainTask)
    {
      SQLiteCommand query = new SQLiteCommand(
        "insert into MainTasks " +
        "(subject, description) " +
        "values " +
        "(@subject, @description)"
      );
      query.Parameters.AddWithValue("@subject", mainTask.Subject);
      query.Parameters.AddWithValue("@description", mainTask.Description);

      this.doQuery(query);
    }
    private void updateSubTask(SubTask subTask)
    {
      if (subTask.MainTaskID <= 0) { throw new Exception("MainTask nicht vorhanden!"); }

      SQLiteCommand query = new SQLiteCommand(
        "update SubTasks set " +
        "subject = @subject," +
        "done = @done " +
        "where subTask_id = @subTaskID"
      );
      query.Parameters.AddWithValue("@subject", subTask.Subject);
      query.Parameters.AddWithValue("@done", subTask.Done);
      query.Parameters.AddWithValue("@subTaskID", subTask.ID);

      this.doQuery(query);
    }
    private void insertSubTask(SubTask subTask)
    {
      if (subTask.MainTaskID <= 0) { throw new Exception("MainTask nicht vorhanden!"); }

      SQLiteCommand query = new SQLiteCommand(
        "insert into SubTasks " +
        "(subject, mainTask_id) " +
        "values " +
        "(@subject, @mainTaskID)"
      );
      query.Parameters.AddWithValue("@subject", subTask.Subject);
      query.Parameters.AddWithValue("@mainTaskID", subTask.MainTaskID);

      this.doQuery(query);
    }
    
    private List<SubTask> getAllSubTasksForMainTask(int mainTaskID)
    {
      List<SubTask> subTasks = new List<SubTask>();

      SQLiteCommand query = new SQLiteCommand("select * from SubTasks where mainTask_id = @mainTaskID");
      query.Parameters.AddWithValue("@mainTaskID", mainTaskID);
      SQLiteDataReader sqlData = this.doQuery(query);

      while (sqlData.Read())
      {
        subTasks.Add(new SubTask(
          Convert.ToInt32( sqlData["subTask_id"] ),
          Convert.ToInt32( sqlData["mainTask_id"] ),
          Convert.ToString( sqlData["subject"] ),
          Convert.ToBoolean( sqlData["done"] )
        ));
      }

      return subTasks;
    }

    private SQLiteDataReader doQuery(SQLiteCommand query)
    {
      query.Connection = this.dbConnection;
      SQLiteDataReader reader = query.ExecuteReader();

      return reader;
    }
    private void setupSQLiteDatabase(string dbFilename)
    {
      SQLiteConnection.CreateFile(dbFilename);
      SQLiteConnection dbConnection = new SQLiteConnection("Data Source=" + dbFilename + ";foreign keys=true;Version=3;");
      SQLiteCommand command = new SQLiteCommand(dbConnection);
      
      // string activateForeignKeyConstraints = "PRAGMA foreign_keys = ON;";
      // command.CommandText = activateForeignKeyConstraints;
      
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
