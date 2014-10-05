﻿using System;
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

        private MainTask _mainTask;
        
        public MainTask CtrlMainTask 
        {
            get
            {
                return _mainTask;
            }
        }

        public MainTaskControl()
        {
            InitializeComponent();
        }

        public MainTaskControl(MainTask m)
        {
            InitializeComponent();
            _mainTask = m;
            CheckBoxChange();
            SetValues();
        }

        /// <summary>
        /// Updates the main task
        /// </summary>
        /// <param name="m"></param>
        public void Update() 
        {
            SetValues();
        }

        /// <summary>
        /// Fills all GUI field with the Main Tasks Values
        /// and sets up the visible fields of the form
        /// </summary>
        private void SetValues() 
        {

            if (CtrlMainTask.SubTasks.Count == 0)
            {
                SubTaskPanel.Hide();
                this.Height = 80;
            }
            else 
            {
                SubTaskPanel.Show();
                this.Height = 145;
            }

            if (CtrlMainTask.Description == "")
            {
                descriptionTextBox.Hide();
            }
            else 
            { 
                descriptionTextBox.Show();
            }

            if (CtrlMainTask.SubTasks.Count == 0 && CtrlMainTask.Description == "") 
            {
                this.Height = 45;
            }

            if (CtrlMainTask.Done)
            {
                CheckBoxChange();
                checkDoneCkBx.Checked = true;
            }
            
            taskName.Text           = CtrlMainTask.Subject;
            descriptionTextBox.Text = CtrlMainTask.Description; 
        }

        private void CheckBoxChange() 
        { 

            if (CtrlMainTask.Done)
            {
                this.BackColor = Color.LightGreen;
            }
            else
            { 
                this.BackColor = Color.LightGray;
            }
        
        }

        private void editMainTask_click(object sender, EventArgs e)
        {
            (new MainTaskForm(this)).ShowDialog();
        }

        private void checkDoneCkBx_CheckedChanged(object sender, EventArgs e)
        {

            if (((CheckBox)sender).Checked)
            {
                this.CtrlMainTask.Done = true;
                this.Parent.Controls.SetChildIndex(this, this.Parent.Controls.Count - 1);
            }
            else
            { 
                this.CtrlMainTask.Done = false;
            }

            CheckBoxChange();
        }

        private void removeTaskBtn_Click(object sender, EventArgs e)
        {

            // TODO: call remove Controller Task
            this.Dispose();

        }

    }
}