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
    public partial class UserControl1 : UserControl
    {
        public static string s;
        public UserControl1(string id, string name,string price)
        {
            InitializeComponent();
            pictureBox1.Image = (Image)Bai02.Properties.Resources.ResourceManager.GetObject(id);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            labelName.Text = name;
            labelPrice.Text = price + "VNĐ";
            pictureBox1.Name = id;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            s = pictureBox1.Name;
            PictureBox p = (PictureBox)sender;
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
