using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bai02
{
    public partial class Form3 : Form
    {
        public static FlowLayoutPanel flowLayoutPanel ;
        public static int sum = 0;
        public static Label label;
        public static float off = 0;
        public Form3()
        {
            InitializeComponent();
            ShowItem();
            flowLayoutPanel = flowLayoutPanel1;
            label = labelTemp;
        }
        private void ShowItem()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < Form1.cart.Rows.Count; i++)
            {
                //string id = Form1.cart.Rows[i]["id"].ToString();
                //id = id.Replace(" ", "");

                //string name = Form1.cart.Rows[i]["name"].ToString();
                //int price = Convert.ToInt32(Form1.cart.Rows[i]["price"]);
                //string size = Form1.cart.Rows[i]["size"].ToString();
                //int number = Convert.ToInt32(Form1.cart.Rows[i]["number"]);
                Custom.UserControl2 it = new Custom.UserControl2(Form1.cart.Rows[i]);
                flowLayoutPanel1.Controls.Add(it);
                
            }
            Custom.UserControl3 tt = new Custom.UserControl3();
            flowLayoutPanel1.Controls.Add(tt);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           // Custom.UserControl3.label.Text = labelTemp.Text;
        }

        private void labelTemp_TextChanged(object sender, EventArgs e)
        {
            Custom.UserControl3.label.Text = labelTemp.Text+"đ";
            Custom.UserControl3.labeldis.Text = (Convert.ToInt32(sum*off)).ToString() + "đ";
            Custom.UserControl3.labelfinal.Text = (Convert.ToInt32(sum * (1-off))).ToString() + "đ";
        }
    }
}
