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
    public partial class FDocSach : Form
    {
        public FDocSach()
        {
            InitializeComponent();
        }
        private string filePDF; 
        public string FilePDF
        {
            get
            {
                return filePDF;
            }
            set
            {
                filePDF = value;
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            FUserEbook f3 = new FUserEbook();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }

        private void FDocSach_Load(object sender, EventArgs e)
        {

            axAcroPDF1.src = FilePDF;
            
            
        }
    }
}
