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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            
        }
        private void 吉他ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            woods W = new woods();
            W.FormBorderStyle = FormBorderStyle.None;
            W.TopLevel = false;
            this.panel1.Controls.Add(W);
            W.Show();
        }

        private void 電吉他ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            eletric E = new eletric();
            E.FormBorderStyle = FormBorderStyle.None;
            E.TopLevel = false;
            this.panel1.Controls.Add(E);
            E.Show();                                   
        }

        private void 烏克麗麗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
           Lili L = new Lili();
            L.FormBorderStyle = FormBorderStyle.None;
            L.TopLevel = false;
            this.panel1.Controls.Add(L);
            L.Show();
        }

        private void 配件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Else S = new Else();
            S.FormBorderStyle = FormBorderStyle.None;
            S.TopLevel = false;
            this.panel1.Controls.Add(S);
            S.Show();
        }

        private void 最終結算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Final f = new Final();
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            this.panel1.Controls.Add(f);
            f.Show();
        }

        



        
    }
}
