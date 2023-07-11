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
    public partial class data_penyewa : Form
    {
        private string stringConnection = "data source= FADLISTEV\\FADLI036;database=SEWAMobil2;User ID=sa;Password=fad036";
        private SqlConnection koneksi;
        public data_penyewa()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void dataMobilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data_mobil dm = new data_mobil();
            dm.Show();
            this.Hide();
        }

        private void dataGudangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data_gudang dg = new data_gudang();
            dg.Show();
            this.Hide();
        }

        private void dataSupirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data_supir ds = new data_supir();
            ds.Show();
            this.Hide();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.penyewa";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView();
            button1.Enabled = false;
            ComboBox3();
            ComboBox4();
        }

        private void data_penyewa_Load(object sender, EventArgs e)
        {

        }

        private void dataAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data__admin da = new data__admin();
            da.Show();
            this.Hide();
        }

        private void homeScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HalamanUtama hu = new HalamanUtama();
            hu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            koneksi.Open();
            string queryString = "Update dbo.penyewa set nama='" + textBox2.Text + "', no_hp='" + textBox3.Text + "', jenis_kel='" + comboBox2.Text + "', jalan='" + textBox5.Text + "', kota='" + textBox6.Text + "', provinsi='" + textBox7.Text + "', jenis_mobil='" + comboBox1.Text + "', id_admin='" + comboBox3.Text + "', plat_nomor='" + comboBox4.Text + "' where ktp_p='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(queryString, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Update Data Berhasil");
            dataGridView();
            refreshform();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["ktp_p"].Value.ToString();
                textBox2.Text = row.Cells["nama"].Value.ToString();
                textBox3.Text = row.Cells["no_hp"].Value.ToString();
                comboBox2.Text = row.Cells["jenis_kel"].Value.ToString();
                textBox5.Text = row.Cells["jalan"].Value.ToString();
                textBox6.Text = row.Cells["kota"].Value.ToString();
                textBox7.Text = row.Cells["provinsi"].Value.ToString();
                comboBox1.Text = row.Cells["jenis_mobil"].Value.ToString();
                comboBox3.Text = row.Cells["id_admin"].Value.ToString();
                comboBox4.Text = row.Cells["plat_nomor"].Value.ToString();

            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Data : " + textBox1.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                koneksi.Open();
                string queryString = "Delete dbo.penyewa where ktp_p='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(queryString, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Hapus Data Berhasil");
                dataGridView();
                refreshform();
            }
        }

        private void refreshform()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            comboBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox2.Text = "";
            comboBox4.Text = "";
        }

        private void datasewaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data_sewa ds = new data_sewa();
            ds.Show();
            this.Hide();
        }
        private void ComboBox3()
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

            comboBox3.DisplayMember = "id_admin";
            comboBox3.ValueMember = "id_admin";
            comboBox3.DataSource = dt;
        }
        private void ComboBox4()
        {
            koneksi.Open();
            string query = "SELECT plat_nomor FROM Mobil";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("plat_nomor");

            while (reader.Read())
            {
                DataRow row = dt.NewRow();
                row["plat_nomor"] = reader["plat_nomor"].ToString();
                dt.Rows.Add(row);
            }

            koneksi.Close();

            comboBox4.DisplayMember = "plat_nomor";
            comboBox4.ValueMember = "plat_nomor";
            comboBox4.DataSource = dt;
        }
    }
}
