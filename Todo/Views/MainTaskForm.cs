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
    partial class MainTaskForm : Form
    {
        private MainTaskControl _mainTaskControl = null;

        /// <summary>
        /// This constructor is used for creating a new MainTask
        /// </summary>
        public MainTaskForm()
        {

            InitializeComponent();
            this.Text = "New Task";

        }

        /// <summary>
        /// This constructor is used for editing an existing MainTask
        /// </summary>
        /// <param name="mt">the MainTask object which should be edited</param>
        public MainTaskForm(MainTaskControl mtc)
        {

            InitializeComponent();
            _mainTaskControl             = mtc; 
            MainTask mt                  = mtc.CtrlMainTask;
            this.Text                    = "Edit Task";
            this.subjectTextBox.Text     = mt.Subject;
            this.descriptionTextBox.Text = mt.Description;

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void saveMainTaskBtn_Click(object sender, EventArgs e)
        {
            
            if (_mainTaskControl != null)
            {

                MainTask mt                  = _mainTaskControl.CtrlMainTask;
                mt.Subject     = this.subjectTextBox.Text ;
                mt.Description = this.descriptionTextBox.Text;
                _mainTaskControl.Update();

            }

            this.Dispose();

        }
    }
}