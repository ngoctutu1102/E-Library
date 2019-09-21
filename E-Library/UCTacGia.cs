using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1
{
    public partial class UCTacGia : UserControl
    {
        public UCTacGia()
        {
            InitializeComponent();
        }

        private void btnThemTG_Click(object sender, EventArgs e)
        {
            TacGia_DTO tgDTO = new TacGia_DTO();
            tgDTO.MaTG = txtMaTG.Text;
            tgDTO.TenTG = txtTenTG.Text;
            tgDTO.TieuSu = txTieuSuTG.Text;

            TacGia_BO tgBO = new TacGia_BO();
            int result = 0;
            result = tgBO.Them(tgDTO);
            if (result > 0)
            {
                MessageBox.Show("Thêm thông tin thành công");

            }
            else
            {
                MessageBox.Show("Thông tin này đã tồn tại!");
            }
        }

        private void btnXoaTG_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string MaTG;

                MaTG = txtMaTG.Text;
                TacGia_BO tgBO = new TacGia_BO();
                int result = tgBO.Xoa(MaTG);
                if (result > 0)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }

            }
        }

        private void btnSuaTG_Click(object sender, EventArgs e)
        {
            TacGia_DTO tgDTO = new TacGia_DTO();
            tgDTO.MaTG = txtMaTG.Text;
            tgDTO.TenTG = txtTenTG.Text;
            tgDTO.TieuSu = txTieuSuTG.Text;

            TacGia_BO tgBO = new TacGia_BO();
            int result = 0;
            result = tgBO.Sua(tgDTO);
            if (result > 0)
            {
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void dgTacGia_DoubleClick(object sender, EventArgs e)
        {
            txtMaTG.Text = dgTacGia.CurrentRow.Cells[0].Value.ToString();
            txtTenTG.Text = dgTacGia.CurrentRow.Cells[1].Value.ToString();
            txTieuSuTG.Text = dgTacGia.CurrentRow.Cells[2].Value.ToString();
        }

        private void UCTacGia_Load(object sender, EventArgs e)
        {
            DataTable tb;
            TacGia_BO tgBO = new TacGia_BO();
            tb = tgBO.DS();
            dgTacGia.DataSource = tb;
        }
    }
}
