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
    public partial class data_supir : Form
    {
        private string stringConnection = "data source= FADLISTEV\\FADLI036;database=SewaMobil;User ID=sa;Password=fad036";
        private SqlConnection koneksi;
        public data_supir()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void dataPenyewaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data_penyewa dp = new data_penyewa();
            dp.Show();
            this.Hide();
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

        private void data_supir_Load(object sender, EventArgs e)
        {
            string idsupir = tbxIdSupir.Text;
            string nama = tbxNama.Text;
            string ktp_s = tbxKtp_s.Text;
            string jenis_kel = tbxJenis_kel.Text;
            string no_hp = tbxNo_hp.Text;
            string alamat = tbxAlamat.Text;
            string plat_nomor = tbxPlat_nomor.Text;

            koneksi.Open();

            string str = "INSERT INTO dbo.Supir (id_supir,nama,ktp_s,jenis_kel,no_hp,alamat,plat_nomor) VALUES (@id_supir, @nama, @ktp_s,@jenis_kel, @no_hp, @alamat, @plat_nomor)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("id_supir", IdSupir));
            cmd.Parameters.Add(new SqlParameter("nama", Nama));
            cmd.Parameters.Add(new SqlParameter("ktp_S", Ktp_s));
            cmd.Parameters.Add(new SqlParameter("jenis_kel", Jenis_kel));
            cmd.Parameters.Add(new SqlParameter("no_hp", No_hp));
            cmd.Parameters.Add(new SqlParameter("alamat", Alamat));
            cmd.Parameters.Add(new SqlParameter("plat_nomor", Plat_nomor));
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data berhasil disimpan", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
