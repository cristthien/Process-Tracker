using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAT;
using Guna.UI2.WinForms;

namespace trelloclone
{
    public partial class Login : Form
    {
        Guna2Panel signInPnl;
        Guna2Panel signUpPnl;
        public static int userID;

        Guna2TextBox userName1, userName2;
        Guna2PictureBox picture1, picture2, picture3, picture4, picture5;
        Guna2TextBox password1, password2, password3;
        Guna2Button btnSignUp, btnSignIn;

        DBController dbctrl = new DBController();


        public Login()
        {
            InitializeComponent();
            signInPnl = new Guna2Panel();
            signUpPnl = new Guna2Panel();

            signUpPnl.FillColor = Color.WhiteSmoke;
            signUpPnl.Location = new Point(73, 170);
            signUpPnl.Size = new Size(213, 190);

            userName1 = new Guna2TextBox()
            {
                PlaceholderText = "Tên người dùng",
                Location = new Point(50, 20),
                Size = new Size(140, 25),
                BorderThickness = 0,
            };
            signUpPnl.Controls.Add(userName1);
            picture1 = new Guna2PictureBox()
            {
                Image = Image.FromFile(Application.StartupPath + "/Resources/user.png"),
                Location = new Point(20, 20),
                Size = new Size(22, 22),
                FillColor = Color.Transparent,
            };
            signUpPnl.Controls.Add(picture1);
            password1 = new Guna2TextBox()
            {
                PlaceholderText = "Mật khẩu",
                Location = new Point(50, 60),
                Size = new Size(140, 25),
                BorderThickness = 0,
            };
            signUpPnl.Controls.Add(password1);
            picture2 = new Guna2PictureBox()
            {
                Image = Image.FromFile(Application.StartupPath + "/Resources/key.png"),
                Location = new Point(20, 60),
                Size = new Size(22, 22),
                FillColor = Color.Transparent,
            };
            signUpPnl.Controls.Add(picture2);
            password2 = new Guna2TextBox()
            {
                PlaceholderText = "Nhập lại mật khẩu",
                Location = new Point(50, 100),
                Size = new Size(140, 25),
                BorderThickness = 0,
            };
            signUpPnl.Controls.Add(password2);
            picture3 = new Guna2PictureBox()
            {
                Image = Image.FromFile(Application.StartupPath + "/Resources/key.png"),
                Location = new Point(20, 100),
                Size = new Size(22, 22),
                FillColor = Color.Transparent,
            };
            signUpPnl.Controls.Add(picture3);
            btnSignUp = new Guna2Button()
            {
                Text = "Đăng ký",
                Location = new Point(50, 140),
                Size= new Size(100, 20),
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                FillColor = Color.White,
                BorderRadius = 7,
            };
            signUpPnl.Controls.Add(btnSignUp);
            
            

            signInPnl.FillColor = Color.WhiteSmoke;
            signInPnl.Location = new Point(73, 170);
            signInPnl.Size = new Size(213, 150);

            userName2 = new Guna2TextBox()
            {
                PlaceholderText = "Tên người dùng",
                Location = new Point(50, 20),
                Size = new Size(140, 25),
                BorderThickness = 0,
            };
            signInPnl.Controls.Add(userName2);
            picture4 = new Guna2PictureBox()
            {
                Image = Image.FromFile(Application.StartupPath + "/Resources/user.png"),
                Location = new Point(20, 20),
                Size = new Size(22, 22),
                FillColor = Color.Transparent,
            };
            signInPnl.Controls.Add(picture4);
            password3 = new Guna2TextBox()
            {
                PlaceholderText = "Mật khẩu",
                Location = new Point(50, 60),
                Size = new Size(140, 25),
                BorderThickness = 0,
            };
            signInPnl.Controls.Add(password3);
            picture5 = new Guna2PictureBox()
            {
                Image = Image.FromFile(Application.StartupPath + "/Resources/key.png"),
                Location = new Point(20, 60),
                Size = new Size(22, 22),
                FillColor = Color.Transparent,
            };
            signInPnl.Controls.Add (picture5);
            btnSignIn = new Guna2Button()
            {
                Text = "Đăng nhập",
                Location = new Point(50, 100),
                Size = new Size(100, 20),
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                FillColor = Color.White,
                BorderRadius = 7,
            };
            signInPnl.Controls.Add(btnSignIn);
            BackGroundLoginPanel.Controls.Add(signInPnl);
            BackGroundLoginPanel.Controls.Add(btnChoiceForLogin);
            btnChoiceForSignUp.FillColor = Color.White;
            btnChoiceForLogin.FillColor = Color.WhiteSmoke;

            btnChoiceForLogin.Click += BtnChoiceForLogin_Click;
            btnChoiceForSignUp.Click += BtnChoiceForSignUp_Click;
            btnSignUp.Click += BtnSignUp_Click;
            btnSignIn.Click += BtnSignIn_Click;

            
            dbctrl.CreateDatabase();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            if (userName2.Text == "" || password3.Text == "")
                MessageBox.Show("Tên người dùng hoặc mật khẩu không được bỏ trống");
            else
            {
                UserDAT userDAT = new UserDAT();
                if (userDAT.CheckLogin(userName2.Text, password3.Text) > 0)
                {
                    MessageBox.Show("Dang nhap thanh cong");
                    Form1 form1= new Form1();

                    this.Visible = false;
                    userID = userDAT.CheckLogin(userName2.Text, password3.Text);
                    //MessageBox.Show($"{userID}");
                    form1.ShowDialog();             
                }
                else
                    MessageBox.Show("Dang nhap that bai");
            }
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if (userName1.Text == "" || password1.Text == "" || password2.Text == "")
                MessageBox.Show("Tên người dùng hoặc mật khẩu không được bỏ trống");
            else if (password1.Text != password2.Text)
                MessageBox.Show("Mật khẩu nhập lại chưa đúng");
            else if(password1.Text == password2.Text)
            {
                UserDAT userDAT = new UserDAT();
                bool kq = userDAT.Insert(userName1.Text, password1.Text);
                if (kq)
                {
                    MessageBox.Show("Đăng ký thành công. Mời bạn đăng nhập");
                    btnChoiceForLogin.PerformClick();
                }
                else
                    MessageBox.Show($"Tên người dùng đã tồn tại");
            }
            else
            {
                MessageBox.Show("Dang ky khong thanh cong");
            }
        }

        private void BtnChoiceForSignUp_Click(object sender, EventArgs e)
        {
            BackGroundLoginPanel.Controls.Remove(signInPnl);
            BackGroundLoginPanel.Controls.Add(signUpPnl);
            btnChoiceForSignUp.FillColor = Color.WhiteSmoke;
            btnChoiceForLogin.FillColor = Color.White;
        }

        private void BtnChoiceForLogin_Click(object sender, EventArgs e)
        {
            BackGroundLoginPanel.Controls.Remove(signUpPnl);
            BackGroundLoginPanel.Controls.Add(signInPnl);
            btnChoiceForSignUp.FillColor = Color.White;
            btnChoiceForLogin.FillColor = Color.WhiteSmoke;
        }


    }
}

/*
1. anhtuan-123123123
2. anhtuan1-12345

 */