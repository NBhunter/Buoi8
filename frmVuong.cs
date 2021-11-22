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
    public partial class frmVuong : Form
    {
        public frmVuong()
        {
            InitializeComponent();
        }
        public double canha;

        public double TinhDienTich()
        {
            double dientich = this.canha * this.canha;
            return dientich;
        }

        public double TinhChuVi()
        {
            double chuvi = this.canha * 4;
            return chuvi;
        }

        private void frmVuong_Load(object sender, EventArgs e)
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
