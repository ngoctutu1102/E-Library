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
    public partial class UCAudio : UserControl
    {
        public UCAudio()
        {
            InitializeComponent();
        }

        private void btnImageA_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtImageAbook.Text = dialog.FileName.ToString();
            }
        }

        private void btnMP3A_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "mp3 files(*.mp3)|*.mp3|mp4 files(*.mp4)|*.mp4|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtMP3Abook.Text = dialog.FileName.ToString();
                // axWindowsMediaPlayer1.URL = dialog.FileName;
            }
        }

        private void UCAudio_Load(object sender, EventArgs e)
        {
            DataTable tb;
            Audio_BO audioBO = new Audio_BO();
            tb = audioBO.DS();
            dgAudio.DataSource = tb;
        }

        private void btnThemA_Click(object sender, EventArgs e)
        {
            Audio_DTO audioDTO = new Audio_DTO();
            audioDTO.MaAudio = txtMaAudio.Text;
            audioDTO.TenSach = txtTenSachA.Text;
            audioDTO.MaTG = txtMaTGAbook.Text;
            audioDTO.MaTL = txtMaTLAbook.Text;
            audioDTO.MaNXB = txtMaNXBAbook.Text;
            audioDTO.NamXB = txtNamXBAbook.Text;
            audioDTO.FileAudio = txtMP3Abook.Text;
            audioDTO.HinhAnh = txtImageAbook.Text;
            audioDTO.DinhDang = txtDinhDangA.Text;
            audioDTO.DungLuong = txtDungLuongA.Text;
            audioDTO.ThoiLuong = txtThoiLuongAbook.Text;
            audioDTO.MCAudio = txtMCAbook.Text;

            Audio_BO audioBO = new Audio_BO();
            int result = 0;
            result = audioBO.Them(audioDTO);
            if (result > 0)
            {
                MessageBox.Show("Thêm thông tin thành công");


            }
            else
            {
                MessageBox.Show("Thông tin này đã tồn tại!");
            }
        }

        private void btnXoaA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string MaAudio;

                MaAudio = txtMaAudio.Text;
                Audio_BO audioBO = new Audio_BO();
                int result = audioBO.Xoa(MaAudio);
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

        private void btnSuaA_Click(object sender, EventArgs e)
        {
            Audio_DTO audioDTO = new Audio_DTO();
            audioDTO.MaAudio = txtMaAudio.Text;
            audioDTO.TenSach = txtTenSachA.Text;
            audioDTO.MaTG = txtMaTGAbook.Text;
            audioDTO.MaTL = txtMaTLAbook.Text;
            audioDTO.MaNXB = txtMaNXBAbook.Text;
            audioDTO.NamXB = txtNamXBAbook.Text;
            audioDTO.FileAudio = txtMP3Abook.Text;
            audioDTO.HinhAnh = txtImageAbook.Text;
            audioDTO.DinhDang = txtDinhDangA.Text;
            audioDTO.DungLuong = txtDungLuongA.Text;
            audioDTO.ThoiLuong = txtThoiLuongAbook.Text;
            audioDTO.MCAudio = txtMCAbook.Text;

            Audio_BO audioBO = new Audio_BO();
            int result = 0;
            result = audioBO.Sua(audioDTO);
            if (result > 0)
            {
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void dgAudio_DoubleClick(object sender, EventArgs e)
        {
            txtMaAudio.Text = dgAudio.CurrentRow.Cells[0].Value.ToString();
            txtTenSachA.Text = dgAudio.CurrentRow.Cells[1].Value.ToString();
            txtMaTGAbook.Text = dgAudio.CurrentRow.Cells[2].Value.ToString();
            txtMaTLAbook.Text = dgAudio.CurrentRow.Cells[3].Value.ToString();
            txtMaNXBAbook.Text = dgAudio.CurrentRow.Cells[4].Value.ToString();
            txtNamXBAbook.Text = dgAudio.CurrentRow.Cells[5].Value.ToString();
            txtMP3Abook.Text = dgAudio.CurrentRow.Cells[6].Value.ToString();
            txtImageAbook.Text = dgAudio.CurrentRow.Cells[7].Value.ToString();
            txtDinhDangA.Text = dgAudio.CurrentRow.Cells[8].Value.ToString();
            txtDungLuongA.Text = dgAudio.CurrentRow.Cells[9].Value.ToString();
            txtThoiLuongAbook.Text = dgAudio.CurrentRow.Cells[10].Value.ToString();
            txtMCAbook.Text = dgAudio.CurrentRow.Cells[11].Value.ToString();
        }
    }
}
