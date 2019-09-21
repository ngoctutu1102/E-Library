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
    public partial class UCEbook : UserControl
    {
        public UCEbook()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtImageEbook.Text = dialog.FileName.ToString();
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PDF|*.pdf";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtPDFEbook.Text = dialog.FileName.ToString();

            }
        }

        private void UCEbook_Load(object sender, EventArgs e)
        {
            DataTable tb;
            EBook_BO ebookBO = new EBook_BO();
            tb = ebookBO.DS();
            dgEbook.DataSource = tb;
        }

        private void btnThemE_Click(object sender, EventArgs e)
        {
            EBook_DTO ebookDTO = new EBook_DTO();
            ebookDTO.MaEbook = txtMaEbook.Text;
            ebookDTO.TenSach = txtTenSach.Text;
            ebookDTO.MaTG = txtMaTGEbook.Text;
            ebookDTO.MaTL = txtMaTLEbook.Text;
            ebookDTO.MaNXB = txtMaNXBEbook.Text;
            ebookDTO.NamXB = txtNamXBEbook.Text;
            ebookDTO.FilePDF = txtPDFEbook.Text;
            ebookDTO.HinhAnh = txtImageEbook.Text;
            ebookDTO.DinhDang = txtDinhDang.Text;
            ebookDTO.DungLuong = txtDungLuong.Text;
            
            EBook_BO ebookBO = new EBook_BO();
            int result = 0;
            result = ebookBO.Them(ebookDTO);
            if (result > 0)
            {
                MessageBox.Show("Thêm thông tin thành công");

            }
            else
            {
                MessageBox.Show("Thông tin này đã tồn tại!");
            }
        }

        private void btnXoaE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string MaEbook;

                MaEbook = txtMaEbook.Text;
                EBook_BO ebookBO = new EBook_BO();
                int result = ebookBO.Xoa(MaEbook);
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

        private void btnSuaE_Click(object sender, EventArgs e)
        {
            EBook_DTO ebookDTO = new EBook_DTO();
            ebookDTO.MaEbook = txtMaEbook.Text;
            ebookDTO.TenSach = txtTenSach.Text;
            ebookDTO.MaTG = txtMaTGEbook.Text;
            ebookDTO.MaTL = txtMaTLEbook.Text;
            ebookDTO.MaNXB = txtMaNXBEbook.Text;
            ebookDTO.NamXB = txtNamXBEbook.Text;
            ebookDTO.FilePDF = txtPDFEbook.Text;
            ebookDTO.HinhAnh = txtImageEbook.Text;
            ebookDTO.DinhDang = txtDinhDang.Text;
            ebookDTO.DungLuong = txtDungLuong.Text;

            EBook_BO ebookBO = new EBook_BO();
            int result = 0;
            result = ebookBO.Sua(ebookDTO);
            if (result > 0)
            {
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void dgEbook_DoubleClick(object sender, EventArgs e)
        {
           
            txtMaEbook.Text = dgEbook.CurrentRow.Cells[0].Value.ToString();
            txtTenSach.Text = dgEbook.CurrentRow.Cells[1].Value.ToString();
            txtMaTGEbook.Text = dgEbook.CurrentRow.Cells[2].Value.ToString();
            txtMaTLEbook.Text = dgEbook.CurrentRow.Cells[3].Value.ToString();
            txtMaNXBEbook.Text = dgEbook.CurrentRow.Cells[4].Value.ToString();
            txtNamXBEbook.Text = dgEbook.CurrentRow.Cells[5].Value.ToString();
            txtPDFEbook.Text = dgEbook.CurrentRow.Cells[6].Value.ToString();
            txtImageEbook.Text = dgEbook.CurrentRow.Cells[9].Value.ToString();
            txtDinhDang.Text = dgEbook.CurrentRow.Cells[7].Value.ToString();
            txtDungLuong.Text = dgEbook.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
