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
        private string stringConnection = "data source= FADLISTEV\\FADLI036;database=SewaMobil;User ID=sa;Password=fad036";
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
            string idAdmin = tbxidAdmin.Text;
            string idGudang = tbxidGudang.Text;
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
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                tbxplatnomor.Text = row.Cells["plat_nomor"].Value.ToString();
                comboBox1.Text = row.Cells["jenis"].Value.ToString();
                tbxwarna.Text = row.Cells["warna"].Value.ToString();
                tbxidAdmin.Text = row.Cells["id_admin"].Value.ToString();
                tbxidGudang.Text = row.Cells["id_gudang"].Value.ToString();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string queryString = "Update dbo.Mobil set jenis='" + comboBox1.Text + "', warna='" + tbxwarna.Text + "', id_admin='" + tbxidAdmin.Text + "', id_gudang='" + tbxidGudang.Text + "' where plat_nomor='" + tbxplatnomor.Text + "'";
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
            tbxidAdmin.Text = "";
            tbxidGudang.Text = "";
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
    }
}
