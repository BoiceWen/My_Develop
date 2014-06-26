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
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

       

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Main m = new Main();
            m.FormBorderStyle = FormBorderStyle.None;
            m.TopLevel = false;
            this.panel1.Controls.Add(m);
            m.Show();
        }

        private void welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
