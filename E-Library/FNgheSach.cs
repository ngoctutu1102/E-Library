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
    public partial class FNgheSach : Form
    {
        public FNgheSach()
        {
            InitializeComponent();
        }

        private string fileMP3;
        public string FileMP3
        {
            get
            {
                return fileMP3;
            }
            set
            {
                fileMP3 = value;
            }
        }
        private void FNgheSach_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = FileMP3;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FUserEbook f3 = new FUserEbook();
            this.Hide();
            axWindowsMediaPlayer1.close();
            f3.ShowDialog();
            this.Close();
            
        }
    }
}
