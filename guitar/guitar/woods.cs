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
    
 
    public partial class woods : Form
    {
        public woods()
        {
            InitializeComponent();
        }

       
       
       

        private void woods_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            
            
            
            
            
        }

        int g1, g2, g3, total;
        String gt1, gt2, gt3;
       private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("g1.jpg");
            if (checkBox1.Checked)
            {
                g1 = 3690;
                gt1 = "Comet C-210 【入門吉他首選/C210】" + '\n';
            }
            else
            {
                g1 = 0;
                gt1 = "";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("g2.jpg");
            if (checkBox2.Checked)
            {
                g2 = 2490;
                gt2 = "Comet C-190 切角民謠吉他" + '\n';
            }
            else
            {
                g2 = 0;
                gt2 = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("g3.jpg");
            if (checkBox3.Checked)
            {
                g3 = 5990;
                gt3 = "Comet C-357EQ黑色（可插電民謠吉他）五段EQ拾音器" + '\n';
            }
            else
            {
                g3 = 0;
                gt3 = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Global.g1 = g1;
            Global.g2 = g2;
            Global.g3 = g3;
            Global.gt1 = gt1;
            Global.gt2=  gt2;
            Global.gt3 = gt3;
            

            Global.total = Global.g1 + Global.g2 + Global.g3;
            DialogResult MsgBoxResult;//設置對話框的返回值
            MsgBoxResult = MessageBox.Show("您購買的物品為:" + '\n' + Global.gt1 + Global.gt2 + Global.gt3 + "你的總訂購金額為:  NT  " + Global.total + "$" + '\n' + "請確認您的商品，送出後無法更改",//對話框的顯示內容 
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
    public class Global
    {
        public static int g1, g2, g3, total;
        public static int e1, e2, e3, total2;
        public static int l1, l2, l3, total3;
        public static int s1, s2, s3 ,total4;
        public static String gt1, gt2, gt3;
        public static String et1, et2, et3;
        public static String lt1, lt2, lt3;
        public static String st1, st2, st3;

    }  
}
