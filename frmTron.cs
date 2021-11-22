using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi8
{
    public partial class frmTron : Form
    {
        public frmTron()
        {
            InitializeComponent();
        }
        public const double Pi = 3.14;

        public double bankinh;

        public double TinhDienTich()
        {
            double dientich = this.bankinh * this.bankinh * Pi;
            return dientich;
        }

        public double TinhChuVi()
        {
            double chuvi = this.bankinh * 2 * Pi;
            return chuvi;
        }

        private void frmTron_Load(object sender, EventArgs e)
        {
            this.txtDientich.Text = TinhDienTich().ToString();
            this.txtChuvi.Text = TinhChuVi().ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }
    }
}
