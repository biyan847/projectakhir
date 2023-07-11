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
        private string stringConnection = "data source= FADLISTEV\\FADLI036;database=SEWAMobil2;User ID=sa;Password=fad036";
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
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idsupir = textBox1.Text;
            string nama = textBox2.Text;
            string ktp_s = textBox3.Text;
            string jenis_kel = comboBox1.Text;
            string no_hp = textBox5.Text;
            string alamat = textBox6.Text;
            string plat_nomor = comboBox2.Text;

            koneksi.Open();

            string str = "INSERT INTO dbo.Supir (id_supir,nama,ktp_s,jenis_kel,no_hp,alamat,plat_nomor) VALUES (@id_supir, @nama, @ktp_s,@jenis_kel, @no_hp, @alamat, @plat_nomor)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("id_supir", idsupir));
            cmd.Parameters.Add(new SqlParameter("nama", nama));
            cmd.Parameters.Add(new SqlParameter("ktp_S", ktp_s));
            cmd.Parameters.Add(new SqlParameter("jenis_kel", jenis_kel));
            cmd.Parameters.Add(new SqlParameter("no_hp", no_hp));
            cmd.Parameters.Add(new SqlParameter("alamat", alamat));
            cmd.Parameters.Add(new SqlParameter("plat_nomor", plat_nomor));
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data berhasil disimpan", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView();
            refreshform();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.supir";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView();
            button3.Enabled = false;
            ComboBox2();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["id_supir"].Value.ToString();
                textBox2.Text = row.Cells["nama"].Value.ToString();
                textBox3.Text = row.Cells["ktp_s"].Value.ToString();
                comboBox1.Text = row.Cells["jenis_kel"].Value.ToString();
                textBox5.Text = row.Cells["no_hp"].Value.ToString();
                textBox6.Text = row.Cells["alamat"].Value.ToString();
                comboBox2.Text = row.Cells["plat_nomor"].Value.ToString();
                
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }

        }
        private void refreshform()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string queryString = "Update dbo.Supir set nama='" + textBox2.Text + "', ktp_s='" + textBox3.Text + "', jenis_kel='" + comboBox1.Text + "', no_hp='" + textBox5.Text + "', alamat='" + textBox6.Text + "', plat_nomor='" + comboBox2.Text + "' where id_supir='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(queryString, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Update Data Berhasil");
            dataGridView();
            refreshform();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                if (MessageBox.Show("Yakin Ingin Menghapus Data : " + textBox1.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    koneksi.Open();
                    string queryString = "Delete dbo.Supir where id_supir='" + textBox1.Text + "'";
                    SqlCommand cmd = new SqlCommand(queryString, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    koneksi.Close();
                    MessageBox.Show("Hapus Data Berhasil");
                    dataGridView();
                    refreshform();
                }
            
        }

        private void dataSewaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data_sewa ds = new data_sewa();
            ds.Show();
            this.Hide();
        }

        private void ComboBox2()
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

            comboBox2.DisplayMember = "plat_nomor";
            comboBox2.ValueMember = "plat_nomor";
            comboBox2.DataSource = dt;
        }
    }
}
