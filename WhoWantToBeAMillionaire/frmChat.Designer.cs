namespace WhoWantToBeAMillionaire
{
    partial class frmChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChat));
            this.lblPlayer = new System.Windows.Forms.Label();
            this.pnPlayer = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.timeCall = new System.Windows.Forms.Timer(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.pnFriend = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblFriendTalk = new System.Windows.Forms.Label();
            this.lblPlayerTalk = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer.Location = new System.Drawing.Point(859, 278);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(0, 28);
            this.lblPlayer.TabIndex = 12;
            // 
            // pnPlayer
            // 
            this.pnPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pnPlayer.BackgroundImage = global::WhoWantToBeAMillionaire.Properties.Resources.mono;
            this.pnPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnPlayer.FillColor = System.Drawing.Color.Transparent;
            this.pnPlayer.FillColor2 = System.Drawing.Color.Transparent;
            this.pnPlayer.FillColor3 = System.Drawing.Color.Transparent;
            this.pnPlayer.FillColor4 = System.Drawing.Color.Transparent;
            this.pnPlayer.Location = new System.Drawing.Point(708, 12);
            this.pnPlayer.Name = "pnPlayer";
            this.pnPlayer.Size = new System.Drawing.Size(303, 250);
            this.pnPlayer.TabIndex = 8;
            // 
            // timeCall
            // 
            this.timeCall.Interval = 1000;
            this.timeCall.Tick += new System.EventHandler(this.timeCall_Tick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(111, 582);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(95, 28);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Sơn Tùng";
            // 
            // pnFriend
            // 
            this.pnFriend.BackColor = System.Drawing.Color.Transparent;
            this.pnFriend.BackgroundImage = global::WhoWantToBeAMillionaire.Properties.Resources.anhsep;
            this.pnFriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnFriend.FillColor = System.Drawing.Color.Transparent;
            this.pnFriend.FillColor2 = System.Drawing.Color.Transparent;
            this.pnFriend.FillColor3 = System.Drawing.Color.Transparent;
            this.pnFriend.FillColor4 = System.Drawing.Color.Transparent;
            this.pnFriend.Location = new System.Drawing.Point(38, 324);
            this.pnFriend.Name = "pnFriend";
            this.pnFriend.Size = new System.Drawing.Size(256, 250);
            this.pnFriend.TabIndex = 13;
            // 
            // lblFriendTalk
            // 
            this.lblFriendTalk.BackColor = System.Drawing.Color.Transparent;
            this.lblFriendTalk.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFriendTalk.Location = new System.Drawing.Point(361, 324);
            this.lblFriendTalk.Name = "lblFriendTalk";
            this.lblFriendTalk.Size = new System.Drawing.Size(650, 250);
            this.lblFriendTalk.TabIndex = 17;
            // 
            // lblPlayerTalk
            // 
            this.lblPlayerTalk.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerTalk.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerTalk.Location = new System.Drawing.Point(38, 12);
            this.lblPlayerTalk.Name = "lblPlayerTalk";
            this.lblPlayerTalk.Size = new System.Drawing.Size(637, 250);
            this.lblPlayerTalk.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(817, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mono";
            // 
            // frmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1023, 619);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlayerTalk);
            this.Controls.Add(this.lblFriendTalk);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnFriend);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.pnPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phone";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChat_FormClosing);
            this.Load += new System.EventHandler(this.frmChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPlayer;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnPlayer;
        private System.Windows.Forms.Timer timeCall;
        private Label lblName;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnFriend;
        private Label lblFriendTalk;
        private Label lblPlayerTalk;
        private Label label1;
    }
}