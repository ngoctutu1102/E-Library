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
    public partial class FManHinhChinh : Form
    {
        public FManHinhChinh()
        {
            InitializeComponent();
        }

        private void btnEbookF1_Click(object sender, EventArgs e)
        {
            FUserEbook F3 = new FUserEbook();  
            this.Hide();
            F3.ShowDialog();
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FDangNhap fDangNhap = new FDangNhap();
            this.Hide();
            fDangNhap.ShowDialog();
            this.Close();
        }

        private void btnThoatF2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAudioF2_Click(object sender, EventArgs e)
        {
            FUserAudio fAudio = new FUserAudio();
            this.Hide();
            fAudio.ShowDialog();
            this.Close();
        }
    }
}
