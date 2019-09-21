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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                rectangleShape2.Width += 3;
                if (rectangleShape2.Width >= 110)
                {
                    timer1.Stop();
                    FManHinhChinh fm2 = new FManHinhChinh();
                    this.Hide();
                    fm2.ShowDialog();
                    this.Close();


                }
            }
            catch (Exception)
            {
                return;
            }
        }

       
    }
}
