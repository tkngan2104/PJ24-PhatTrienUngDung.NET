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
using System.Configuration;
using System.Runtime.Serialization.Formatters.Binary;
using BUS;

namespace Project_QLBV
{
    public partial class _login : Form
    {
        Connection_BUS busData = new Connection_BUS();
        public _login()
        {
            InitializeComponent();
            pnlLOGIN.BackColor = Color.FromArgb(170, pnlLOGIN.BackColor);
            pnlLOGIN.Dock = DockStyle.Right; // Đặt panel vào góc phải của Form
            pnlLOGIN.Width = this.Width / 2; // Tính toán kích thước của panel sao cho chiếm 1 nửa của Form theo chiều ngang
        }
        //private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=QLBV;Integrated Security=True;TrustServerCertificate=True";
        
        private void _login_Load(object sender, EventArgs e)
        {
            lblUSER.Parent = pnlLOGIN;
            lblUSER.BackColor = Color.Transparent;
            lblPASSWORD.Parent = pnlLOGIN;
            lblPASSWORD.BackColor = Color.Transparent;
            

        }



        private void pnlLOGIN_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {

            

            string sql = "Data Source=" + txtServer.Text + ";Initial Catalog=" + cboDatabase.Text + ";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            if (cboDatabase.Text != "" && txtServer.Text != "")
            {


                try
                {
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                    connectionStringsSection.ConnectionStrings["QLBV.Properties.Settings.QLBVConnectionString"].ConnectionString = sql;
                    config.Save();
                    ConfigurationManager.RefreshSection("connectionStrings");
                    using (SqlConnection conn = new SqlConnection(sql))
                    {
                        try
                        {
                            conn.Open();


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Có lỗi xảy ra khi cố gắng mở kết nối: " + ex.Message);
                        }
                    }

                    busData.setSeverName(txtServer.Text);
                    busData.setdataName(cboDatabase.Text);
                    if (busData.ktDuongDan(txtServer.Text, cboDatabase.Text))
                    {
                        busData.setDataBase();
                        _menu menu = new _menu();                     
                        MessageBox.Show("Kết nối thành công!!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Hide();
                        menu.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tên sever không đúng hoặc database không tồn tại!");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Xảy ra lỗi: " + ex.Message + "Lỗi kết nối database!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Hãy chắc chắn rằng bạn muốn thoát chương trình !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {
            // Xác định chuỗi kết nối đến máy chủ
            string serverName = txtServer.Text; // Lấy tên máy chủ từ textbox
            string connectionString = $"Data Source={serverName};Integrated Security=True;";

            // Tạo kết nối tới máy chủ
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Tạo và thực thi truy vấn để lấy danh sách cơ sở dữ liệu
                    string query = "SELECT name FROM sys.databases WHERE database_id > 4"; // Lấy danh sách cơ sở dữ liệu không phải là các hệ thống
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Tạo danh sách để lưu trữ tên cơ sở dữ liệu
                    List<string> databases = new List<string>();

                    // Đọc từng dòng dữ liệu và thêm tên cơ sở dữ liệu vào danh sách
                    while (reader.Read())
                    {
                        string dbName = reader["name"].ToString();
                        databases.Add(dbName);
                    }

                    // Gán danh sách cơ sở dữ liệu vào combobox
                    cboDatabase.DataSource = databases;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi lấy danh sách cơ sở dữ liệu: " + ex.Message);
                }
            }
        }
    }
}
