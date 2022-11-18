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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            foreach (DataRow row in Form1.love.Rows)
            {
                string id = row["id"].ToString();


                string name = row["name"].ToString();
                int price = Convert.ToInt32(row["price"]);

                Custom.UserControl1 it = new Custom.UserControl1(id, name, price.ToString());

                flowLayoutPanel1.Controls.Add(it);
            }
        }
    }
}
