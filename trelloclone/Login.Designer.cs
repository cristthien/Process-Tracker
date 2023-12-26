using Guna.UI2.WinForms;

namespace trelloclone
{
    partial class Login
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
            this.BackGroundLoginPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnChoiceForSignUp = new Guna.UI2.WinForms.Guna2Button();
            this.btnChoiceForLogin = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.BackGroundLoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackGroundLoginPanel
            // 
            this.BackGroundLoginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackGroundLoginPanel.BackColor = System.Drawing.Color.Transparent;
            this.BackGroundLoginPanel.BackgroundImage = global::trelloclone.Properties.Resources.BackGoundLogin;
            this.BackGroundLoginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackGroundLoginPanel.Controls.Add(this.btnChoiceForSignUp);
            this.BackGroundLoginPanel.Controls.Add(this.btnChoiceForLogin);
            this.BackGroundLoginPanel.Controls.Add(this.label2);
            this.BackGroundLoginPanel.Controls.Add(this.label1);
            this.BackGroundLoginPanel.Controls.Add(this.WelcomeLabel);
            this.BackGroundLoginPanel.Location = new System.Drawing.Point(320, 100);
            this.BackGroundLoginPanel.Name = "BackGroundLoginPanel";
            this.BackGroundLoginPanel.Size = new System.Drawing.Size(688, 509);
            this.BackGroundLoginPanel.TabIndex = 0;
            // 
            // btnChoiceForSignUp
            // 
            this.btnChoiceForSignUp.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.btnChoiceForSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChoiceForSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChoiceForSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChoiceForSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChoiceForSignUp.FillColor = System.Drawing.Color.White;
            this.btnChoiceForSignUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChoiceForSignUp.ForeColor = System.Drawing.Color.Black;
            this.btnChoiceForSignUp.Location = new System.Drawing.Point(240, 160);
            this.btnChoiceForSignUp.Name = "btnChoiceForSignUp";
            this.btnChoiceForSignUp.Size = new System.Drawing.Size(141, 50);
            this.btnChoiceForSignUp.TabIndex = 12;
            this.btnChoiceForSignUp.Text = "Đăng ký";
            // 
            // btnChoiceForLogin
            // 
            this.btnChoiceForLogin.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.btnChoiceForLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChoiceForLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChoiceForLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChoiceForLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChoiceForLogin.FillColor = System.Drawing.Color.White;
            this.btnChoiceForLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChoiceForLogin.ForeColor = System.Drawing.Color.Black;
            this.btnChoiceForLogin.Location = new System.Drawing.Point(97, 160);
            this.btnChoiceForLogin.Name = "btnChoiceForLogin";
            this.btnChoiceForLogin.Size = new System.Drawing.Size(141, 50);
            this.btnChoiceForLogin.TabIndex = 11;
            this.btnChoiceForLogin.Text = "Đăng nhập";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(76, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(397, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 9;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.WelcomeLabel.Location = new System.Drawing.Point(59, 88);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(359, 57);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = " Process Tracker";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::trelloclone.Properties.Resources.BackGroundLogin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1212, 681);
            this.Controls.Add(this.BackGroundLoginPanel);
            this.Name = "Login";
            this.ShowIcon = false;
            this.Text = "Process Tracker";
            this.BackGroundLoginPanel.ResumeLayout(false);
            this.BackGroundLoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel BackGroundLoginPanel;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna2Button btnChoiceForSignUp;
        private Guna2Button btnChoiceForLogin;
    }
}