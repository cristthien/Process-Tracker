namespace WindowsFormsApp1
{
    partial class Card
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Card));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rTxtBxTitle = new System.Windows.Forms.RichTextBox();
            this.pnlMoTa = new System.Windows.Forms.Panel();
            this.tbxThemMoTaChiTiet = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHoatDong = new System.Windows.Forms.Panel();
            this.tbxVietBinhLuan = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFunctions = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTaoMau = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaoChep = new Guna.UI2.WinForms.Guna2Button();
            this.btnDiChuyen = new Guna.UI2.WinForms.Guna2Button();
            this.btnViecCanLam = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhan = new Guna.UI2.WinForms.Guna2Button();
            this.btnThanhVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnDeleteCard = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlMoTa.SuspendLayout();
            this.pnlHoatDong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.pnlFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.pnlMoTa);
            this.pnlMain.Controls.Add(this.pnlHoatDong);
            this.pnlMain.Controls.Add(this.pnlFunctions);
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(482, 586);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rTxtBxTitle);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 57);
            this.panel1.TabIndex = 36;
            // 
            // rTxtBxTitle
            // 
            this.rTxtBxTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rTxtBxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTxtBxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtBxTitle.Location = new System.Drawing.Point(6, 6);
            this.rTxtBxTitle.Name = "rTxtBxTitle";
            this.rTxtBxTitle.Size = new System.Drawing.Size(444, 51);
            this.rTxtBxTitle.TabIndex = 0;
            this.rTxtBxTitle.Text = "";
            this.rTxtBxTitle.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // pnlMoTa
            // 
            this.pnlMoTa.Controls.Add(this.tbxThemMoTaChiTiet);
            this.pnlMoTa.Controls.Add(this.label8);
            this.pnlMoTa.Controls.Add(this.label2);
            this.pnlMoTa.Location = new System.Drawing.Point(12, 119);
            this.pnlMoTa.Name = "pnlMoTa";
            this.pnlMoTa.Size = new System.Drawing.Size(458, 75);
            this.pnlMoTa.TabIndex = 35;
            // 
            // tbxThemMoTaChiTiet
            // 
            this.tbxThemMoTaChiTiet.BorderRadius = 5;
            this.tbxThemMoTaChiTiet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxThemMoTaChiTiet.DefaultText = "";
            this.tbxThemMoTaChiTiet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxThemMoTaChiTiet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxThemMoTaChiTiet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxThemMoTaChiTiet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxThemMoTaChiTiet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxThemMoTaChiTiet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxThemMoTaChiTiet.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxThemMoTaChiTiet.Location = new System.Drawing.Point(35, 27);
            this.tbxThemMoTaChiTiet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxThemMoTaChiTiet.Multiline = true;
            this.tbxThemMoTaChiTiet.Name = "tbxThemMoTaChiTiet";
            this.tbxThemMoTaChiTiet.PasswordChar = '\0';
            this.tbxThemMoTaChiTiet.PlaceholderText = "Thêm mô tả ...";
            this.tbxThemMoTaChiTiet.SelectedText = "";
            this.tbxThemMoTaChiTiet.Size = new System.Drawing.Size(419, 43);
            this.tbxThemMoTaChiTiet.TabIndex = 31;
            this.tbxThemMoTaChiTiet.TextChanged += new System.EventHandler(this.tbxThemMoTaChiTiet_TextChanged);
            this.tbxThemMoTaChiTiet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxThemMoTaChiTiet_MouseClick);
            // 
            // label8
            // 
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(6, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 22);
            this.label8.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mô tả";
            // 
            // pnlHoatDong
            // 
            this.pnlHoatDong.Controls.Add(this.tbxVietBinhLuan);
            this.pnlHoatDong.Controls.Add(this.guna2CirclePictureBox1);
            this.pnlHoatDong.Controls.Add(this.label5);
            this.pnlHoatDong.Controls.Add(this.label1);
            this.pnlHoatDong.Location = new System.Drawing.Point(12, 226);
            this.pnlHoatDong.Name = "pnlHoatDong";
            this.pnlHoatDong.Size = new System.Drawing.Size(458, 77);
            this.pnlHoatDong.TabIndex = 34;
            // 
            // tbxVietBinhLuan
            // 
            this.tbxVietBinhLuan.BorderRadius = 5;
            this.tbxVietBinhLuan.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.tbxVietBinhLuan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxVietBinhLuan.DefaultText = "";
            this.tbxVietBinhLuan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxVietBinhLuan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxVietBinhLuan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxVietBinhLuan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxVietBinhLuan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxVietBinhLuan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxVietBinhLuan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxVietBinhLuan.Location = new System.Drawing.Point(41, 29);
            this.tbxVietBinhLuan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxVietBinhLuan.Multiline = true;
            this.tbxVietBinhLuan.Name = "tbxVietBinhLuan";
            this.tbxVietBinhLuan.PasswordChar = '\0';
            this.tbxVietBinhLuan.PlaceholderText = "Thêm hoạt động ...";
            this.tbxVietBinhLuan.SelectedText = "";
            this.tbxVietBinhLuan.Size = new System.Drawing.Size(413, 41);
            this.tbxVietBinhLuan.TabIndex = 30;
            this.tbxVietBinhLuan.TextChanged += new System.EventHandler(this.tbxVietBinhLuan_TextChanged);
            this.tbxVietBinhLuan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxVietBinhLuan_MouseClick);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(5, 32);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(30, 30);
            this.guna2CirclePictureBox1.TabIndex = 29;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(5, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 22);
            this.label5.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hoạt động";
            // 
            // pnlFunctions
            // 
            this.pnlFunctions.Controls.Add(this.btnDeleteCard);
            this.pnlFunctions.Controls.Add(this.label7);
            this.pnlFunctions.Controls.Add(this.label6);
            this.pnlFunctions.Controls.Add(this.btnTaoMau);
            this.pnlFunctions.Controls.Add(this.btnSaoChep);
            this.pnlFunctions.Controls.Add(this.btnDiChuyen);
            this.pnlFunctions.Controls.Add(this.btnViecCanLam);
            this.pnlFunctions.Controls.Add(this.btnNhan);
            this.pnlFunctions.Controls.Add(this.btnThanhVien);
            this.pnlFunctions.Location = new System.Drawing.Point(12, 332);
            this.pnlFunctions.Name = "pnlFunctions";
            this.pnlFunctions.Size = new System.Drawing.Size(458, 242);
            this.pnlFunctions.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(270, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "Thao tác";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Thêm vào thẻ";
            // 
            // btnTaoMau
            // 
            this.btnTaoMau.BorderRadius = 5;
            this.btnTaoMau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoMau.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaoMau.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaoMau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaoMau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaoMau.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTaoMau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTaoMau.ForeColor = System.Drawing.Color.Black;
            this.btnTaoMau.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoMau.Image")));
            this.btnTaoMau.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTaoMau.Location = new System.Drawing.Point(270, 150);
            this.btnTaoMau.Name = "btnTaoMau";
            this.btnTaoMau.Size = new System.Drawing.Size(170, 40);
            this.btnTaoMau.TabIndex = 22;
            this.btnTaoMau.Text = "Tạo mẫu";
            // 
            // btnSaoChep
            // 
            this.btnSaoChep.BorderRadius = 5;
            this.btnSaoChep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaoChep.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaoChep.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaoChep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaoChep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaoChep.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaoChep.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaoChep.ForeColor = System.Drawing.Color.Black;
            this.btnSaoChep.Image = ((System.Drawing.Image)(resources.GetObject("btnSaoChep.Image")));
            this.btnSaoChep.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSaoChep.Location = new System.Drawing.Point(270, 98);
            this.btnSaoChep.Name = "btnSaoChep";
            this.btnSaoChep.Size = new System.Drawing.Size(170, 40);
            this.btnSaoChep.TabIndex = 21;
            this.btnSaoChep.Text = "Sao chép";
            // 
            // btnDiChuyen
            // 
            this.btnDiChuyen.BorderRadius = 5;
            this.btnDiChuyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiChuyen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDiChuyen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDiChuyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDiChuyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDiChuyen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDiChuyen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDiChuyen.ForeColor = System.Drawing.Color.Black;
            this.btnDiChuyen.Image = ((System.Drawing.Image)(resources.GetObject("btnDiChuyen.Image")));
            this.btnDiChuyen.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDiChuyen.Location = new System.Drawing.Point(270, 46);
            this.btnDiChuyen.Name = "btnDiChuyen";
            this.btnDiChuyen.Size = new System.Drawing.Size(170, 40);
            this.btnDiChuyen.TabIndex = 20;
            this.btnDiChuyen.Text = "Di chuyển";
            // 
            // btnViecCanLam
            // 
            this.btnViecCanLam.BorderRadius = 5;
            this.btnViecCanLam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViecCanLam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViecCanLam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViecCanLam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViecCanLam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViecCanLam.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnViecCanLam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnViecCanLam.ForeColor = System.Drawing.Color.Black;
            this.btnViecCanLam.Image = ((System.Drawing.Image)(resources.GetObject("btnViecCanLam.Image")));
            this.btnViecCanLam.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViecCanLam.Location = new System.Drawing.Point(17, 152);
            this.btnViecCanLam.Name = "btnViecCanLam";
            this.btnViecCanLam.Size = new System.Drawing.Size(197, 45);
            this.btnViecCanLam.TabIndex = 19;
            this.btnViecCanLam.Text = "Việc cần làm";
            // 
            // btnNhan
            // 
            this.btnNhan.BorderRadius = 5;
            this.btnNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNhan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNhan.ForeColor = System.Drawing.Color.Black;
            this.btnNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnNhan.Image")));
            this.btnNhan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhan.Location = new System.Drawing.Point(17, 98);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(197, 45);
            this.btnNhan.TabIndex = 18;
            this.btnNhan.Text = "Nhãn";
            this.btnNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnThanhVien
            // 
            this.btnThanhVien.BackColor = System.Drawing.Color.Transparent;
            this.btnThanhVien.BorderRadius = 5;
            this.btnThanhVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThanhVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhVien.ForeColor = System.Drawing.Color.Black;
            this.btnThanhVien.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhVien.Image")));
            this.btnThanhVien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThanhVien.Location = new System.Drawing.Point(17, 41);
            this.btnThanhVien.Name = "btnThanhVien";
            this.btnThanhVien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThanhVien.Size = new System.Drawing.Size(197, 45);
            this.btnThanhVien.TabIndex = 17;
            this.btnThanhVien.Text = "Thành viên";
            this.btnThanhVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThanhVien.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(452, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 28);
            this.btnClose.TabIndex = 32;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnDeleteCard
            // 
            this.btnDeleteCard.BorderRadius = 5;
            this.btnDeleteCard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteCard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteCard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteCard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteCard.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteCard.Location = new System.Drawing.Point(359, 208);
            this.btnDeleteCard.Name = "btnDeleteCard";
            this.btnDeleteCard.Size = new System.Drawing.Size(81, 22);
            this.btnDeleteCard.TabIndex = 26;
            this.btnDeleteCard.Text = "Xóa thẻ";
            this.btnDeleteCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteCard.Click += new System.EventHandler(this.btnDeleteCard_Click);
            // 
            // Card
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btnClose;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(482, 586);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Card";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoryCard";
            this.pnlMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlMoTa.ResumeLayout(false);
            this.pnlMoTa.PerformLayout();
            this.pnlHoatDong.ResumeLayout(false);
            this.pnlHoatDong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.pnlFunctions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox tbxVietBinhLuan;
        private Guna.UI2.WinForms.Guna2TextBox tbxThemMoTaChiTiet;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Panel pnlFunctions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnTaoMau;
        private Guna.UI2.WinForms.Guna2Button btnSaoChep;
        private Guna.UI2.WinForms.Guna2Button btnDiChuyen;
        private Guna.UI2.WinForms.Guna2Button btnViecCanLam;
        private Guna.UI2.WinForms.Guna2Button btnNhan;
        private Guna.UI2.WinForms.Guna2Button btnThanhVien;
        private System.Windows.Forms.Panel pnlHoatDong;
        private System.Windows.Forms.Panel pnlMoTa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rTxtBxTitle;
        private Guna.UI2.WinForms.Guna2Button btnDeleteCard;
    }
}