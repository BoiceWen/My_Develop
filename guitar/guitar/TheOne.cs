using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace guitar
{
    public partial class TheOne : Form
    {
        public TheOne()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.panel1.Controls.Clear();
            welcome wel = new welcome();
            wel.FormBorderStyle = FormBorderStyle.None;
            wel.TopLevel = false;
            this.panel1.Controls.Add(wel);
            wel.Show();
        }
    }
}
