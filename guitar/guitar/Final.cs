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
    public partial class Final : Form
    {
        public Final()
        {
            InitializeComponent();
        }

        private void Final_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            label1.Text = (Global.gt1 + Global.gt2 + Global.gt3 + Global.et1 + Global.et2 + Global.et3 + Global.lt1 + Global.lt2 + Global.lt3 + Global.st1 + Global.st2 + Global.st3).ToString();
            label2.Text = (Global.total + Global.total2 + Global.total3 + Global.total4).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Thanks th = new Thanks();
            th.Show(this);
            
            this.Hide();
        }
    }
}
