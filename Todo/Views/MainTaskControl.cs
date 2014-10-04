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

        private MainTask _mainTask;
        
        public MainTask ControlMainTask 
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
            SetValues();
        }

        /// <summary>
        /// Fills all GUI field with the Main Tasks Values
        /// </summary>
        private void SetValues() 
        { 
            taskName.Text = ControlMainTask.Subject;
        }

    }
}