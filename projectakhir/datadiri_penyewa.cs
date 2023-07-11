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
        private string stringConnection = "data source= FADLISTEV\\FADLI036;database=SEWAMobil2;User ID=sa;Password=fad036";
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
            string idadmin = comboBox3.Text;
            string platnomor = comboBox4.Text;
            koneksi.Open();

            string queryString = "INSERT INTO dbo.penyewa (ktp_p, nama, no_hp, jenis_kel, jalan, kota, provinsi, id_admin, plat_nomor, jenis_mobil) VALUES (@ktp_p, @nama, @no_hp, @jenis_kel, @jalan, @kota, @provinsi, @id_admin, @plat_nomor, @jenis_mobil)";
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            ComboBox3();
            ComboBox4();
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
