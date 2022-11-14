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
        public UserControl2(string id, string name, string price, string size)
        {
            InitializeComponent();
            pictureBox1.Image = (Image)Bai02.Properties.Resources.ResourceManager.GetObject(id);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            labelName.Text = name;
            labelPrice.Text = price + "đ";
            pictureBox1.Name = id;
            label_tong.Text = (Convert.ToInt32(price) * numericUpDown1.Value).ToString() + "đ";
            if (id[0] == 'F')
            {
                string[] installs = new string[] { "35","36", "37", "38" , "39" };
                comboBox1.Items.AddRange(installs);
            }
            else if (id[0]=='M')
            {
                string[] installs = new string[] { "40", "41", "42", "43", "44" };
                comboBox1.Items.AddRange(installs);
            }  
            else
            {
                string[] installs = new string[] { "40", "41", "42", "43", "44" };
                comboBox1.Items.AddRange(installs);
            }
            comboBox1.SelectedItem = size;
        }

    }
}
