using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo
{
    partial class SubTaskControl : UserControl
    {

        public SubTask CtrlSubTask { get; private set; }
        private MainTaskControl _mainTaskControl;

        public SubTaskControl(SubTask s, MainTaskControl mtc)
        {
          
            CtrlSubTask = s;
            _mainTaskControl = mtc;
            InitializeComponent();
            this.subTaskLabel.Text = s.Subject;

            if (CtrlSubTask.Done)
            {
                this.BackColor = Color.DarkSeaGreen;
                this.doneCkBx.Checked = true;
            }

        }

        public void Update() 
        {
            CtrlSubTask = TodoGUI.Instance.GetTodoController.GetSubTask(CtrlSubTask.ID);
            this.subTaskLabel.Text = CtrlSubTask.Subject;

            if (CtrlSubTask.Done)
            {
                this.BackColor = Color.DarkSeaGreen;
                this.doneCkBx.Checked = true;
            }
            else
            {
                this.BackColor = Color.SandyBrown;
                this.doneCkBx.Checked = false;
            }
        }

        private void removeSubTaskBtn_Click(object sender, EventArgs e)
        {

            TodoGUI.Instance.GetTodoController.DeleteSubTask(CtrlSubTask.ID);
            this.Dispose();
            _mainTaskControl.Update();

        }

        private void subTaskCheck_Click(object sender, EventArgs e)
        {

            if (((CheckBox)sender).Checked)
            {
                CtrlSubTask.Done = true;
                this.BackColor = Color.DarkSeaGreen;
            }
            else
            { 
                CtrlSubTask.Done = false;
                this.BackColor = Color.SandyBrown;
            }

            TodoGUI.Instance.GetTodoController.CheckSubTask(CtrlSubTask.ID);
            _mainTaskControl.Update();

        }

        private void editSubTask_Click(object sender, EventArgs e)
        {
            SubTaskForm stf = new SubTaskForm(_mainTaskControl, this);
            stf.ShowDialog();
        }

    }
}