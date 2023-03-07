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
        private void LoadAllProduct()
        {
            flowDish.Controls.Clear();
            for (int i = 0; i < 14; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(100, 60);
                btn.Text = i.ToString();
                btn.Click +=new EventHandler(btnProduct_Click);
                flowDish.Controls.Add(btn);
            }
        }
        private void FrmCategory_Load(object sender, EventArgs e)
        {
            btnAddProduct.Enabled = false;
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
            LoadAllProduct();
        }
        protected void btnCate_Click(object sender ,EventArgs e)
        {
            flowDish.Controls.Clear();
            for (int i = 0; i < 4; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(100, 60);
                btn.Text = i.ToString();
                btn.Click += new EventHandler(btnProduct_Click);
                flowDish.Controls.Add(btn);
            }
        }
        protected void btnProduct_Click( object sender ,EventArgs e)
        {
            btnAddProduct.Enabled = true;
            Button button = sender as Button;
            lbNameProduct.Text =button.Text;
        }

        private void btnAllProduct_Click(object sender, EventArgs e)
        {
            LoadAllProduct();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
