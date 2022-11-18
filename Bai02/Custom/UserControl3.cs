using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02.Custom
{
    public partial class UserControl3 : UserControl
    {
        public static Label label;
        public static Label labeldis;
        public static Label labelfinal;
        public static string[] infor = new string[8];
        public UserControl3()
        {
            InitializeComponent();
            label = labelSum;
            labelSum.Text = Form3.sum.ToString()+"đ";
            labelDis.Text =  "0đ";
            labelFinal.Text = Form3.sum.ToString() + "đ";
            labeldis = labelDis;
            labelfinal = labelFinal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            infor[0] = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");//Thời gian mua hàng
            if (radioButtonMale.Checked)//Giới tính Khách hàng
                infor[1] = "Anh";
            else
                infor[1] = "Chị";
            infor[2]=textBox1.Text;//Tên khách hàng
            infor[3] = textBox2.Text;//Số điện thoại
            infor[4] = textBox3.Text;//Vị Trí
            infor[5] = labelSum.Text;
            infor[6] = labelDis.Text;
            infor[7] = labelFinal.Text;

            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox5.Text=="owlstore")
            {
                Form3.off = (float)0.2;
                labelDis.Text= (Convert.ToInt32(Form3.sum*0.20)).ToString()+"đ";
                labelFinal.Text = (Convert.ToInt32(Form3.sum * 0.80)).ToString()+"đ";
            }
            else
            {
                Form3.off = 0;
                MessageBox.Show("Mã giảm giá không đúng.");
            }    
            //textBox5.Text = "";
        }
    }
}
