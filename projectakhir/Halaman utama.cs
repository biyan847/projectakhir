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
    public partial class HalamanUtama : Form
    {
        public HalamanUtama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            datadiri_penyewa datapenyewa = new datadiri_penyewa();
            datapenyewa.Show();
            this.Hide();
        }

        
    }
}
