using Bai02.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
//using static System.Net.Mime.MediaTypeNames;

namespace Bai02
{
    public partial class Form2 : Form
    {
        private static DataRow dr;
        private static string size="";
        private static DataTable dt = Form1.cart;
        public Form2()
        {
            InitializeComponent();
            string itemID = Bai02.Custom.UserControl1.s;
            dr = Form1.product.AsEnumerable().SingleOrDefault(r => r.Field<string>("id") == itemID);
            label1.Text = dr["name"].ToString();
            label2.Text = dr["price"].ToString() + "đ";
            pictureBox1.Image = (Bitmap)Resources.ResourceManager.GetObject(itemID);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            button_00.BackgroundImage = (Bitmap)Resources.ResourceManager.GetObject(itemID);
            button_01.BackgroundImage = (Bitmap)Resources.ResourceManager.GetObject(itemID + "_01");
            button_02.BackgroundImage = (Bitmap)Resources.ResourceManager.GetObject(itemID + "_02");
            button_00.BackgroundImageLayout = ImageLayout.Stretch;
            button_01.BackgroundImageLayout = ImageLayout.Stretch;
            button_02.BackgroundImageLayout = ImageLayout.Stretch;
            label5.Text = dr["describe"].ToString();
            if(dr["gender"].ToString()=="men")
            {
                button6.Text = "40";
                button5.Text = "41";
                button4.Text = "42";
                button3.Text = "43";
                button2.Text = "44";
            }    
            foreach (Control ctrl in tableLayoutPanel2.Controls)
            {
                ctrl.Click += new EventHandler(pictureBoxSmall_Click);
            }
            foreach (Control ctrl in tableLayoutPanel1.Controls)
            {
                ctrl.Click += new EventHandler(pictureBoxSize_Click);
            }

            //this.pictureBox1.Focus();
            //pictureBox1.BackColor = Color.Blue;
        }
        private void pictureBoxSize_Click(object sender, EventArgs e)
        {
            Button chosen = (Button)sender;
            foreach (Control ctrl in tableLayoutPanel1.Controls)
            {
                ctrl.BackColor = Color.White;
            }
            chosen.BackColor = Color.Blue;
            size = chosen.Text;

        }
        private void pictureBoxSmall_Click(object sender, EventArgs e)
        {
            Button chosen = (Button)sender;
            pictureBox1.Image = chosen.BackgroundImage;
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (size!="")
            {
                
                DataRow find = Form1.cart.AsEnumerable().SingleOrDefault(r => r.Field<string>("id") == dr["id"].ToString() && r.Field<string>("size") == size);
               
                if (find == null)
                {
                    Form1.cart.Rows.Add(dr["id"].ToString(), dr["name"].ToString(), size, 1, Convert.ToInt32(dr["price"]));
                }    
                else
                {
                    int index = Form1.cart.Rows.IndexOf(find);
                    Form1.cart.Rows[index]["number"] = Convert.ToInt32(Form1.cart.Rows[index]["number"]) + 1;
                }    
                MessageBox.Show("Đã thêm sản phẩm vào giỏ hàng.");
            }    
            else
            {
                MessageBox.Show("Xin hãy chọn size.");
            }    
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataRow find = Form1.cart.AsEnumerable().SingleOrDefault(r => r.Field<string>("id") == dr["id"].ToString());
            if (find == null)
            {
                Form1.love.Rows.Add(dr["id"].ToString(), dr["name"].ToString(), dr["describe"].ToString(), dr["gender"].ToString(), dr["type"].ToString(), Convert.ToInt32(dr["price"])); 
            }
            MessageBox.Show("Đã thêm sản phẩm vào yêu thích.");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (size != "")
            {
                DataRow find = Form1.cart.AsEnumerable().SingleOrDefault(r => r.Field<string>("id") == dr["id"].ToString() && r.Field<string>("size") == size);
                if (find == null)
                {
                    Form1.cart.Rows.Add(dr["id"].ToString(), dr["name"].ToString(), size, 1, Convert.ToInt32(dr["price"]));
                }
                else
                {
                    int index = Form1.cart.Rows.IndexOf(find);
                    Form1.cart.Rows[index]["number"] = Convert.ToInt32(Form1.cart.Rows[index]["number"]) + 1;
                }
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Xin hãy chọn size.");
            }
            
        }
    }
}
