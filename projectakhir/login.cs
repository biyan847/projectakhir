using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectakhir
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "a21" && textBox2.Text == "1234") 
            {
                data_penyewa dp = new data_penyewa();
                dp.Show();
                this.Hide();
            }
            else if (textBox1.Text == "owner" && textBox2.Text == "owner")
            {
                data__admin da = new data__admin();
                da.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error\n - Pastikan Username dan Password benar \n - Pastikan mengisi kolom Username dan Password");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            HalamanUtama hu = new HalamanUtama();
            hu.Show();
            this.Close();
        }
    }
}
