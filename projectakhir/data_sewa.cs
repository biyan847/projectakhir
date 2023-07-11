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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projectakhir
{
    public partial class data_sewa : Form
    {
        private string stringConnection = "data source= FADLISTEV\\FADLI036;database=SEWAMobil2;User ID=sa;Password=fad036";
        private SqlConnection koneksi;
        public data_sewa()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void data_sewa_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView()
        {

            koneksi.Open();
            string str = "select * from dbo.sewa";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idsewa = textBox1.Text;
            string tanggal = dateTimePicker1.Text;
            string ktp_p = textBox2.Text;
            string plat_nomor = textBox3.Text;
            koneksi.Open();

            string queryString = "INSERT INTO dbo.sewa (id_sewa, tanggal, ktp_p, plat_nomor) VALUES (@id_sewa, @tanggal, @ktp_p, @plat_nomor)";
            SqlCommand cmd = new SqlCommand(queryString, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("id_sewa", idsewa));
            cmd.Parameters.Add(new SqlParameter("tanggal", tanggal));
            cmd.Parameters.Add(new SqlParameter("ktp_p", ktp_p));
            cmd.Parameters.Add(new SqlParameter("plat_nomor", plat_nomor));
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data berhasil disimpan", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView();
            refreshform();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView();
            button4.Enabled = false;
        }
        private void refreshform()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Data : " + textBox1.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                koneksi.Open();
                string queryString = "Delete dbo.sewa where id_sewa='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(queryString, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Hapus Data Berhasil");
                dataGridView();
                refreshform();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["id_sewa"].Value.ToString();
                dateTimePicker1.Text = row.Cells["tanggal"].Value.ToString();
                textBox2.Text = row.Cells["ktp_p"].Value.ToString();
                textBox3.Text = row.Cells["plat_nomor"].Value.ToString();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data__admin da = new data__admin();
            da.Show();
            this.Hide();
        }

        private void dataGudangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data_gudang dg = new data_gudang();
            dg.Show();
            this.Hide();
        }

        private void dataMobilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data_mobil dm = new data_mobil();
            dm.Show();
            this.Hide();
        }

        private void dataPenyewaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data_penyewa dp = new data_penyewa();
            dp.Show();
            this.Hide();
        }

        private void dataSupirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data_supir ds = new data_supir();
            ds.Show();
            this.Hide();
        }

        private void homeScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HalamanUtama hu = new HalamanUtama();
            hu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string queryString = "Update dbo.sewa set tanggal='" + dateTimePicker1.Text + "', ktp_p='" + textBox2.Text + "', plat_nomor='" + textBox3.Text + "' where id_sewa='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(queryString, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Update Data Berhasil");
            dataGridView();
            refreshform();
        }
    }
}
