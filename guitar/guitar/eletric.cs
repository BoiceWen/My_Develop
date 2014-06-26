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
    public partial class eletric : Form
    {
        public eletric()
        {
            InitializeComponent();
        }
        int e1, e2, e3;
        String et1, et2, et3;

        private void eletric_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("e1.jpg");
            if (checkBox1.Checked)
            {
                e1 = 2990;
               et1 = "Comet-St1 電吉他" + '\n';
            }
            else
            {
                e1 = 0;
                et1 = "";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("e2.jpg");
            if (checkBox2.Checked)
            {
                e2 = 3990;
                et2 = "Comet St-3 珍珠護板（單單雙拾音）電吉他" + '\n';
            }
            else
            {
                e2= 0;
                et2 = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("e3.jpg");
            if (checkBox3.Checked)
            {
                e3 = 9200;
                et3 = "Comet Les Paul（Custom）頂級電吉他（雙雙）拾 音器"+'\n'+"（附Comet原廠吉他袋、導線、Pick、調琴工具）" + '\n';
            }
            else
            {
                e3 = 0;
                et3 = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.e1 = e1;
            Global.e2 = e2;
            Global.e3 = e3;
            Global.et1 = et1;
            Global.et2 = et2;
            Global.et3 = et3;
            Global.total2 = Global.e1 + Global.e2 + Global.e3;
            DialogResult MsgBoxResult;//設置對話框的返回值
            MsgBoxResult = MessageBox.Show("您購買的物品為:" + '\n' + Global.et1 + Global.et2 + Global.et3 + "你的總訂購金額為:  NT  " + Global.total2 + "$" + '\n' + "請確認您的商品，送出後無法更改",//對話框的顯示內容 
            "提示",//對話框的標題 
            MessageBoxButtons.OKCancel,//定義對話框的按鈕，這里定義了YSE和NO兩個按鈕 
            MessageBoxIcon.Exclamation,//定義對話框內的圖表式樣，這里是一個黃色三角型內加一個感嘆號 
            MessageBoxDefaultButton.Button2);//定義對話框的按鈕式樣
            if (MsgBoxResult == DialogResult.OK)//如果對話框的返回值是YES（按"Y"按鈕）
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;


            }
            if (MsgBoxResult == DialogResult.Cancel)//如果對話框的返回值是NO（按"N"按鈕）
            {

            }
        }

        
    }
}
