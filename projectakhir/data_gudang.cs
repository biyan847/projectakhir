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
    public partial class data_gudang : Form
    {
        private string stringConnection = "data source= FADLISTEV\\FADLI036;database=SEWAMobil2;User ID=sa;Password=fad036";
        private SqlConnection koneksi;
        public data_gudang()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void dataSupirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data_supir ds = new data_supir();
            ds.Show();
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
        private void refreshform()
        {
            tbxIdGudang.Text = "";
            tbxAlamat.Text = "";
            tbxKapasitas.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string idGudang = tbxIdGudang.Text;
            string alamat = tbxAlamat.Text;
            string kapasitas = tbxKapasitas.Text;
            koneksi.Open();

            string str = "INSERT INTO dbo.Gudang (id_gudang, alamat, kapasitas) VALUES (@id_gudang, @alamat, @kapasitas)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("id_gudang", idGudang));
            cmd.Parameters.Add(new SqlParameter("alamat", alamat));
            cmd.Parameters.Add(new SqlParameter("kapasitas", kapasitas));
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data berhasil disimpan", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView();
            refreshform();
        }

        private void data_gudang_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Gudang";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView();
            button4.Enabled= false; 
        }

        private void dataSupirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            data__admin da = new data__admin();
            da.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Data : " + tbxIdGudang.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                koneksi.Open();
                string queryString = "Delete dbo.Gudang where id_gudang='" + tbxIdGudang.Text + "'";
                SqlCommand cmd = new SqlCommand(queryString, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Hapus Data Berhasil");
                dataGridView();
                refreshform();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string queryString = "Update dbo.Gudang set alamat='" + tbxAlamat.Text + "', kapasitas='" + tbxKapasitas.Text +  "' where id_gudang='" + tbxIdGudang.Text + "'";
            SqlCommand cmd = new SqlCommand(queryString, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Update Data Berhasil");
            dataGridView();
            refreshform();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                tbxIdGudang.Text = row.Cells["id_gudang"].Value.ToString();
                tbxAlamat.Text = row.Cells["alamat"].Value.ToString();
                tbxKapasitas.Text = row.Cells["kapasitas"].Value.ToString();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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
    }
}
