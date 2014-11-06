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
    partial class SubTaskForm : Form
    {

        private MainTaskControl _mainTaskControl;
        private SubTaskControl _subTaskControl = null;

        public SubTaskForm(MainTaskControl mc)
        {

            InitializeComponent();
            _mainTaskControl = mc;
            this.Text = "New subtask";

        }

        public SubTaskForm(MainTaskControl mc, SubTaskControl stc)
        {

            InitializeComponent();
            _mainTaskControl = mc;
            _subTaskControl  = stc; 
            this.Text = "Edit subtask";

        }

        private void saveSubTaskBtn_Click(object sender, EventArgs e)
        {
            if (_subTaskControl == null)
            {
                try
                {
                    int subTaskId = TodoGUI.Instance.GetTodoController.SaveSubTask(this.subjectTextBox.Text, _mainTaskControl.CtrlMainTask.ID);
                    _mainTaskControl.AddSubTaskControls(TodoGUI.Instance.GetTodoController.GetSubTask(subTaskId));
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Task could not be saved. Did you fill out the title?");
                    return;
                }
            }
            else
            {

                try
                {
                    TodoGUI.Instance.GetTodoController.SaveSubTask(_subTaskControl.CtrlSubTask.ID, this.subjectTextBox.Text);
                    _mainTaskControl.Update();
                }
                catch (ArgumentException) {
                    MessageBox.Show("Task could not be saved. Did you fill out the title?");
                    return;
                }

            }
            this.Dispose();

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}