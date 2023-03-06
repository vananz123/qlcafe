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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                Button btnCate = new Button();
                btnCate.Size = new Size(100, 60);
                btnCate.UseVisualStyleBackColor = true;
                btnCate.Tag = i;
                btnCate.TextAlign = ContentAlignment.MiddleCenter;
                btnCate.Text = "Danh mực A";
                btnCate.Click += new EventHandler(btnCate_Click);
                flowCategory.Controls.Add(btnCate);
            }
        }
        protected void btnCate_Click(object sender ,EventArgs e)
        {
            flowDish.Controls.Clear();
            Button btn =sender as Button;
            for (int i = 0; i < 4; i++)
            {
                Label lb = new Label();
                lb.Size = new Size(100, 60);
                lb.Text = i.ToString();
                flowDish.Controls.Add(lb);
            }
        }
    }
}
