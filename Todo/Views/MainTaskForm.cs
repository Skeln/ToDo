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
        private MainTask _mainTask = null;

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
        public MainTaskForm(MainTask mt)
        {

            InitializeComponent();
            this.Text = "Edit Task";
            _mainTask = mt;

        }
        }
    }
}
