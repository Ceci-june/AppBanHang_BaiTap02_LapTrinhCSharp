using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            ShowItem();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ShowItem()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < Form1.cart.Rows.Count; i++)
            {
                string id = Form1.cart.Rows[i]["id"].ToString();
                id = id.Replace(" ", "");

                string name = Form1.cart.Rows[i]["name"].ToString();
                int price = Convert.ToInt32(Form1.cart.Rows[i]["price"]);

                Custom.UserControl1 it = new Custom.UserControl1(id, name, price.ToString());

                flowLayoutPanel1.Controls.Add(it);
            }
        }
    }
}
