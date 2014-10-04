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
    public partial class TaskGUI : Form
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
    }
}