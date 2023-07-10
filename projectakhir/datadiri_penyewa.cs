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
    public partial class datadiri_penyewa : Form
    {
        public datadiri_penyewa()
        {
            InitializeComponent();
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
