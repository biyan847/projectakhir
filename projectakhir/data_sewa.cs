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
        private string stringConnection = "data source= FADLISTEV\\FADLI036;database=SewaMobil;User ID=sa;Password=fad036";
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

            string queryString = "INSERT INTO dbo.sewa (id_sewa, tanggal, ktp_P, plat_nomor,) VALUES (@id_sewa, @tanggal, @ktp_P, @plat_nomor, @)";
            SqlCommand cmd = new SqlCommand(queryString, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("id_sewa", idsewa));
            cmd.Parameters.Add(new SqlParameter("No_Hp", tanggal));
            cmd.Parameters.Add(new SqlParameter("ktp_P", ktp_p));
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
    }
}
