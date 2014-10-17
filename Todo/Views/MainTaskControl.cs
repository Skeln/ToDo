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
    partial class MainTaskControl : UserControl
    {

        public MainTask CtrlMainTask { get; private set; }

        public MainTaskControl()
        {
            InitializeComponent();
        }

        public MainTaskControl(MainTask m)
        {
            InitializeComponent();
            CtrlMainTask = m;
            SetValues();
            foreach (SubTask s in m.SubTasks) 
            {
                AddSubTaskControls(s);
            }
        }

        /// <summary>
        /// Updates the main task
        /// </summary>
        /// <param name="m"></param>
        public void Update() 
        {

            CtrlMainTask = TodoGUI.Instance.GetTodoController.GetMainTask(CtrlMainTask.ID);
            foreach (SubTaskControl stc in this.SubTaskPanel.Controls)
            {
                stc.Update();
            }

            SetValues();

        }

        public void SetDimensions()
        {
            
            int subTasks = CtrlMainTask.SubTasks.Count;
            int subTaskPanelHeight = (subTasks * 25) < 75 ? (subTasks * 25) : 75;
            int mainPanelHeight = 85;

            if (subTasks== 0 && SubTaskPanel.Visible)
            {
                SubTaskPanel.Hide();
                mainPanelHeight = 80;
            }
            else if(CtrlMainTask.SubTasks.Count > 0 && !SubTaskPanel.Visible)
            {
                SubTaskPanel.Show();
            }

            if (CtrlMainTask.Description == "" && descriptionTextBox.Visible)
            {
                descriptionTextBox.Hide();
                SubTaskPanel.Location.Offset(new Point(0, -25));
            }
            else if(CtrlMainTask.Description.Length > 0 && !descriptionTextBox.Visible)
            {
                descriptionTextBox.Show();
                SubTaskPanel.Location.Offset(new Point(0, 25));
            }

            // apply dimensions
            this.Height = mainPanelHeight + subTaskPanelHeight;
            this.SubTaskPanel.Height = subTaskPanelHeight;
        }

        /// <summary>
        /// Fills all GUI field with the Main Tasks Values
        /// and sets up the visible fields of the form
        /// </summary>
        private void SetValues() 
        {

            SetDimensions();

            if (CtrlMainTask.Done)
            {
                this.BackColor = Color.LightGreen;
                this.SubTaskPanel.BackColor = Color.LightGreen;
                checkDoneCkBx.Checked = true;
            }
            else 
            { 
                this.SubTaskPanel.BackColor = Color.LightGray;
            }
            
            taskName.Text           = CtrlMainTask.Subject;
            descriptionTextBox.Text = CtrlMainTask.Description; 
        }

        /// <summary>
        /// Gets called by Initilize Controls to create the sub task controls 
        /// for given main tasks subtasks
        /// </summary>
        /// <param name="m">sub task object to display</param>
        public void AddSubTaskControls(SubTask subTask)
        {

            Update();

            SubTaskControl stc  = new SubTaskControl(subTask, this);
            stc.Dock            = DockStyle.Top;
            
            this.SubTaskPanel.Controls.Add(stc);
            this.SubTaskPanel.Controls.SetChildIndex(stc, 0);

        }

        private void editMainTask_click(object sender, EventArgs e)
        {
            (new MainTaskForm(this)).ShowDialog();
        }

        private void checkDoneCkBx_Click(object sender, EventArgs e)
        {

            if (((CheckBox)sender).Checked)
            {
                this.CtrlMainTask.Done = true;
                this.BackColor = Color.LightGreen;
            }
            else
            { 
                this.CtrlMainTask.Done = false;
                this.BackColor = Color.LightGray;
                this.SubTaskPanel.BackColor = Color.LightGray;
            }

            TodoGUI.Instance.GetTodoController.CheckMainTask(CtrlMainTask.ID);
            Update();

        }

        private void removeTaskBtn_Click(object sender, EventArgs e)
        {

            TodoGUI.Instance.GetTodoController.DeleteMainTask(CtrlMainTask.ID);
            this.Dispose();

        }

        private void addSubTaskBtn_Click(object sender, EventArgs e)
        {
            SubTaskForm stf = new SubTaskForm(this);
            stf.ShowDialog();
        }

    }
}