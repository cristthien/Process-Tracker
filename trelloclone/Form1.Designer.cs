using Guna.UI2.WinForms;
using System.Windows.Forms;
using ui;

namespace trelloclone
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.WorkSpacePanel = new System.Windows.Forms.Panel();
            this.timerMyTable = new System.Windows.Forms.Timer(this.components);
            this.sizeBar = new System.Windows.Forms.FlowLayoutPanel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.starBtn = new Guna.UI2.WinForms.Guna2Button();
            this.calendarBtn = new Guna.UI2.WinForms.Guna2Button();
            this.alarmBtn = new Guna.UI2.WinForms.Guna2Button();
            this.iconButton = new Guna.UI2.WinForms.Guna2Button();
            this.myTablePanel = new System.Windows.Forms.Panel();
            this.btnFindTable = new Guna.UI2.WinForms.Guna2Button();
            this.myTableButton = new Guna.UI2.WinForms.Guna2Button();
            this.sizeBar.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.myTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkSpacePanel
            // 
            this.WorkSpacePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkSpacePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.WorkSpacePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WorkSpacePanel.Location = new System.Drawing.Point(70, -2);
            this.WorkSpacePanel.Margin = new System.Windows.Forms.Padding(0);
            this.WorkSpacePanel.Name = "WorkSpacePanel";
            this.WorkSpacePanel.Size = new System.Drawing.Size(1621, 905);
            this.WorkSpacePanel.TabIndex = 2;
            // 
            // sizeBar
            // 
            this.sizeBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(175)))), ((int)(((byte)(173)))));
            this.sizeBar.Controls.Add(this.menuPanel);
            this.sizeBar.Controls.Add(this.myTablePanel);
            this.sizeBar.Location = new System.Drawing.Point(0, -1);
            this.sizeBar.Margin = new System.Windows.Forms.Padding(0);
            this.sizeBar.MaximumSize = new System.Drawing.Size(300, 1200);
            this.sizeBar.MinimumSize = new System.Drawing.Size(70, 1000);
            this.sizeBar.Name = "sizeBar";
            this.sizeBar.Size = new System.Drawing.Size(300, 1200);
            this.sizeBar.TabIndex = 0;
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(100)))), ((int)(((byte)(97)))));
            this.menuPanel.Controls.Add(this.starBtn);
            this.menuPanel.Controls.Add(this.calendarBtn);
            this.menuPanel.Controls.Add(this.alarmBtn);
            this.menuPanel.Controls.Add(this.iconButton);
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(70, 1200);
            this.menuPanel.TabIndex = 1;
            // 
            // starBtn
            // 
            this.starBtn.BackColor = System.Drawing.Color.Transparent;
            this.starBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.starBtn.FillColor = System.Drawing.Color.Transparent;
            this.starBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.starBtn.ForeColor = System.Drawing.Color.White;
            this.starBtn.Image = global::trelloclone.Properties.Resources.star_empty;
            this.starBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.starBtn.Location = new System.Drawing.Point(10, 169);
            this.starBtn.Name = "starBtn";
            this.starBtn.Size = new System.Drawing.Size(50, 50);
            this.starBtn.TabIndex = 2;
            // 
            // calendarBtn
            // 
            this.calendarBtn.BackColor = System.Drawing.Color.Transparent;
            this.calendarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.calendarBtn.FillColor = System.Drawing.Color.Transparent;
            this.calendarBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.calendarBtn.ForeColor = System.Drawing.Color.White;
            this.calendarBtn.Image = global::trelloclone.Properties.Resources.calendar;
            this.calendarBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.calendarBtn.Location = new System.Drawing.Point(10, 116);
            this.calendarBtn.Name = "calendarBtn";
            this.calendarBtn.Size = new System.Drawing.Size(50, 50);
            this.calendarBtn.TabIndex = 1;
            // 
            // alarmBtn
            // 
            this.alarmBtn.BackColor = System.Drawing.Color.Transparent;
            this.alarmBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alarmBtn.FillColor = System.Drawing.Color.Transparent;
            this.alarmBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.alarmBtn.ForeColor = System.Drawing.Color.White;
            this.alarmBtn.Image = global::trelloclone.Properties.Resources.alarm;
            this.alarmBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.alarmBtn.Location = new System.Drawing.Point(10, 66);
            this.alarmBtn.Name = "alarmBtn";
            this.alarmBtn.Size = new System.Drawing.Size(50, 50);
            this.alarmBtn.TabIndex = 0;
            // 
            // iconButton
            // 
            this.iconButton.BackColor = System.Drawing.Color.Transparent;
            this.iconButton.BackgroundImage = global::trelloclone.Properties.Resources.icon;
            this.iconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.iconButton.BorderRadius = 20;
            this.iconButton.FillColor = System.Drawing.Color.Transparent;
            this.iconButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iconButton.ForeColor = System.Drawing.Color.White;
            this.iconButton.Location = new System.Drawing.Point(10, 13);
            this.iconButton.Name = "iconButton";
            this.iconButton.Size = new System.Drawing.Size(50, 50);
            this.iconButton.TabIndex = 0;
            // 
            // myTablePanel
            // 
            this.myTablePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(175)))), ((int)(((byte)(173)))));
            this.myTablePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myTablePanel.Controls.Add(this.btnFindTable);
            this.myTablePanel.Controls.Add(this.myTableButton);
            this.myTablePanel.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.myTablePanel.Location = new System.Drawing.Point(70, 0);
            this.myTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.myTablePanel.Name = "myTablePanel";
            this.myTablePanel.Size = new System.Drawing.Size(230, 1200);
            this.myTablePanel.TabIndex = 1;
            // 
            // btnFindTable
            // 
            this.btnFindTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFindTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFindTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFindTable.FillColor = System.Drawing.Color.Transparent;
            this.btnFindTable.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFindTable.ForeColor = System.Drawing.Color.White;
            this.btnFindTable.Location = new System.Drawing.Point(0, 50);
            this.btnFindTable.Name = "btnFindTable";
            this.btnFindTable.Size = new System.Drawing.Size(230, 44);
            this.btnFindTable.TabIndex = 0;
            this.btnFindTable.Text = "Tìm bảng";
            // 
            // myTableButton
            // 
            this.myTableButton.BackColor = System.Drawing.Color.Transparent;
            this.myTableButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myTableButton.BorderColor = System.Drawing.Color.White;
            this.myTableButton.FillColor = System.Drawing.Color.Transparent;
            this.myTableButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.myTableButton.ForeColor = System.Drawing.Color.White;
            this.myTableButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.myTableButton.Location = new System.Drawing.Point(0, 0);
            this.myTableButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myTableButton.Name = "myTableButton";
            this.myTableButton.Size = new System.Drawing.Size(230, 50);
            this.myTableButton.TabIndex = 0;
            this.myTableButton.Text = "Tạo bảng mới";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 739);
            this.Controls.Add(this.sizeBar);
            this.Controls.Add(this.WorkSpacePanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Process Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sizeBar.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.myTablePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel WorkSpacePanel;
        private Guna2Button myTableButton;
        private System.Windows.Forms.Timer timerMyTable;
        private FlowLayoutPanel sizeBar;
        private Panel menuPanel;
        private Panel myTablePanel;
        private Guna2Button iconButton;
        private Guna.UI2.WinForms.Guna2Button alarmBtn;
        private Guna.UI2.WinForms.Guna2Button calendarBtn;
        private Guna.UI2.WinForms.Guna2Button starBtn;
        private Guna2Button btnFindTable;
    }
}