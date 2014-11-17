using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo
{
    partial class TodoGUI : Form
    {

        // TODO: This needs to be replaced with the actual TaskController
        private ITodoController todoController;

        private Form taskForm;
        private static TodoGUI _instance = null;

        public static TodoGUI Instance 
        {
            get 
            {
                return _instance;
            }
        }

        public ITodoController GetTodoController
        {
            get 
            {
                return todoController;
            }
        }

        /// <summary>
        /// Gui constructor for the TestTaskController
        /// </summary>
        /// <param name="t">instance of an task controller</param>
        public TodoGUI(ITodoController t)
        {

            InitializeComponent();

            _instance      = this;
            todoController = t;

            AddControls();

        }

        /// <summary>
        /// Adds a main task control for each task to the main task panel
        /// </summary>
        public void AddControls()
        {

            todoController.GetAllMainTasks().ForEach(delegate(MainTask m)
            {
                AddMainTaskControls(m);
            });

            mainTaskPanel.Focus();

        }

        public void RemoveControls() 
        {
            mainTaskPanel.Controls.Clear();
        }

        /// <summary>
        /// Gets called by Initilize Controls to create the main task control 
        /// for given main task object
        /// </summary>
        /// <param name="m">main task object to display</param>
        public void AddMainTaskControls(MainTask m)
        {

            MainTaskControl mtc = new MainTaskControl(m);
            mtc.Dock            = DockStyle.Top;
            
            mainTaskPanel.Controls.Add(mtc);
            mainTaskPanel.Controls.SetChildIndex(mtc, 0);

        }

        private void FocusPanel(object sender, EventArgs e)
        {
            mainTaskPanel.Focus();
        }

        private void FocusPanel(object sender, MouseEventArgs e)
        {
            mainTaskPanel.Focus();
        }

        /// <summary>
        /// Opens a dialog to create a new Form
        /// </summary>
        private void addTaskButton_Click(object sender, EventArgs e)
        {

            if (taskForm == null || taskForm.IsDisposed )
            {
                taskForm = new MainTaskForm();
            }

            taskForm.ShowDialog();

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete all Tasks?", "Delete all",MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                todoController.DeleteAllTasks();
                RemoveControls();
            }
        }

    }
}