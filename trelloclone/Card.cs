using DAT;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trelloclone;

namespace WindowsFormsApp1
{
    public partial class Card : Form
    {
        private AppData appData;
        private bool modified;
        private bool existed;
        private bool moveToLeft;
        private bool moveToRight;
        private bool moveUp;
        private bool moveDown;
        private bool copyCard;
        Guna2Panel pnlMovingFunction = new Guna2Panel();
        int userID;
        int cardID;
        int listCardID;

        bool isResize1 = true;
        bool isResize2 = true;
        bool onSizeBox1 = false;
        bool onSizeBox2 = false;

        Size originalSizeOf_tbxThemMoTaChiTiet, originalSizeOf_tbxVietBinhLuan;
        Size originalSizeOf_pnl_HoatDong, originalSizeOf_pnl_MoTa;
        Point originalPointOf_pnl_HoatDong;


        internal AppData AppData { get => appData; set => appData = value; }
        public bool Modified { get => modified; set => modified = value; }
        public bool Existed { get => existed; set => existed = value; }
        public bool MoveToLeft { get => moveToLeft; set => moveToLeft = value; }
        public bool MoveToRight { get => moveToRight; set => moveToRight = value; }
        public bool MoveUp { get => moveUp; set => moveUp = value; }
        public bool MoveDown { get => moveDown; set => moveDown = value; }
        public int CardID { get => cardID; set => cardID = value; }

        public Card(AppData passInData)
        {
            InitializeComponent();
            appData = passInData;
            rTxtBxTitle.Text = passInData.Title;
            tbxThemMoTaChiTiet.Text = passInData.DescribeContent;
            tbxVietBinhLuan.Text = passInData.ActivityContent;
            existed = true;
            pnlMovingFunction.Visible = false;

            rTxtBxTitle.TextChanged += richTextBox1_TextChanged;
            tbxThemMoTaChiTiet.MouseClick += tbxThemMoTaChiTiet_MouseClick;
            tbxThemMoTaChiTiet.TextChanged += tbxThemMoTaChiTiet_TextChanged;
            tbxVietBinhLuan.MouseClick += tbxVietBinhLuan_MouseClick;
            tbxVietBinhLuan.TextChanged += tbxVietBinhLuan_TextChanged;
            pnlMain.MouseDown += panel1_MouseDown;
            btnDiChuyen.Click += btnDiChuyen_Click;

            Modified = true;
            moveToLeft = false;
            moveToRight = false;
            moveUp = false;
            moveDown = false;

            copyCard = false;
        }
        private void btnDeleteCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"delete card {CardID}");
            existed = false;
            appData.Existed = false;
            this.Visible = false;
            CardDAT cardDAT = new CardDAT();
            cardDAT.DeletebyID(CardID);
            
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show($"Update title at {CardID}");
            AppData.Title = rTxtBxTitle.Text;
            CardDAT.UpdateTittle(CardID, rTxtBxTitle.Text);
        }

        private void tbxThemMoTaChiTiet_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show($"Update description at {CardID}");
            AppData.DescribeContent = tbxThemMoTaChiTiet.Text;
            CardDAT.UpdateDescription(CardID, tbxThemMoTaChiTiet.Text);
        }

        private void tbxVietBinhLuan_TextChanged(object sender, EventArgs e)
        {
            AppData.ActivityContent = tbxVietBinhLuan.Text;
            CardDAT.UpdateActivity(CardID, tbxVietBinhLuan.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            appData.Title = rTxtBxTitle.Text;
            appData.DescribeContent = tbxThemMoTaChiTiet.Text;
            appData.ActivityContent = tbxVietBinhLuan.Text;
            //this.Close();
            this.Visible=false;
        }


        private void tbxThemMoTaChiTiet_MouseClick(object sender, MouseEventArgs e)
        {
            originalSizeOf_tbxThemMoTaChiTiet = new System.Drawing.Size(tbxThemMoTaChiTiet.Width, tbxThemMoTaChiTiet.Height);
            originalSizeOf_pnl_MoTa = new System.Drawing.Size(pnlMoTa.Width, pnlMoTa.Height);
            originalPointOf_pnl_HoatDong = new System.Drawing.Point(pnlHoatDong.Location.X, pnlHoatDong.Location.Y);
            onSizeBox1 = true;

            Resize();
        }

        private void tbxVietBinhLuan_MouseClick(object sender, MouseEventArgs e)
        {
            originalSizeOf_tbxVietBinhLuan = new System.Drawing.Size(tbxVietBinhLuan.Width, tbxVietBinhLuan.Height);
            originalSizeOf_pnl_HoatDong = new System.Drawing.Size(pnlHoatDong.Width, pnlHoatDong.Height);
            onSizeBox2 = true;

            Resize();
        }

        private void Resize()
        {
            if (isResize1 && onSizeBox1 == true)
            {
                resize_textBox(true, false, true, false);
                pnlFunctions.Hide();
                isResize1 = false;
            }
            else if (isResize2 && onSizeBox2 == true)
            {
                resize_textBox(false, true, true, false);
                pnlFunctions.Hide();
                isResize2 = false;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            if (isResize1 == false && onSizeBox1 == true)
            {
                resize_textBox(true, false, false, true);
                isResize1 = true;
                pnlFunctions.Show();
                onSizeBox1 = false;
            }
            else if (isResize2 == false && onSizeBox2 == true)
            {
                resize_textBox(false, true, false, true);
                isResize2 = true;
                pnlFunctions.Show();
                onSizeBox2 = false;
            }
        }

        private void btnDiChuyen_Click(object sender, EventArgs e)
        {
            if (pnlMovingFunction.Visible == true)
            {
                pnlMovingFunction.Visible = false;
                btnSaoChep.Location = new Point(btnSaoChep.Location.X - 110,
                    btnSaoChep.Location.Y);
                btnTaoMau.Location = new Point(btnTaoMau.Location.X - 110,
                    btnTaoMau.Location.Y);
            }
            else
            {
                btnSaoChep.Location = new Point(btnSaoChep.Location.X + 110,
                    btnSaoChep.Location.Y);
                btnTaoMau.Location = new Point(btnTaoMau.Location.X + 110,
                    btnTaoMau.Location.Y);
                pnlMovingFunction.Visible = true;

                pnlMovingFunction.BorderRadius = 5;
                pnlMovingFunction.FillColor = Color.Transparent;
                pnlFunctions.Controls.Add(pnlMovingFunction);
                pnlMovingFunction.Size = new Size(90, 90);
                pnlMovingFunction.Location = new Point(215, 75);
                pnlMovingFunction.BorderColor = Color.Black;

                Guna2Button btnToLeft = new Guna2Button();
                Guna2Button btnToRight = new Guna2Button();
                Guna2Button btnGoUp = new Guna2Button();
                Guna2Button btnGoDown = new Guna2Button();

                pnlMovingFunction.Controls.Add(btnToLeft);
                pnlMovingFunction.Controls.Add(btnToRight);
                pnlMovingFunction.Controls.Add(btnGoDown);
                pnlMovingFunction.Controls.Add(btnGoUp);

                btnToLeft = createBtnToMove(btnToLeft, "Qua trái", Application.StartupPath +
                    "/Resources/backArrow.png");
                btnToRight = createBtnToMove(btnToRight, "Qua phải", Application.StartupPath +
                    "/Resources/forwardArrow.png");
                btnGoUp = createBtnToMove(btnGoUp, "Đi lên", Application.StartupPath +
                    "/Resources/upArrow.png");
                btnGoDown = createBtnToMove(btnGoDown, "Đi xuống", Application.StartupPath +
                    "/Resources/downArrow.png");

                //moving 2 button below
                btnToLeft.Click += BtnToLeft_Click;
                btnToRight.Click += BtnToRight_Click;
                btnGoUp.Click += BtnGoUp_Click;
                btnGoDown.Click += BtnGoDown_Click;

            }
        }
        private void BtnToLeft_Click(object sender, EventArgs e)
        {
            moveToLeft = true;
            pnlMovingFunction.Visible = false;
            btnSaoChep.Location = new Point(btnSaoChep.Location.X - 110,
                btnSaoChep.Location.Y);
            btnTaoMau.Location = new Point(btnTaoMau.Location.X - 110,
                btnTaoMau.Location.Y);
            this.Visible = false;
        }
        private void BtnToRight_Click(object sender, EventArgs e)
        {
            moveToRight = true;
            pnlMovingFunction.Visible = false;
            btnSaoChep.Location = new Point(btnSaoChep.Location.X - 110,
                btnSaoChep.Location.Y);
            btnTaoMau.Location = new Point(btnTaoMau.Location.X - 110,
                btnTaoMau.Location.Y);
            this.Visible = false;
        }
        private void BtnGoUp_Click(object sender, EventArgs e)
        {
            moveUp = true;
            pnlMovingFunction.Visible = false;
            btnSaoChep.Location = new Point(btnSaoChep.Location.X - 110,
                btnSaoChep.Location.Y);
            btnTaoMau.Location = new Point(btnTaoMau.Location.X - 110,
                btnTaoMau.Location.Y);
            this.Visible = false;
        }
        private void BtnGoDown_Click(object sender, EventArgs e)
        {
            moveDown = true;
            pnlMovingFunction.Visible = false;
            btnSaoChep.Location = new Point(btnSaoChep.Location.X - 110,
                btnSaoChep.Location.Y);
            btnTaoMau.Location = new Point(btnTaoMau.Location.X - 110,
                btnTaoMau.Location.Y);
            this.Visible = false;
        }
        private Guna2Button createBtnToMove(Guna2Button btn, string btnName, string ImagePath)
        {
            btn.Size = new Size(80, 20);
            btn.BorderRadius = 5;
            btn.FillColor = Color.FromArgb(224, 224, 224);
            btn.ImageAlign = HorizontalAlignment.Left;
            btn.Image = Image.FromFile(ImagePath);
            if (btnName == "Qua trái")
            {
                btn.Location = new Point(7, 0);
                btn.ImageSize = new Size(10, 10);
                btn.ImageOffset = new Point(-3, btn.ImageOffset.Y);
            }
            else if (btnName == "Qua phải")
            {
                btn.Location = new Point(7, 23);
                btn.ImageSize = new Size(10, 10);
                btn.ImageOffset = new Point(-6, btn.ImageOffset.Y);
                btn.TextAlign = HorizontalAlignment.Left;
                btn.TextOffset = new Point(-10, btn.TextOffset.Y);
            }
            else if (btnName == "Đi lên")
            {
                btn.Location = new Point(7, 46);
                btn.ImageSize = new Size(14, 14);
                btn.ImageOffset = new Point(-9, btn.ImageOffset.Y);
            }
            else if (btnName == "Đi xuống")
            {
                btn.Location = new Point(7, 69);
                btn.ImageSize = new Size(14, 14);
                btn.ImageOffset = new Point(-11, btn.ImageOffset.Y);
            }
            btn.Text = btnName;
            btn.ForeColor = Color.Black;
            return btn;
        }

        private void pnlFunctions_Click(object sender, EventArgs e)
        {

            if (pnlMovingFunction.Visible == true)
            {
                pnlMovingFunction.Visible = false;
                btnSaoChep.Location = new Point(btnSaoChep.Location.X - 110,
                    btnSaoChep.Location.Y);
                btnTaoMau.Location = new Point(btnTaoMau.Location.X - 110,
                    btnTaoMau.Location.Y);
            }
        }

        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            copyCard = true;
            this.Visible = false;
        }

        void resize_textBox(bool txtThemMoTaChiTiet, bool txtVietBinhLuan, bool expand, bool shrink)
        {
            if (txtThemMoTaChiTiet && !txtVietBinhLuan)
            {
                if (expand && !shrink)
                {
                    pnlMoTa.Size = new System.Drawing.Size(pnlMoTa.Width, pnlMoTa.Height + 130);
                    tbxThemMoTaChiTiet.Size = new System.Drawing.Size(tbxThemMoTaChiTiet.Width, tbxThemMoTaChiTiet.Height + 130);
                    pnlHoatDong.Location = new System.Drawing.Point(pnlHoatDong.Location.X, pnlHoatDong.Location.Y + 100);
                }
                else if (!expand && shrink)
                {
                    pnlMoTa.Size = new System.Drawing.Size(originalSizeOf_pnl_MoTa.Width, originalSizeOf_pnl_MoTa.Height - 130);
                    tbxThemMoTaChiTiet.Size = new System.Drawing.Size(originalSizeOf_tbxThemMoTaChiTiet.Width, originalSizeOf_tbxThemMoTaChiTiet.Height - 130);
                    pnlHoatDong.Location = new System.Drawing.Point(originalPointOf_pnl_HoatDong.X, originalPointOf_pnl_HoatDong.Y - 100);
                }
            }
            else if (!txtThemMoTaChiTiet && txtVietBinhLuan)
            {
                if (expand && !shrink)
                {
                    tbxVietBinhLuan.Size = new System.Drawing.Size(tbxVietBinhLuan.Width, tbxVietBinhLuan.Height + 130);
                    pnlHoatDong.Size = new System.Drawing.Size(pnlHoatDong.Width, pnlHoatDong.Height + 130);
                }
                else if (!expand && shrink)
                {
                    tbxVietBinhLuan.Size = new System.Drawing.Size(originalSizeOf_tbxVietBinhLuan.Width, originalSizeOf_tbxVietBinhLuan.Height - 130);
                    pnlHoatDong.Size = new System.Drawing.Size(originalSizeOf_pnl_HoatDong.Width, originalSizeOf_pnl_HoatDong.Height - 130);
                }
            }
        }

        private void SaveDataToFile()
        {
            List<string> lines = new List<string>();

            lines.Add($"Them mo ta chi tiet: {tbxThemMoTaChiTiet.Text}");
            lines.Add($"Viet binh luan: {tbxVietBinhLuan.Text}");

            // Get the current directory of the application.
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Write the string array to a new file named "WriteLines.txt" in the current directory.
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(currentDirectory, $"StoryCard.txt")))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }
        }

    }
}
