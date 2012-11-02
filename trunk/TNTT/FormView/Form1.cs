using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace TNTT.FormView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axFramerControl1.CreateNew("Word.Document");
            axFramerControl1.Menubar = false;
            axFramerControl1.Titlebar = false;
            axFramerControl1.Toolbars = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //axFramerControl1.Menubar = !axFramerControl1.Menubar;
            axFramerControl1.Toolbars = !axFramerControl1.Toolbars;
        }
    }
}
