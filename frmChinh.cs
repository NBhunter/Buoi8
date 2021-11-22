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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }
        public void XoaTxt()
        {
            txtCanh.Clear();
            txtDai.Clear();
            txtRong.Clear();
            txtBankinh.Clear();
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            XoaTxt();

            txtCanh.Enabled = true;
            txtDai.Enabled = false;
            txtRong.Enabled = false;
            txtBankinh.Enabled = false;

            txtCanh.Focus();
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            XoaTxt();

            txtCanh.Enabled = false;
            txtDai.Enabled = true;
            txtRong.Enabled = true;
            txtBankinh.Enabled = false;

            txtDai.Focus();
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            XoaTxt();

            txtCanh.Enabled = false;
            txtDai.Enabled = false;
            txtRong.Enabled = false;
            txtBankinh.Enabled = true;

            txtBankinh.Focus();
        }

        private void btnThuchien_Click(object sender, EventArgs e)
        {
            if(this.rb1.Checked == true)
            {
                if(this.txtCanh.Text == "")
                {

                    MessageBox.Show("Nhập chiều dài cạnh hình vuông!", "THÔNG BÁO");
                    txtCanh.Focus();
                }
                else
                {
                    frmVuong f2 = new frmVuong();
                    f2.canha = double.Parse(this.txtCanh.Text);
                    f2.ShowDialog();
                }    
            }  
            if(rb2.Checked == true)
            {
                if(txtDai.Text == "" || txtRong.Text == "")
                {
                    MessageBox.Show("Hãy nhập chiều dài & chiều rộng cho hình chữ nhật!", "THÔNG BÁO");
                    txtDai.Focus();
                }
                else
                {
                    frmChunhat f3 = new frmChunhat();
                    f3.dai = double.Parse(this.txtDai.Text);
                    f3.rong = double.Parse(this.txtRong.Text);
                    f3.ShowDialog();
                }    
            }
            if(rb3.Checked == true)
            {
                if(txtBankinh.Text == "")
                {
                    MessageBox.Show("Hãy nhập bán kính hình tròn!", "THÔNG BÁO");
                    txtBankinh.Focus();
                }
                else
                {
                    frmTron f4 = new frmTron(); ;
                    f4.bankinh = double.Parse(this.txtBankinh.Text);
                    f4.ShowDialog();
                }    
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void frmChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                Application.Exit();
            }
            else
                e.Cancel = true;
                    
        }

        private void thựcHiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.rb1.Checked == true)
            {
                if (this.txtCanh.Text == "")
                {

                    MessageBox.Show("Nhập chiều dài cạnh hình vuông!", "THÔNG BÁO");
                    txtCanh.Focus();
                }
                else
                {
                    frmVuong f2 = new frmVuong();
                    f2.canha = double.Parse(this.txtCanh.Text);
                    f2.ShowDialog();
                }
            }
            if (rb2.Checked == true)
            {
                if (txtDai.Text == "" || txtRong.Text == "")
                {
                    MessageBox.Show("Hãy nhập chiều dài & chiều rộng cho hình chữ nhật!", "THÔNG BÁO");
                    txtDai.Focus();
                }
                else
                {
                    frmChunhat f3 = new frmChunhat();
                    f3.dai = double.Parse(this.txtDai.Text);
                    f3.rong = double.Parse(this.txtRong.Text);
                    f3.ShowDialog();
                }
            }
            if (rb3.Checked == true)
            {
                if (txtBankinh.Text == "")
                {
                    MessageBox.Show("Hãy nhập bán kính hình tròn!", "THÔNG BÁO");
                    txtBankinh.Focus();
                }
                else
                {
                    frmTron f4 = new frmTron(); ;
                    f4.bankinh = double.Parse(this.txtBankinh.Text);
                    f4.ShowDialog();
                }
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void txtCanh_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Bạn phải nhập 1 con số nguyên!", "ERROR");
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtDai_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Bạn phải nhập 1 con số nguyên!", "ERROR");
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void txtRong_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Bạn phải nhập 1 con số nguyên!", "ERROR");
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtBankinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Bạn phải nhập 1 con số nguyên!", "ERROR");
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
