using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUANCUATOI
{
    public partial class frmdangnhap : Form
    {
        string connectionString = "Data Source=QUAN\\SQLEXPRESS;Initial Catalog=duan;Integrated Security=true;User ID=Gaming;Password=3777";

        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void frmdangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = string.Format($"select count(*) from NHANVIEN where TENDANGNHAP='{txtTenDangNhap.Text}' AND MATKHAU='{txtMatKhau.Text}'");
            SqlCommand cmd = new SqlCommand(query,connection);
            int check = int.Parse(cmd.ExecuteScalar().ToString());
            if (check > 0) MessageBox.Show("Ban da dang nhap thanh cong!");
            else MessageBox.Show("Ban da dang nhap khong thanh cong!");

            connection.Close();
        }
    }
}
