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
    public partial class data__admin : Form
    {
        private string stringConnection = "data source= FADLISTEV\\FADLI036;database=SEWAMobil2;User ID=sa;Password=fad036";
        private SqlConnection koneksi;
        public data__admin()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
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

        private void dataGudangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data_gudang dg = new data_gudang();
            dg.Show();
            this.Hide();
        }

        private void dataSopirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data_supir ds = new data_supir();
            ds.Show();
            this.Hide();
        }

        private void dataGridView()
        {

            koneksi.Open();
            string str = "select * from dbo.Admin";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView();
            button4.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Idadmin = textBox1.Text;
            string Nohp = textBox3.Text;
            string alamat = textBox4.Text;
            string jeniskelamin = comboBox1.Text;
            string nama = textBox2.Text;
            koneksi.Open();

            string queryString = "INSERT INTO dbo.Admin (id_admin, No_Hp, alamat, jenis_kelamin, Nama) VALUES (@id_admin, @no_hp, @alamat, @jenis_kelamin, @nama)";
            SqlCommand cmd = new SqlCommand(queryString, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("id_admin", Idadmin));
            cmd.Parameters.Add(new SqlParameter("No_Hp", Nohp));
            cmd.Parameters.Add(new SqlParameter("alamat", alamat));
            cmd.Parameters.Add(new SqlParameter("jenis_kelamin", jeniskelamin));
            cmd.Parameters.Add(new SqlParameter("Nama", nama));
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data berhasil disimpan", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView();
            refreshform();
        }

        private void refreshform()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            textBox4.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["id_admin"].Value.ToString();
                textBox2.Text = row.Cells["Nama"].Value.ToString();
                textBox3.Text = row.Cells["No_Hp"].Value.ToString();
                textBox4.Text = row.Cells["alamat"].Value.ToString();
                comboBox1.Text = row.Cells["jenis_kelamin"].Value.ToString();
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
                string queryString = "Delete dbo.Admin where id_admin='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(queryString, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Hapus Data Berhasil");
                dataGridView();
                refreshform();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            koneksi.Open();
            string queryString = "Update dbo.Admin set No_Hp='" + textBox3.Text + "', alamat='" + textBox4.Text + "', Nama='" + textBox2.Text + "', jenis_kelamin='" + comboBox1.Text + "' where id_admin='"+ textBox1.Text +"'";
            SqlCommand cmd = new SqlCommand(queryString, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Update Data Berhasil");
            dataGridView();
            refreshform();
            
            
        }

        private void data__admin_Load(object sender, EventArgs e)
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
