using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanGui
{
    public partial class WonForm : Form
    {
        public WonForm()
        {
            InitializeComponent();
        }

        private void btnreplay_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void btnWonformexit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void WonForm_Load(object sender, EventArgs e)
        {

        }
    }
}
