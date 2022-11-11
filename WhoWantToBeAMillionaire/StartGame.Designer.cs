namespace WhoWantToBeAMillionaire
{
    partial class frmStartGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartGame));
            this.pnStart = new Guna.UI2.WinForms.Guna2Panel();
            this.btnQuit = new Guna.UI2.WinForms.Guna2Button();
            this.btnInformation = new Guna.UI2.WinForms.Guna2Button();
            this.btnManual = new Guna.UI2.WinForms.Guna2Button();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWelcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnStart.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnStart
            // 
            this.pnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnStart.BackColor = System.Drawing.Color.Transparent;
            this.pnStart.BorderColor = System.Drawing.Color.Transparent;
            this.pnStart.BorderRadius = 50;
            this.pnStart.Controls.Add(this.btnQuit);
            this.pnStart.Controls.Add(this.btnInformation);
            this.pnStart.Controls.Add(this.btnManual);
            this.pnStart.Controls.Add(this.btnStart);
            this.pnStart.FillColor = System.Drawing.Color.DarkBlue;
            this.pnStart.Location = new System.Drawing.Point(342, 349);
            this.pnStart.Name = "pnStart";
            this.pnStart.Size = new System.Drawing.Size(789, 324);
            this.pnStart.TabIndex = 1;
            // 
            // btnQuit
            // 
            this.btnQuit.BorderRadius = 20;
            this.btnQuit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuit.FillColor = System.Drawing.Color.MediumBlue;
            this.btnQuit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(471, 229);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.PressedColor = System.Drawing.Color.RoyalBlue;
            this.btnQuit.Size = new System.Drawing.Size(225, 56);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.BorderRadius = 20;
            this.btnInformation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInformation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInformation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInformation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInformation.FillColor = System.Drawing.Color.MediumBlue;
            this.btnInformation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInformation.ForeColor = System.Drawing.Color.White;
            this.btnInformation.Location = new System.Drawing.Point(78, 229);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.PressedColor = System.Drawing.Color.RoyalBlue;
            this.btnInformation.Size = new System.Drawing.Size(225, 56);
            this.btnInformation.TabIndex = 2;
            this.btnInformation.Text = "Thông Tin";
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnManual
            // 
            this.btnManual.BorderRadius = 20;
            this.btnManual.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManual.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManual.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManual.FillColor = System.Drawing.Color.MediumBlue;
            this.btnManual.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManual.ForeColor = System.Drawing.Color.White;
            this.btnManual.Location = new System.Drawing.Point(471, 62);
            this.btnManual.Name = "btnManual";
            this.btnManual.PressedColor = System.Drawing.Color.RoyalBlue;
            this.btnManual.Size = new System.Drawing.Size(225, 56);
            this.btnManual.TabIndex = 1;
            this.btnManual.Text = "Hướng Dẫn";
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnStart
            // 
            this.btnStart.BorderRadius = 20;
            this.btnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStart.FillColor = System.Drawing.Color.MediumBlue;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(78, 62);
            this.btnStart.Name = "btnStart";
            this.btnStart.PressedColor = System.Drawing.Color.RoyalBlue;
            this.btnStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStart.Size = new System.Drawing.Size(225, 56);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Bắt Đầu";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Location = new System.Drawing.Point(420, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 125);
            this.panel1.TabIndex = 2;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWelcome.AutoSize = false;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWelcome.Location = new System.Drawing.Point(-41, 21);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(701, 82);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Ai Là Triệu Phú";
            this.lblWelcome.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmStartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = global::WhoWantToBeAMillionaire.Properties.Resources.bgailatrieuphu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1462, 735);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStartGame";
            this.Text = "StartGame";
            this.pnStart.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnStart;
        private Guna.UI2.WinForms.Guna2Button btnQuit;
        private Guna.UI2.WinForms.Guna2Button btnInformation;
        private Guna.UI2.WinForms.Guna2Button btnManual;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWelcome;
    }
}