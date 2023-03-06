using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlycafe
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form home = new FrmHome();
            home.ShowDialog();
            this.Hide();
        }

        private void btnLoginOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
