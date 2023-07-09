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
        private string stringConnection = "data source= FADLISTEV\\FADLI036;database=SewaMobil;User ID=sa;Password=fad036";
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
            refreshform();
        }
    }
}
