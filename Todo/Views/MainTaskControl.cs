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
        public MainTaskControl()
        {
            InitializeComponent();
        }

        public MainTaskControl(MainTask m)
        {
            InitializeComponent();
            taskName.Text = m.Subject;
        }
    }
}