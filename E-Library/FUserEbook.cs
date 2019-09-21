using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1
{
    public partial class FUserEbook : Form
    {
        public FUserEbook()
        {
            InitializeComponent();
            pnlAudio_User.Visible = false;
        }

        private void btnVH_Click(object sender, EventArgs e)
        {
            pnlAudio_User.Visible = true;
            DataTable tb;
            EBook_BO ebookBO = new EBook_BO();
            tb = ebookBO.DSTheLoai("TL01");
            dgEbookUser.DataSource = tb;

          

        }

        private void btnDocSach_Click(object sender, EventArgs e)
        {
           
            FDocSach Fdosach = new FDocSach();
            Fdosach.FilePDF = textBox1.Text;
            this.Hide();
            Fdosach.ShowDialog();

            
        }

        private void dgEbookUser_DoubleClick(object sender, EventArgs e)
        {
            FDocSach Fdosach = new FDocSach();
            lblTenSach.Text = dgEbookUser.CurrentRow.Cells[0].Value.ToString();
            txtNamXB.Text = dgEbookUser.CurrentRow.Cells[1].Value.ToString();
            txtTG.Text = dgEbookUser.CurrentRow.Cells[2].Value.ToString();
            txtTL.Text = dgEbookUser.CurrentRow.Cells[3].Value.ToString();
            txtNXB.Text = dgEbookUser.CurrentRow.Cells[4].Value.ToString();
            pbEbook.Image = new Bitmap(dgEbookUser.CurrentRow.Cells[5].Value.ToString());
            pbEbook.SizeMode = PictureBoxSizeMode.StretchImage;
            textBox1.Text = dgEbookUser.CurrentRow.Cells[6].Value.ToString();
           
           
        }

        private void btnKT_Click(object sender, EventArgs e)
        {
            pnlAudio_User.Visible = true;
            DataTable tb;
            EBook_BO ebookBO = new EBook_BO();
            tb = ebookBO.DSTheLoai("TL02");
            dgEbookUser.DataSource = tb;
        }

        private void btnNgoaiNgu_Click(object sender, EventArgs e)
        {
            pnlAudio_User.Visible = true;
            DataTable tb;
            EBook_BO ebookBO = new EBook_BO();
            tb = ebookBO.DSTheLoai("TL03");
            dgEbookUser.DataSource = tb;
        }

        private void btnChuyenNganh_Click(object sender, EventArgs e)
        {
            pnlAudio_User.Visible = true;
            DataTable tb;
            EBook_BO ebookBO = new EBook_BO();
            tb = ebookBO.DSTheLoai("TL04");
            dgEbookUser.DataSource = tb;
        }

        private void btnKyNang_Click(object sender, EventArgs e)
        {
            pnlAudio_User.Visible = true;
            DataTable tb;
            EBook_BO ebookBO = new EBook_BO();
            tb = ebookBO.DSTheLoai("TL05");
            dgEbookUser.DataSource = tb;
        }

        private void btnThieuNhi_Click(object sender, EventArgs e)
        {
            pnlAudio_User.Visible = true;
            DataTable tb;
            EBook_BO ebookBO = new EBook_BO();
            tb = ebookBO.DSTheLoai("TL06");
            dgEbookUser.DataSource = tb;
        }

        private void btnVH_NT_Click(object sender, EventArgs e)
        {
            pnlAudio_User.Visible = true;
            DataTable tb;
            EBook_BO ebookBO = new EBook_BO();
            tb = ebookBO.DSTheLoai("TL07");
            dgEbookUser.DataSource = tb;
        }

        private void btnTruyenTranh_Click(object sender, EventArgs e)
        {
            pnlAudio_User.Visible = true;
            DataTable tb;
            EBook_BO ebookBO = new EBook_BO();
            tb = ebookBO.DSTheLoai("TL08");
            dgEbookUser.DataSource = tb;
        }

        private void pnlAudio_User_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTimKiemE_Click(object sender, EventArgs e)
        {
            pnlAudio_User.Visible = true;
            DataTable tb;
            EBook_BO ebookBO = new EBook_BO();
            tb = ebookBO.TimKiem(txtTimKiemE.Text);
            dgEbookUser.DataSource = tb;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FManHinhChinh f2 = new FManHinhChinh();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }
    }
}
