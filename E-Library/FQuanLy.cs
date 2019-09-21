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
    public partial class FQuanLy : Form
    {
        public FQuanLy()
        {
            InitializeComponent();
        }
        private string quanly;
        public string QuanLy
        {
            get
            {
                return quanly;
            }
            set
            {
                quanly = value;
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            lblTenQL.Text = QuanLy;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnF4.Controls.Clear();

            pnF4.Controls.Add(new UCNXB());
        }

        

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            pnF4.Controls.Clear();

            pnF4.Controls.Add(new UCTacGia());
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            pnF4.Controls.Clear();

            pnF4.Controls.Add(new UCTheLoai());
        }

        private void btnEbook_Click(object sender, EventArgs e)
        {
            pnF4.Controls.Clear();

            pnF4.Controls.Add(new UCEbook());
        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            pnF4.Controls.Clear();

            pnF4.Controls.Add(new UCAudio());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
