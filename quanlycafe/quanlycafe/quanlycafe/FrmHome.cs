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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void FrmHome_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Button a = new Button();
                a.Text = "Bàn" + i.ToString();
                a.Size = new Size(130, 60);
                a.UseVisualStyleBackColor = true;

                flowTable.Controls.Add(a);
            }    
        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory =new FrmCategory();
            
            frmCategory.Show();
        }
    }
}
