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
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Regex re = new Regex("[0-9a-zA-Z]+");//Rege re = new Rege ("[0-9a-zA-Z]+);
            if (txtUserName.Text == "")
            {

                MessageBox.Show("Chưa nhập tên đăng nhập!");
                txtUserName.Focus();
                return;

            }
            else
            {
                if (!re.IsMatch(txtUserName.Text))
                {
                    MessageBox.Show("Tên người dùng không hợp lệ.");
                    txtUserName.Focus();
                    return;
                }
            }
            if (txtPassWord.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu!");
                txtPassWord.Focus();
                return;


            }
            else
            {
                if (!re.IsMatch(txtPassWord.Text))
                {
                    MessageBox.Show("Mật khẩu không hợp lệ!");
                    txtPassWord.Clear();
                    txtPassWord.Focus();
                    return;
                }
            }

            DangNhap_BO dangnhapBO = new DangNhap_BO(); //Khai báo class BO
            DataTable Table = new DataTable();//Đưa dữ liệu vô bảng này
            DangNhap_DTO dangnhapDTO = new DangNhap_DTO();
            dangnhapDTO.TenDN = txtUserName.Text;
            dangnhapDTO.MatKhau = txtPassWord.Text;
            Table = dangnhapBO.DangNhap(dangnhapDTO); //Dữ liệu được Đưa vào bảng

            if (Table != null) //kiểm tra xem có đổ dữ liệu thành công không?
            {
                if (Table.Rows.Count > 0) //kiểm tra xem bảng có giá trị không?
                {
                   
                    FQuanLy F4 = new FQuanLy();
                    F4.QuanLy = Table.Rows[0][0].ToString();
                    this.Hide();
                    F4.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bạn nhập sai tên đăng nhập hoặc mật khẩu");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FManHinhChinh f2 = new FManHinhChinh();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
