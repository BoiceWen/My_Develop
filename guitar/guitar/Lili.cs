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
    public partial class Lili : Form
    {
        public Lili()
        {
            InitializeComponent();
        }

        int l1, l2, l3;
        String lt1, lt2, lt3;
        private void Lili_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("l1.jpg");
            if (checkBox1.Checked)
            {
               l1 = 2390;
                lt1 = "CMT-S1嚴選桃花心木21吋烏克麗麗(附Comet原廠烏克麗麗袋)" + '\n';
            }
            else
            {
                l1 = 0;
                lt1 = "";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("l2.jpg");
            if (checkBox2.Checked)
            {
                Global.l2 = 2990;
                lt2 = "CMT-C1嚴選桃花心木23吋烏克麗麗(附Comet原廠烏克麗麗袋)" + '\n';
            }
            else
            {
                l2 = 0;
               lt2 = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("l3.jpg");
            if (checkBox3.Checked)
            {
                l3 = 5800;
                lt3 = "GP100 26吋雲杉木吉他麗麗 附琴袋，調音器，彈片"+'\n'+"教材GP-100/小吉他/古典吉他】" + '\n';
            }
            else
            {
                l3 = 0;
                lt3 = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.l1 = l1;
            Global.l2 = l2;
            Global.l3 = l3;
            Global.lt1 = lt1;
            Global.lt2 = lt2;
            Global.lt3 = lt3;
            Global.total3 = Global.l1 + Global.l2 + Global.l3;
            DialogResult MsgBoxResult;//設置對話框的返回值
            MsgBoxResult = MessageBox.Show("您購買的物品為:" + '\n' + Global.lt1 + Global.lt2 + Global.lt3 + "你的總訂購金額為:  NT  " + Global.total3 + "$" + '\n' + "請確認您的商品，送出後無法更改",//對話框的顯示內容 
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
