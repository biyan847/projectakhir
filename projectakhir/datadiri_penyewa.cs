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
    public partial class datadiri_penyewa : Form
    {
        private string stringConnection = "data source= FADLISTEV\\FADLI036;database=SewaMobil;User ID=sa;Password=fad036";
        private SqlConnection koneksi;
        public datadiri_penyewa()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);  
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void datadiri_penyewa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formkonfirmasipesanan formkonfirmasipesanan = new formkonfirmasipesanan();
            string ktp = textBox1.Text;
            string nama = textBox2.Text;
            string no_hp = textBox3.Text;
            string jeniskelamin = comboBox2.Text;
            string jalan = textBox5.Text;
            string kota = textBox6.Text;
            string provinsi = textBox7.Text;
            string jenismobil = comboBox1.Text;
            string idadmin = "A12";
            string platnomor = "AE 214 BE";
            koneksi.Open();

            string queryString = "INSERT INTO dbo.penyewa (ktp_p, nama, no_hp, jenis_kel, jalan, kota, provinsi, id_admin, plat_nomor, jenis_mobil) VALUES (@ktp_p, @nama, @no_hp, @jenis_kel, @kota, @provinsi, A12, AE214BE, @jenis_mobil)";
            SqlCommand cmd = new SqlCommand(queryString, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("ktp_p", ktp));
            cmd.Parameters.Add(new SqlParameter("nama", nama));
            cmd.Parameters.Add(new SqlParameter("no_hp", no_hp));
            cmd.Parameters.Add(new SqlParameter("jenis_kel", jeniskelamin));
            cmd.Parameters.Add(new SqlParameter("jalan", jalan));
            cmd.Parameters.Add(new SqlParameter("kota", kota));
            cmd.Parameters.Add(new SqlParameter("provinsi", provinsi));
            cmd.Parameters.Add(new SqlParameter("id_admin", idadmin));
            cmd.Parameters.Add(new SqlParameter("plat_nomor", platnomor));
            cmd.Parameters.Add(new SqlParameter("jenis_mobil", jenismobil));
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data berhasil disimpan", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            formkonfirmasipesanan.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HalamanUtama hu = new HalamanUtama();
            hu.Show();
            this.Hide();
        }
    }
}
