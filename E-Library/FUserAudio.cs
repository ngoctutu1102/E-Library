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
    public partial class FUserAudio : Form
    {
        public FUserAudio()
        {
            InitializeComponent();
            pnlAudio_User.Visible = false;
        }
        
        private void btnVHAudio_Click(object sender, EventArgs e)
        {
            pnlAudio_User.Visible = true;
            DataTable tb;
            Audio_BO audioBO = new Audio_BO();
            tb = audioBO.DSTheLoai("TL01");
            dgAudioUser.DataSource = tb;
        }

        private void btnKTAudio_Click(object sender, EventArgs e)
        {
            pnlAudio_User.Visible = true;
            DataTable tb;
            Audio_BO audioBO = new Audio_BO();
            tb = audioBO.DSTheLoai("TL02");
            dgAudioUser.DataSource = tb;
        }

        private void btnNgoaiNguAudio_Click(object sender, EventArgs e)
        {
            pnlAudio_User.Visible = true;
            DataTable tb;
            Audio_BO audioBO = new Audio_BO();
            tb = audioBO.DSTheLoai("TL03");
            dgAudioUser.DataSource = tb;
        }

        private void btnChuyenNganhAudio_Click(object sender, EventArgs e)
        {
            pnlAudio_User.Visible = true;
            DataTable tb;
            Audio_BO audioBO = new Audio_BO();
            tb = audioBO.DSTheLoai("TL04");
            dgAudioUser.DataSource = tb;
        }

        private void btnKyNangAudio_Click(object sender, EventArgs e)
        {
            pnlAudio_User.Visible = true;
            DataTable tb;
            Audio_BO audioBO = new Audio_BO();
            tb = audioBO.DSTheLoai("TL05");
            dgAudioUser.DataSource = tb;
        }

        private void btnThieuNhiAudio_Click(object sender, EventArgs e)
        {
            pnlAudio_User.Visible = true;
            DataTable tb;
            Audio_BO audioBO = new Audio_BO();
            tb = audioBO.DSTheLoai("TL06");
            dgAudioUser.DataSource = tb;
        }

        private void btnVH_NTAudio_Click(object sender, EventArgs e)
        {
            pnlAudio_User.Visible = true;
            DataTable tb;
            Audio_BO audioBO = new Audio_BO();
            tb = audioBO.DSTheLoai("TL07");
            dgAudioUser.DataSource = tb;
        }

        private void btnTruyenTranhAudio_Click(object sender, EventArgs e)
        {
            pnlAudio_User.Visible = true;
            DataTable tb;
            Audio_BO audioBO = new Audio_BO();
            tb = audioBO.DSTheLoai("TL08");
            dgAudioUser.DataSource = tb;
        }

        private void dgAudioUser_DoubleClick(object sender, EventArgs e)
        {
            
            lblTenSach.Text = dgAudioUser.CurrentRow.Cells[0].Value.ToString();
            txtNamXBA.Text = dgAudioUser.CurrentRow.Cells[1].Value.ToString();
            txtTGA.Text = dgAudioUser.CurrentRow.Cells[2].Value.ToString();
            txtTLA.Text = dgAudioUser.CurrentRow.Cells[3].Value.ToString();
            txtNXBA.Text = dgAudioUser.CurrentRow.Cells[4].Value.ToString();
            pbAbook.Image = new Bitmap(dgAudioUser.CurrentRow.Cells[5].Value.ToString());
            pbAbook.SizeMode = PictureBoxSizeMode.StretchImage;
            textBox1.Text = dgAudioUser.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnNghe_Click(object sender, EventArgs e)
        {
            FNgheSach Fnghesach = new FNgheSach();
            Fnghesach.FileMP3 = textBox1.Text;
            this.Hide();
            Fnghesach.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FManHinhChinh f2 = new FManHinhChinh();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void btnTimKiemA_Click(object sender, EventArgs e)
        {
            pnlAudio_User.Visible = true;
            DataTable tb;
            Audio_BO audioBO = new Audio_BO();
            tb = audioBO.TimKiem(txtTimKiemA.Text);
            dgAudioUser.DataSource = tb;
        }
    }
}
