using Bai02.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Bai02
{

    public partial class Form1 : Form
    {
        public static DataTable product;
        public static DataTable cart;
        public static DataTable love;
        public static string gender = "";
        public static string item ="";
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
            cart.Columns.Add("size", typeof(string));
            cart.Columns.Add("number", typeof(int));
            cart.Columns.Add("price", typeof(int));

            love = new DataTable();
            love.Columns.Add("id", typeof(string));
            love.Columns.Add("name", typeof(string));
            love.Columns.Add("describe", typeof(string));
            love.Columns.Add("gender", typeof(string));
            love.Columns.Add("type", typeof(string));
            love.Columns.Add("price", typeof(int));
            //Nữ.lifestyle
            product.Rows.Add("FAM02",
                "Nike Air Max 270 React ‘Aurora Green’ CJ0619-001",
                "Thân giày Nike Air Max 270 React ‘Aurora Green’ CJ0619-00 được làm " +
                "từ vải dệt có độ bền dẻo cao và khả năng chống nước tốt" +
                "\r\nGiày Nike sở hữu công nghệ Air max chứa miếng đệm không" +
                " khí giảm các chấn động khi luyện tập, Nike React được thiết kế" +
                " để làm giảm các chấn thương, tăng độ linh hoạt\r\nVới thiết kế kiểu" +
                " dáng giày cổ thấp dễ dàng hơn trong các bài tập cổ chân",
                "woman","lifestyle", 450000);
            product.Rows.Add("FAM01",
                "Nike Wmns Air Max 97 ‘White Multicolor’ DH1592-100",
                "Giày Nike Wmns Air Max 97 ‘White Multicolor’ DH1592-100" +
                " được làm từ chất liệu 3% sợi dệt, " +
                "42% sợi tổng hợp và 55% da có bề mặt thông thoáng mang lại cảm giác thoải mái, " +
                "ít bám bẩn và độ bền cao.\r\nKiểu dáng giày cổ thấp trẻ trung, sang trọng và hợp" +
                " thời trang.", "woman", "lifestyle", 5000000);
            product.Rows.Add("FAM03",
                "Nike Wmns Air Max 270 React ‘Violet Dust’ CV8818-500",
                "NNike Wmns Air Max 270 React ‘Violet Dust’ CV8818-500" +
                " được làm từ 17% sợi dệt, 83% sợi tổng hợp giúp" +
                " thoáng khí tốt\r\nGiày Nike sở hữu công nghệ Air max có đệm chứa không khí nhằm giảm " +
                "các chấn động\r\nBộ đế cao su giúp bám đường tốt hơn và an toàn khi vận động\r\nKiểu dáng " +
                "giày cổ thấp linh hoạt, phù hợp để mang hằng ngày", "woman", "lifestyle", 5000000);
            //nữ.sandal
            product.Rows.Add("FSD01",
                "Nike Icon Classic Sandal DH0223-101",
                "Chất liệu đế bằng bọt khí trên giày" +
                " Nike được nâng lên mang lại sự thoải mái" +
                ", dễ dàng di chuyển\r\nQuai giày sandal được " +
                "thiết kế tinh xảo và chắc chắn, mang lại một cái" +
                " nhìn sáng tạo, mới mẻ và thú vị\r\n" +
                "Giày Nike Icon Classic Sandal DH0223-101 với kiểu dáng và mẫu mã lạ" +
                " mắt cho bạn tự tin hơn khi diện các style thời " +
                "trang khác nhau", "woman", "sandal", 5000000);
            product.Rows.Add("FSD02",
                "Nike Nike Oneonta Sandal DJ6601-003",
                "Giày Nike Oneonta Sandal DJ6601-003 được sản xuất " +
                "bằng Textile có độ bền đẹp, khả năng giữ form chất " +
                "lượng và chịu nhiệt tốt\r\nĐế giày Nike bằng cao su " +
                "tạo độ êm ái cho bàn chân và gia tăng độ bám dính chắc" +
                " chắn\r\nKiểu dáng giày bảng to mang đậm phong cách thời" +
                " trang thời thượng, trẻ trung cá tính ngày nay", 
                "woman", "sandal", 5000000);
            //Nữ.sport
            product.Rows.Add("FRN01",
                "Nike Waffle One DC2533-600",
                "Thân giày Nike Waffle One DC2533-600 làm từ 48% sợi dệt và 52% Leather chống thấm tốt, dễ vệ sinh, mềm mịn\r\nĐế giày Nike làm từ cao su bền bỉ, có độ đàn hồi cao, bề mặt êm ái, an toàn cho người sử dụng\r\nKiểu dáng giày cổ thấp truyền thống, mang lại cảm giác cổ điển, phù hợp với những bạn nữ năng động",
                "woman", "sport", 5000000);
            product.Rows.Add("FRN02",
                "Nike Metcon 7 DJ4312-074",
                "Phần thân giày Nike Metcon 7 DJ4312-074 được làm bằng 47% sợi tổng hợp và 53% sợi dệt cho độ bền chắc, bề mặt vải mềm mại, êm ái, dễ dàng lau chùi\r\nVới kiểu thiết kế giày cổ thấp tiện lợi, phù hợp với nhiều bạn nữ khi phối với các trang phục khác nhau, giúp bạn thoải mái tập luyện, training",
                "woman", "sport", 5000000);
            //Nữ.Dép
            product.Rows.Add("FDE01",
                "Dép Nữ Nike DC0496-100",
                "Kiểu dáng dép đơn giản, dễ dàng sử dụng\r\nDép Nike được làm từ chất liệu Synthetic mềm mại, êm ái và thoải mái dễ dàng sử dụng và vệ sinh khi có vết bẩn",
                "woman", "dep", 5000000);
            product.Rows.Add("FDE02",
               "Dép Nữ Nike CZ7836-600",
               "Đôi dép được làm từ Synthetic bền bỉ, êm ái và chống thấm nước khi mang\r\nPhần đế của dép Nike sử dụng chất liệu cao su giúp tăng độ ma sát, an toàn cho người dùng",
               "woman", "dep", 5000000);
            product.Rows.Add("FDE03",
               "Dép Nữ Nike CN9676-010",
               "Chiếc dép Nike được làm từ sợi tổng hợp bền bỉ, êm ái và chống thấm nước khi mang\r\nPhần đế của dép giúp tăng độ ma sát, an toàn cho người dùng khi di chuyển trên những bề mặt trơn trượt",
               "woman", "dep", 5000000);
            //Nam.dép
            product.Rows.Add("MDE01",
               "Dép Nam Nike CN9678-008",
               "Dép được hoàn thiện từ chất liệu Synthetic bền bỉ, mang đến vẻ ngoài thẩm mỹ cao và khả năng chống thấm nước tốt\r\nVới nhiều rãnh nhỏ ở đế dép Nike, sản phẩm giúp tăng độ bám đường tốt hơn khi bạn di chuyển\r\nThiết kế của Nike CN9678-008 có quai ngang tiện lợi khi sử dụng, cho phép các bạn nam tập luyện, vận động, training ở nhiều cường độ khác nhau",
               "men", "dep", 5000000);
            product.Rows.Add("MDE02",
            "Dép Nam Nike AO3621-001",
            "Thân dép Nike AO3621 được làm từ 8% sợi dệt và 92% sợi tổng hợp có độ bền cao, đàn hồi, mang đến cảm giác dễ chịu khi mang\r\nKiểu dáng dép đơn giản, dễ dàng sử dụng\r\nDép Nike đi kèm tiện ích khử mồ hôi và đế chống trơn trượt, giúp cho những buổi tập luyện thêm hoàn hảo",
            "men", "dep", 5000000);
            product.Rows.Add("MDE03",
           "Dép Nam Nike CZ5478-100",
           "Dép Nike với chất liệu từ Synthetic có khả năng chống thấm nước và dễ dàng lau chùi nó khi bị dính vết bẩn\r\nHọa tiết các hình tròn nổi trên đế của dép giúp chống trơn trượt và bảo vệ người dùng khi di chuyển, tập luyện",
           "men", "dep", 5000000);
            //Nam.sandal
            product.Rows.Add("MSD01",
          "Giày Sandal Nam Nike CT5545-001-10 Đen",
          "Giày được làm từ sợi tổng hợp có độ bền cao, hạn chế tình trạng nấm mốc, dễ dàng vệ sinh sau khi sử dụng nhờ khả năng chống bám bẩn tốt\r\nThiết kế giày sandal Puma thông thoáng cùng màu đen nổi bật, dễ dàng phối đồ với nhiều phong cách khác nhau",
          "men", "sandal", 5000000);
            //Nam.lifestyle
            product.Rows.Add("MAM01",
          "Giày Lifestyle Nam Nike Air Max 95 CV6899",
          "Nike Air Max 95 CV6899 được làm từ chất liệu 46% sợi tổng hợp và 54% sợi dệt có bề mặt thông thoáng, co giãn tốt, dễ dàng vệ sinh khi bám bẩn\r\nĐế giày Nike làm từ cao su tăng độ ma sát, an toàn khi tập luyện\r\nKiểu dáng giày cổ thấp trẻ trung, năng động và hợp thời trang",
          "men", "lifestyle", 5000000);
            product.Rows.Add("MAM02",
         "Giày Lifestyle Nam Nike Air Max DC9336-400",
         "Được làm từ 12% sợi tổng hợp, 61% da cùng 27% sợi dệt giúp giày Nike bền bỉ hơn, khả năng chống nước và đàn hồi tốt.\r\nDáng giày cổ thấp và màu sắc tối giản, phù hợp với nhiều mẫu quần áo khác nhau cho bạn tha hồ lựa chọn.",
         "men", "lifestyle", 5000000);
            ShowItem();
            product.Rows.Add("MAM03",
        "Giày Lifestyle Nam Nike Air Zoom-Type Se CV2220",
        "Nike Air Zoom-Type Se CV2220 được làm từ chất liệu 6% Leather, 94% Textile có khả năng thoáng khí, không gây bí chân khi mang lâu\r\nCông nghệ Air zoom độc quyền hỗ trợ tối đa cho việc phản hồi lực và tăng tốc cho từng hoạt động của bàn chân khi vận động\r\nĐế giày Nike cao su tăng độ ma sát, tránh trơn trượt, an toàn cho người mang\r\nKiểu giày cổ thấp trẻ trung, dễ dàng phối đồ cho các bạn nam",
        "men", "lifestyle", 5000000);
            //Nam.sport
            product.Rows.Add("MRN01",
        "Giày Chạy Bộ Nam Nike Zoom Fly 4 CT2392-100",
        "Nike Zoom Fly 4 CT2392-100 được làm từ chất liệu 71% Textile, 29% Sợi tổng hợp mềm mại có độ co giãn cao và hạn chế bị nhăn\r\nBộ đế giày Nike sở hữu thiết kế với nhiều khe nhỏ đan xen giúp tăng ma sát và an toàn khi tập luyện\r\nPhần trên được trang bị bằng công nghệ Nike Flyknit và Nike React đem lại cảm giác nhẹ và thoáng nhưng không kém phần chắc chắn, bền bỉ\r\nKiểu dáng giày cổ thấp phổ biến, phù hợp cho nhiều mục đích sử dụng",
        "men", "sport", 5000000);
            product.Rows.Add("MRN02",
       "Giày Chạy Bộ Nam Nike ZoomX Invincible Run FK CT2228-103",
       "Mẫu giày Nike được kết hợp từ 12% sợi tổng hợp và 88% sợi dệt giúp bền bỉ, tạo cảm giác thoải mái khi mang.\r\nNike Zoomx Invincible Run Fk CT2228-103 có đế giày với nhiều khe nhỏ tăng ma sát nên an toàn trong mọi hoạt động.\r\nKiểu dáng giày cổ thấp linh hoạt, năng động và dễ sử dụng.",
       "men", "sport", 5000000);
            product.Rows.Add("MRN03",
       "Giày Chạy Bộ Nam Nike Zoom Tempo Next Fk CI9923-005",
       "Nike Air Zoom Tempo Next Fk CI9923-005 kết hợp từ 92% vải dệt và 8% sợi tổng hợp mang lại sự co giãn và thoáng khí tốt\r\nPhần đế giày Nike có các rãnh sâu giúp chống trơn trượt, tăng ma sát và an toàn cho người tập luyện\r\nSở hữu kiểu dáng giày cổ thấp năng động, thích hợp cho các bạn nam chạy bộ hoặc mang hằng ngày",
       "men", "sport", 5000000);
            ShowItem();



        }

        private void ShowItem()
        {
            flowLayoutPanel1.Controls.Clear();
            //for (int i = 0; i < data.Rows.Count; i++)
            //{
            //    if (gender == "" && item == "")
            //    {
            //        add(i);
            //    }
            //    else if (gender == "" && item != "" && data.Rows[i]["type"].ToString() == item)
            //    {
            //        add(i);
            //    }
            //    else if (gender != "" && item == "" && data.Rows[i]["gender"].ToString() == gender)
            //    {
            //        add(i);
            //    }
            //    else if (data.Rows[i]["gender"].ToString() == gender && data.Rows[i]["type"].ToString() == item)
            //    {
            //        add(i);
            //    }
            //}
            string expression;
            DataRow[] foundRows;
            if (gender == "" && item == "")
            {
          
                // Use the Select method to find all rows matching the filter.
                foundRows = product.Select();
            }
            else if (gender == "" && item != "" )
            {
                expression= "type = '"+item+"'";
                foundRows = product.Select(expression);
            }
            else if (gender != "" && item == "" )
            {
                expression = "gender = '" + gender + "'";
                foundRows = product.Select(expression);
            }
            else 
            {
                expression = "gender = '" + gender + "' and type = '" + item + "'";
                foundRows = product.Select(expression);
            }
            add(foundRows);
        }
        private void add(DataRow[] foundRows)
        {
            foreach (DataRow row in foundRows)
            {
                string id = row["id"].ToString();
               

                string name = row["name"].ToString();
                int price = Convert.ToInt32(row["price"]);

                Custom.UserControl1 it = new Custom.UserControl1(id, name, price.ToString());

                flowLayoutPanel1.Controls.Add(it);
            }    
        }
        private void add(int i)
        {
            string id = product.Rows[i]["id"].ToString();
            id = id.Replace(" ", "");

            string name = product.Rows[i]["name"].ToString();
            int price = Convert.ToInt32(product.Rows[i]["price"]);

            Custom.UserControl1 it = new Custom.UserControl1(id, name, price.ToString());

            flowLayoutPanel1.Controls.Add(it);
        }
        private void ShowProductSearch(DataTable dt_search)
        {
            if (dt_search.Rows.Count == 0)
                MessageBox.Show("Element not found!!!", "Notification", MessageBoxButtons.OK);
            else
            {
                flowLayoutPanel1.Controls.Clear();
                for (int i = 0; i < dt_search.Rows.Count; i++)
                {

                    string id = dt_search.Rows[i]["PRODUCT_ID"].ToString();
                    id = id.Replace(" ", "");

                    string name = dt_search.Rows[i]["PRODUCT_NAME"].ToString();
                    int price = Convert.ToInt32(dt_search.Rows[i]["PRODUCT_PRICE"]);

                    Custom.UserControl1 it = new Custom.UserControl1(id, name, price.ToString());

                    flowLayoutPanel1.Controls.Add(it);
                }
            }
        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            gender = "";
            label_all.ForeColor = Color.Red;
            label_nam.ForeColor = Color.Black;
            label_nu.ForeColor = Color.Black;
            label_treem.ForeColor = Color.Black;
           
        }

        private void label_thinhhanh_Click(object sender, EventArgs e)
        {
            gender = "men";
            label_all.ForeColor = Color.Black;
            label_nam.ForeColor = Color.Red;
            label_nu.ForeColor = Color.Black;
            label_treem.ForeColor = Color.Black;
            ShowItem();
        }

        private void label_nu_Click(object sender, EventArgs e)
        {
            gender = "woman";
            label_all.ForeColor = Color.Black;
            label_nam.ForeColor = Color.Black;
            label_nu.ForeColor = Color.Red;
            label_treem.ForeColor = Color.Black;
            ShowItem();
            
        }

        private void label_treem_Click(object sender, EventArgs e)
        {
            gender = "K";
            label_all.ForeColor = Color.Black;
            label_nam.ForeColor = Color.Black;
            label_nu.ForeColor = Color.Black;
            label_treem.ForeColor = Color.Red;
            
        }

     

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }



     
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
   

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            item = "";
            ShowItem();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            item = "lifestyle";
            ShowItem();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            item = "sport";
            ShowItem();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            item = "sandal";
            ShowItem();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            item = "dep";
            ShowItem();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
