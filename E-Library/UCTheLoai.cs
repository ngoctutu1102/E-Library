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
    public partial class UCTheLoai : UserControl
    {
        public UCTheLoai()
        {
            InitializeComponent();
        }

        private void UCTheLoai_Load(object sender, EventArgs e)
        {
            DataTable tb;
            TheLoai_BO tlBO = new TheLoai_BO();
            tb = tlBO.DS();
            dgTheLoai.DataSource = tb;
        }

        private void btnSuaTL_Click(object sender, EventArgs e)
        {

            TheLoai_DTO thDTO = new TheLoai_DTO();
            thDTO.MaTL = txtMaTL.Text;
            thDTO.TenTL = txtTenTL.Text;

            TheLoai_BO tlBO = new TheLoai_BO();
            int result = 0;
            result = tlBO.Sua(thDTO);
            if (result > 0)
            {
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnXoaTL_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string MaTL;

                MaTL = txtMaTL.Text;
                TheLoai_BO tlBO = new TheLoai_BO();
                int result = tlBO.Xoa(MaTL);
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

        private void btnThemTL_Click(object sender, EventArgs e)
        {
            TheLoai_DTO thDTO = new TheLoai_DTO();
            thDTO.MaTL = txtMaTL.Text;
            thDTO.TenTL = txtTenTL.Text;
            TheLoai_BO tlBO = new TheLoai_BO();
            int result = 0;
            result = tlBO.Them(thDTO);
            if (result > 0)
            {
                MessageBox.Show("Thêm thông tin thành công");

            }
            else
            {
                MessageBox.Show("Thông tin này đã tồn tại!");
            }
        }

        private void dgTheLoai_DoubleClick(object sender, EventArgs e)
        {
            txtMaTL.Text = dgTheLoai.CurrentRow.Cells[0].Value.ToString();
            txtTenTL.Text = dgTheLoai.CurrentRow.Cells[1].Value.ToString();
            
        }
    }
}
