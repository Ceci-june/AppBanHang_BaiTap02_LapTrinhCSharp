using Bai02.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Net.Mime.MediaTypeNames;

namespace Bai02
{
    public partial class Form2 : Form
    {
        private static DataRow dr;
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
            foreach (Control ctrl in tableLayoutPanel2.Controls)
            {
                ctrl.Click += new EventHandler(pictureBoxSmall_Click);
            }    
            //pictureBox1.BackColor = Color.Blue;
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
            Form1.cart.Rows.Add(dr["id"].ToString(), dr["name"].ToString(), dr["describe"].ToString(), dr["gender"].ToString(), dr["type"].ToString(), Convert.ToInt32(dr["price"]));
            MessageBox.Show("Đã thêm sản phẩm vào giỏ hàng.");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1.love.Rows.Add(dr["id"].ToString(), dr["name"].ToString(), dr["describe"].ToString(), dr["gender"].ToString(), dr["type"].ToString(), Convert.ToInt32(dr["price"]));
            MessageBox.Show("Đã thêm sản phẩm vào yêu thích.");
        }
    }
}
