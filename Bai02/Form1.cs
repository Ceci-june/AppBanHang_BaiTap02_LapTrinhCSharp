using Bai02.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Bai02
{

    public partial class Form1 : Form
    {
        public static DataTable product;
        public static DataTable cart;
        public static DataTable love;
        private static string gender = "all";
        public static string item;
        public Form1()
        {
            InitializeComponent();
            product = new DataTable();
            product.Columns.Add("id", typeof(string));
            product.Columns.Add("name", typeof(string));
            product.Columns.Add("describe", typeof(string));
            product.Columns.Add("gender", typeof(string));
            product.Columns.Add("type", typeof(string));
            product.Columns.Add("price", typeof(int));



            cart = new DataTable();
            cart.Columns.Add("id", typeof(string));
            cart.Columns.Add("name", typeof(string));
            cart.Columns.Add("describe", typeof(string));
            cart.Columns.Add("gender", typeof(string));
            cart.Columns.Add("type", typeof(string));
            cart.Columns.Add("price", typeof(int));

            love = new DataTable();
            love.Columns.Add("id", typeof(string));
            love.Columns.Add("name", typeof(string));
            love.Columns.Add("describe", typeof(string));
            love.Columns.Add("gender", typeof(string));
            love.Columns.Add("type", typeof(string));
            love.Columns.Add("price", typeof(int));

            product.Rows.Add("FAM02",
                "Nike Air Max 270 React ‘Aurora Green’ CJ0619-001",
                "Thân giày Nike Air Max 270 React ‘Aurora Green’ CJ0619-00 được làm " +
                "từ vải dệt có độ bền dẻo cao và khả năng chống nước tốt" +
                "\r\nGiày Nike sở hữu công nghệ Air max chứa miếng đệm không" +
                " khí giảm các chấn động khi luyện tập, Nike React được thiết kế" +
                " để làm giảm các chấn thương, tăng độ linh hoạt\r\nVới thiết kế kiểu" +
                " dáng giày cổ thấp dễ dàng hơn trong các bài tập cổ chân",
                "women","lifestyle", 450000);
            product.Rows.Add("FAM01",
                "Nike Wmns Air Max 97 ‘White Multicolor’ DH1592-100",
                "Giày Nike Wmns Air Max 97 ‘White Multicolor’ DH1592-100" +
                " được làm từ chất liệu 3% sợi dệt, " +
                "42% sợi tổng hợp và 55% da có bề mặt thông thoáng mang lại cảm giác thoải mái, " +
                "ít bám bẩn và độ bền cao.\r\nKiểu dáng giày cổ thấp trẻ trung, sang trọng và hợp" +
                " thời trang.", "women", "lifestyle", 5000000);



            ShowItem();

            

        }

        private void ShowItem()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < product.Rows.Count; i++)
            {
                string id = product.Rows[i]["id"].ToString();
                id = id.Replace(" ", "");

                string name = product.Rows[i]["name"].ToString();
                int price = Convert.ToInt32(product.Rows[i]["price"]);

                Custom.UserControl1 it = new Custom.UserControl1(id, name, price.ToString());
             
                flowLayoutPanel1.Controls.Add(it);
            }
        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            //ListViewItem firstSelectedItem = listView1.SelectedItems[0];
            //item = firstSelectedItem.Text;
            //Form2 form2 = new Form2();
            //form2.ShowDialog();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //cart
        }

        private void label2_Click(object sender, EventArgs e)
        {
            gender = "all";
            label_all.ForeColor = Color.Red;
            label_nam.ForeColor = Color.Black;
            label_nu.ForeColor = Color.Black;
            label_treem.ForeColor = Color.Black;
        }

        private void label_thinhhanh_Click(object sender, EventArgs e)
        {
            gender = "man";
            label_all.ForeColor = Color.Black;
            label_nam.ForeColor = Color.Red;
            label_nu.ForeColor = Color.Black;
            label_treem.ForeColor = Color.Black;
        }

        private void label_nu_Click(object sender, EventArgs e)
        {
            gender = "woman";
            label_all.ForeColor = Color.Black;
            label_nam.ForeColor = Color.Black;
            label_nu.ForeColor = Color.Red;
            label_treem.ForeColor = Color.Black;
        }

        private void label_treem_Click(object sender, EventArgs e)
        {
            gender = "kid";
            label_all.ForeColor = Color.Black;
            label_nam.ForeColor = Color.Black;
            label_nu.ForeColor = Color.Black;
            label_treem.ForeColor = Color.Red;
        }
    }
}
