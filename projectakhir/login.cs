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
            }
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Mohon Masukkan Data");
            }
            if (textBox1.Text != "a21" && textBox2.Text != "1234")
            {
                MessageBox.Show("Masukkan Username dan Password Yang Benar");
            }
        }
    }
}
