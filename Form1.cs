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
        string chuoi = "Data Source=DESKTOP-GE1C4PK\\SQLEXPRESS;Initial Catalog=HoaDonMayTinh;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
       
        void loadData()
        {
            string query = "select * from tb_hoadon";
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
            string query = "insert into tb_hoadon values ('" + tb_mahoadon.Text + "','" + tb_tenKH.Text + "'," +
                "'" + ngayban.Value.ToString() + "', @loaimay, '" + tb_tenmay.Text + "'," +
                "'" + tb_dongia.Text + "', '" + num_soluong.Value.ToString() + "' , @thanhtien)";
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

        string loaimay;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoi);
            conn.Open();
            loadData();

            if (radioButton1.Checked) loaimay = "De ban";
            else loaimay = "Xach tay";
        }

        private void btt_sua_Click(object sender, EventArgs e)
        {
          
                if (radioButton1.Checked) loaimay = "De ban";
                else loaimay = "Xach tay";

                int thanhtien = (int)num_soluong.Value * Convert.ToInt32(tb_dongia.Text);

                string query = "UPDATE tb_hoadon SET [Mã HD] = @mahoadon, [Tên KH] = @tenKH, [Ngày Bán] = @ngayban, [Loại Máy] = @loaimay, " +
                "[Tên Máy] = @tenmay, [Đơn Giá] = @dongia, [Số Lương] = @soluong, [Thành Tiền] = @thanhtien WHERE [Mã HD] = @mahoadon";

                cmd.Parameters.AddWithValue("@mahoadon", tb_mahoadon.Text);
                cmd.Parameters.AddWithValue("@tenKH", tb_tenKH.Text);
                cmd.Parameters.AddWithValue("@ngayban", ngayban.Value.ToString()); // Định dạng ngày thích hợp
                cmd.Parameters.AddWithValue("@loaimay", loaimay);
                cmd.Parameters.AddWithValue("@tenmay", tb_tenmay.Text);
                cmd.Parameters.AddWithValue("@dongia", tb_dongia.Text);
                cmd.Parameters.AddWithValue("@soluong", num_soluong.Value.ToString());
                cmd.Parameters.AddWithValue("@thanhtien", thanhtien);

                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                loadData();
            

        }

        private void btt_dong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (row != null)
            {
                tb_mahoadon.Text = row.Cells[0].Value.ToString();
                tb_tenKH.Text = row.Cells[1].Value.ToString();
                ngayban.Value = Convert.ToDateTime(row.Cells[2].Value);
                loaimay = row.Cells[3].Value.ToString();
                if (loaimay == "De ban") radioButton1.Checked = true;
                else radioButton2.Checked = true;
                tb_tenmay.Text = row.Cells[4].Value.ToString();

                tb_dongia.Text = row.Cells[5].Value.ToString();
                num_soluong.Value = Convert.ToInt32(row.Cells[6].Value);
            }
        }

        private void btt_xoa_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            string m = dataGridView1.Rows[i].Cells[0].Value.ToString();
            cmd = conn.CreateCommand();
            string query = "delete from tb_hoadon where [Mã HD] = @ma";
            cmd.Parameters.AddWithValue("@ma", m);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            loadData();
        }
    }
}

