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
    partial class TaskGUI : Form
    {

        // TODO: This needs to be replaced with the actual TaskController
        private TestTaskController testTasksController;

        public TaskGUI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gui constructor for the TestTaskController
        /// </summary>
        /// <param name="t">instance of an task controller</param>
        public TaskGUI(TestTaskController t)
        {

            InitializeComponent();
            testTasksController = t;
            InitializeControls();

        }

        /// <summary>
        /// Adds a main task control for each task to the main task panel
        /// </summary>
        public void InitializeControls()
        {

            Console.WriteLine(testTasksController.Tasks.Count);

            testTasksController.Tasks.ForEach(delegate(MainTask m)
            {
                addMainTaskComponent(m);
            });

            mainTaskPanel.Focus();

        }

        /// <summary>
        /// Gets called by Initilize Controls to create the main task control 
        /// for given main task object
        /// </summary>
        /// <param name="m">main task object to display</param>
        void addMainTaskComponent(MainTask m)
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

    }
}