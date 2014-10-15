using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo.Views
{
    partial class SubTaskForm : Form
    {

        private MainTaskControl _mainTaskControl;

        public SubTaskForm(MainTaskControl mc)
        {
            _mainTaskControl = mc;
            InitializeComponent();
        }

        private void saveSubTaskBtn_Click(object sender, EventArgs e)
        {
                //TODO: this should go into the controller 
            SubTask st = new SubTask(this.subjectTextBox.Text, _mainTaskControl.CtrlMainTask.ID);
            _mainTaskControl.AddSubTaskComponent(st);

            this.Dispose();

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
