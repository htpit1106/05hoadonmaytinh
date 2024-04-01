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

namespace _05hoadonbanmaytinh {
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string chuoi = "Data Source=DESKTOP-RB1EPNR;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
       
        void loadData()
        {
            string query = "select * from hoadon";
            cmd = conn.CreateCommand();
            cmd.CommandText = query;
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void runCommand(string query)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            loadData();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btt_them_Click(object sender, EventArgs e)
        {
            string loaimay;
            if (radioButton1.Checked) loaimay = "De ban";
            else loaimay = "Xach tay";
            int thanhtien;
            thanhtien = (int)num_soluong.Value * Convert.ToInt32(tb_dongia.Text);
            cmd = conn.CreateCommand();
            string query = "insert into hoadon values ('" + tb_mahoadon.Text + "','" + tb_tenKH.Text + "'," +
                "'" + ngayban.Value.ToString() + "', '@loaimay', '" + tb_tenmay.Text + "'," +
                "'" + tb_dongia.Text + "', '" + num_soluong.Value.ToString() + "' , '@thanhtien')";
            cmd.Parameters.AddWithValue("@loaimay", loaimay);
            cmd.Parameters.AddWithValue("@thanhtien", thanhtien);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void tb_dongia_Leave(object sender, EventArgs e)
        {
            if (!uint.TryParse(tb_dongia.Text, out uint ketqua))
            {
                MessageBox.Show("nhap lai don gia");
                tb_dongia.Focus();
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoi);
            conn.Open();
            loadData();
        }

        private void btt_sua_Click(object sender, EventArgs e)
        {
            string query = "update hoadon set [Mã HĐ] = '"+tb_mahoadon.Text+"'"
        }

        private void btt_dong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

