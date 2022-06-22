
namespace Apartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.listAdmin = new System.Windows.Forms.ListBox();
            this.listResident = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(160)))), ((int)(((byte)(143)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.lblText);
            this.panel1.Controls.Add(this.txtTC);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Location = new System.Drawing.Point(437, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 373);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(485, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.White;
            this.btnShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShow.BackgroundImage")));
            this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShow.Location = new System.Drawing.Point(483, 182);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(57, 54);
            this.btnShow.TabIndex = 3;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblText.Location = new System.Drawing.Point(35, 50);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(489, 25);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "Kullanıcı Adınızı ve TC Kimlik Numaranızı giriniz...";
            // 
            // txtTC
            // 
            this.txtTC.BackColor = System.Drawing.Color.White;
            this.txtTC.Location = new System.Drawing.Point(29, 182);
            this.txtTC.Multiline = true;
            this.txtTC.Name = "txtTC";
            this.txtTC.PasswordChar = '●';
            this.txtTC.Size = new System.Drawing.Size(511, 54);
            this.txtTC.TabIndex = 1;
            this.txtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTC_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogin.Location = new System.Drawing.Point(29, 269);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(511, 56);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "GİRİŞ";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(29, 111);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(511, 54);
            this.txtUser.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(1327, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 45);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // listAdmin
            // 
            this.listAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.listAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listAdmin.FormattingEnabled = true;
            this.listAdmin.ItemHeight = 16;
            this.listAdmin.Location = new System.Drawing.Point(632, 559);
            this.listAdmin.Name = "listAdmin";
            this.listAdmin.Size = new System.Drawing.Size(79, 20);
            this.listAdmin.TabIndex = 1;
            this.listAdmin.Visible = false;
            // 
            // listResident
            // 
            this.listResident.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.listResident.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listResident.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listResident.FormattingEnabled = true;
            this.listResident.ItemHeight = 16;
            this.listResident.Location = new System.Drawing.Point(717, 559);
            this.listResident.Name = "listResident";
            this.listResident.Size = new System.Drawing.Size(96, 20);
            this.listResident.TabIndex = 2;
            this.listResident.Visible = false;
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1389, 751);
            this.Controls.Add(this.listResident);
            this.Controls.Add(this.listAdmin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnShow;
        public System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listAdmin;
        private System.Windows.Forms.ListBox listResident;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtTC;
    }
}