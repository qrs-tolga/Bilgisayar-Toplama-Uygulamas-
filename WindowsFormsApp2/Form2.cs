using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static int secim;

        private void btnEv_Click(object sender, EventArgs e)
        {
            secim = 0;
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void btnIs_Click(object sender, EventArgs e)
        {
            secim = 1;
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void btnOyun_Click(object sender, EventArgs e)
        {
            secim = 2;
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
