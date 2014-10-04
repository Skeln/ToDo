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
        private TestTaskController testTasksController;
        private Form taskForm;
        private static TodoGUI _instance = null;

        public static TodoGUI Instance 
        {
            get 
            {
                return _instance;
            }
        }

        /// <summary>
        /// Gui constructor for the TestTaskController
        /// </summary>
        /// <param name="t">instance of an task controller</param>
        public TodoGUI(TestTaskController t)
        {

            InitializeComponent();
            _instance = this;
            testTasksController = t;
            InitializeControls();

        }

        /// <summary>
        /// Adds a main task control for each task to the main task panel
        /// </summary>
        public void InitializeControls()
        {

            testTasksController.Tasks.ForEach(delegate(MainTask m)
            {
                AddMainTaskComponent(m);
            });

            mainTaskPanel.Focus();

        }


        /// <summary>
        /// Gets called by Initilize Controls to create the main task control 
        /// for given main task object
        /// </summary>
        /// <param name="m">main task object to display</param>
        void AddMainTaskComponent(MainTask m)
        {

            MainTaskControl mtc = new MainTaskControl(m);
            mtc.Dock = DockStyle.Top;
            mainTaskPanel.Controls.Add(mtc);

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
                taskForm = new MainTaskForm("New Task");
            }
            else 
            { 
            
            }

            taskForm.ShowDialog();
        }

    }
}