using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace koneksi_login
{
    public partial class Akun : Form
    {
        public Akun()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReport21.SetParameterValue("akun_user", txtUsername.Text);
            crystalReportViewer1.ReportSource = CrystalReport21;
            crystalReportViewer1.Refresh();
        }
    }
}
