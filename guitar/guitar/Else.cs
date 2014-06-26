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
    public partial class Else : Form
    {
        public Else()
        {
            InitializeComponent();
        }
        int s1, s2, s3;
        String st1, st2, st3;
        private void Else_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            pictureBox1.Image = Image.FromFile("s1.jpg");
            if (checkBox1.Checked)
            {


               
                s1 = 9;
                st1 = "Comet原廠進口珍珠Pick" + '\n';
            }
            else
            {
                s1 = 0;
                st1 = "";
                
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("s2.jpg");
            if (checkBox2.Checked)
            {
                s2 = 270;
                st2 = "Musedo MC-1 鋁製吉他移調夾（四種顏色可選）" + '\n';
            }
            else
            {
                s2 = 0;
                st2 = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("s3.jpg");
            if (checkBox3.Checked)
            {
                s3 = 399;
                st3 = "SWIFF B7 貓頭鷹夾式調音器" + '\n';
            }
            else
            {
                s3 = 0;
                st3 = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.s1 = s1;
            Global.s2 = s2;
            Global.s3 = s3;
            Global.st1 = st1;
            Global.st2 = st2;
            Global.st3 = st3;
            Global.total4 = Global.s1 + Global.s2 + Global.s3;
            DialogResult MsgBoxResult;//設置對話框的返回值
            MsgBoxResult = MessageBox.Show("您購買的物品為:" + '\n' + Global.st1 + Global.st2 + Global.st3 + "你的總訂購金額為:  NT  " + Global.total4 + "$" + '\n' + "請確認您的商品，送出後無法更改",//對話框的顯示內容 
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
