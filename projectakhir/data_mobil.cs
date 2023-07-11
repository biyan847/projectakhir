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

namespace projectakhir
{

    public partial class data_mobil : Form
    {
        private string stringConnection = "data source= FADLISTEV\\FADLI036;database=SEWAMobil2;User ID=sa;Password=fad036";
        private SqlConnection koneksi;
        public data_mobil()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void dataGudangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data_gudang dg = new data_gudang();
            dg.Show();
            this.Hide();
        }

        private void dataSupriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data_supir ds = new data_supir();
            ds.Show();
            this.Hide();
        }

        private void dataPenyewaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data_penyewa dp = new data_penyewa();
            dp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string platnomor = tbxplatnomor.Text;
            string jenis = comboBox1.Text;
            string warna = tbxwarna.Text;
            string idAdmin = comboBox2.Text;
            string idGudang = comboBox3.Text;
            koneksi.Open();

            string queryString = "INSERT INTO dbo.Mobil (plat_nomor, jenis, warna, id_admin, id_gudang) VALUES (@plat_nomor, @jenis, @warna, @id_admin, @id_gudang)";
            SqlCommand cmd = new SqlCommand(queryString, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("plat_nomor", platnomor));
            cmd.Parameters.Add(new SqlParameter("jenis", jenis));
            cmd.Parameters.Add(new SqlParameter("warna", warna));
            cmd.Parameters.Add(new SqlParameter("id_admin", idAdmin));
            cmd.Parameters.Add(new SqlParameter("id_gudang", idGudang));
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data berhasil disimpan", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView();
            refreshform();
        }

        private void dataSupirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data__admin da = new data__admin();
            da.Show();
            this.Hide();
        }

        private void dataGridView()
        {

            koneksi.Open();
            string str = "select * from dbo.Mobil";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView();
            button3.Enabled=false;
            Comobox2();
            Comobox3();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                tbxplatnomor.Text = row.Cells["plat_nomor"].Value.ToString();
                comboBox1.Text = row.Cells["jenis"].Value.ToString();
                tbxwarna.Text = row.Cells["warna"].Value.ToString();
                comboBox2.Text = row.Cells["id_admin"].Value.ToString();
                comboBox3.Text = row.Cells["id_gudang"].Value.ToString();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string queryString = "Update dbo.Mobil set jenis='" + comboBox1.Text + "', warna='" + tbxwarna.Text + "', id_admin='" + comboBox2.Text + "', id_gudang='" + comboBox3.Text + "' where plat_nomor='" + tbxplatnomor.Text + "'";
            SqlCommand cmd = new SqlCommand(queryString, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Update Data Berhasil");
            dataGridView();
            refreshform();
        }
        private void refreshform()
        {
            tbxplatnomor.Text = "";
            comboBox1.Text = "";
            tbxwarna.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Data : " + tbxplatnomor.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                koneksi.Open();
                string queryString = "Delete dbo.Mobil where plat_nomor='" + tbxplatnomor.Text + "'";
                SqlCommand cmd = new SqlCommand(queryString, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Hapus Data Berhasil");
                dataGridView();
                refreshform();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void data_mobil_Load(object sender, EventArgs e)
        {

        }

        private void homeScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HalamanUtama hu = new HalamanUtama();
            hu.Show();
            this.Hide();
        }

        private void dataSewaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data_sewa ds = new data_sewa();
            ds.Show();
            this.Hide();
        }

        private void Comobox2()
        {
            koneksi.Open();
            string query = "SELECT id_admin FROM Admin";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("id_admin");

            while (reader.Read())
            {
                DataRow row = dt.NewRow();
                row["id_admin"] = reader["id_admin"].ToString();
                dt.Rows.Add(row);
            }

            koneksi.Close();

            comboBox2.DisplayMember = "id_admin";
            comboBox2.ValueMember = "id_admin";
            comboBox2.DataSource = dt;
        }

        private void Comobox3() 
        {
            koneksi.Open();
            string query = "SELECT id_gudang FROM Gudang";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("id_gudang");

            while (reader.Read())
            {
                DataRow row = dt.NewRow();
                row["id_gudang"] = reader["id_gudang"].ToString();
                dt.Rows.Add(row);
            }

            koneksi.Close();

            comboBox3.DisplayMember = "id_gudang";
            comboBox3.ValueMember = "id_gudang";
            comboBox3.DataSource = dt;
        }
    }
}
