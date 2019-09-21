using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace DoAn1
{
    public partial class UCNXB : UserControl
    {
        public UCNXB()
        {
            InitializeComponent();
        }

       
        private void btnThemNXB_Click(object sender, EventArgs e)
        {
             NXB_DTO nxbDTO = new NXB_DTO();
            nxbDTO.MaNXB = txtMaNXB.Text;
            nxbDTO.TenNXB = txtTenNXB.Text;
            nxbDTO.EmailNXB = txtEmailNXB.Text;
            nxbDTO.ThongTinNXB = txtThongTinNXB.Text;
            NXB_BO nxbBO = new NXB_BO();
            int result = 0;
            result = nxbBO.Them(nxbDTO);
            if (result > 0)
            {
                MessageBox.Show("Thêm thông tin thành công");

            }
            else
            {
                MessageBox.Show("Thông tin này đã tồn tại!");
            }
       
        }

        
        private void btnXoaNXB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string MaNXB;
                
                MaNXB = txtMaNXB.Text;
                NXB_BO nxbBO = new NXB_BO();
                int result = nxbBO.Xoa(MaNXB);
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

        private void btnSuaNXB_Click(object sender, EventArgs e)
        {
            NXB_DTO nxbDTO = new NXB_DTO();
            nxbDTO.MaNXB = txtMaNXB.Text;
            nxbDTO.TenNXB = txtTenNXB.Text;
            nxbDTO.EmailNXB = txtEmailNXB.Text;
            nxbDTO.ThongTinNXB = txtThongTinNXB.Text;
            NXB_BO nxbBO = new NXB_BO();
            int result = 0;
            result = nxbBO.Sua(nxbDTO);
            if (result > 0)
            {
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
       
        }

        private void dgNXB_DoubleClick(object sender, EventArgs e)
        {
            txtMaNXB.Text = dgNXB.CurrentRow.Cells[0].Value.ToString();
            txtTenNXB.Text = dgNXB.CurrentRow.Cells[1].Value.ToString();
            txtEmailNXB.Text = dgNXB.CurrentRow.Cells[2].Value.ToString();
            txtThongTinNXB.Text = dgNXB.CurrentRow.Cells[3].Value.ToString();
        }

        private void UCNXB_Load_1(object sender, EventArgs e)
        {
            DataTable tb;
            NXB_BO nxbBO = new NXB_BO();
            tb = nxbBO.DS();
            dgNXB.DataSource = tb;
        }

        private void dgNXB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
