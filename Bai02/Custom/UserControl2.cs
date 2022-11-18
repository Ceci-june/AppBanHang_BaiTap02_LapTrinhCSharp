using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bai02.Custom
{
    public partial class UserControl2 : UserControl
    {
        public static DataRow data;
        private static int tien;
        public UserControl2(DataRow dr)
        {
            InitializeComponent();
            
            data = dr;
            string id = dr["id"].ToString();
           // id = id.Replace(" ", "");

            string name = dr["name"].ToString();
            int price = Convert.ToInt32(dr["price"]);
            string size = dr["size"].ToString();
            int number = Convert.ToInt32(dr["number"]);
            pictureBox1.Image = (Image)Bai02.Properties.Resources.ResourceManager.GetObject(id);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            labelName.Text = name;
            labelPrice.Text = price + "đ";
            //pictureBox1.Name = id;
            //labelDelete.Parent = this;
            //comboBox1.Name = id;
            tien = price * number;
            label_tong.Text = tien.ToString() + "đ";
            label1.Text = size;
            numericUpDown1.Value= number;
            Form3.sum += tien;
            //Form3.label.Text = Form3.sum.ToString();
            //UserControl3.label.Text = Form3.sum.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Form3.sum -= tien;
            tien = Convert.ToInt32(data["price"]) * Convert.ToInt32(numericUpDown1.Value);
            label_tong.Text = tien.ToString() + "đ";
            Form3.sum +=tien;
            Form3.label.Text = Form3.sum.ToString();
            DataRow dr = Form1.cart.AsEnumerable().SingleOrDefault(r => r.Field<string>("id") == data["id"].ToString() && r.Field<string>("size") == data["size"].ToString());
            for (int i = 0; i < Form1.cart.Rows.Count; i++)
            {
                string id = Form1.cart.Rows[i]["id"].ToString();
                if (id == pictureBox1.Name)
                {
                    Form1.cart.Rows[i]["number"] = Convert.ToInt32(numericUpDown1.Value);
                    break;
                }
            }
        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    DataRow dr = Form1.cart.AsEnumerable().SingleOrDefault(r => r.Field<string>("id") == data["id"].ToString() && r.Field<string>("size") == data["size"].ToString());
        //    DataRow find = Form1.cart.AsEnumerable().SingleOrDefault(r => r.Field<string>("id") == data["id"].ToString() && r.Field<string>("size") == comboBox1.SelectedItem.ToString());
        //    if ( find != null)
        //    {
        //        int index = Form1.cart.Rows.IndexOf(find);
                
        //    }    
        //    for (int i = 0; i < Form1.cart.Rows.Count; i++)
        //    {
        //        //DataRow find = Form1.cart.AsEnumerable().SingleOrDefault(r => r.Field<string>("id") == data["id"].ToString() && r.Field<string>("size") == data["size"].ToString());
        //        string id = Form1.cart.Rows[i]["id"].ToString();
        //        string si = Form1.cart.Rows[i]["size"].ToString();
        //        if (id == data["id"].ToString() && si == data["size"].ToString())
        //        {
        //            data["size"]= comboBox1.SelectedItem;
        //            Form1.cart.Rows[i]["size"] = comboBox1.SelectedItem;
        //            break;

        //        }

        //    }
        //}

        private void labelDelete_Click(object sender, EventArgs e)
        {
            //Label temp = (Label)sender;
            Delete();
        }
        private void Delete()
        {
            Bai02.Form3.flowLayoutPanel.Controls.Remove(this);
            DataRow dr = Form1.cart.AsEnumerable().SingleOrDefault(r => r.Field<string>("id") == data["id"].ToString() && r.Field<string>("size") == data["size"].ToString());
            Form3.sum -= Convert.ToInt32(dr["price"]) * Convert.ToInt32(numericUpDown1.Value);
            Form3.label.Text = Form3.sum.ToString();
            Bai02.Form1.cart.Rows.Remove(dr);

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }
    }
}
