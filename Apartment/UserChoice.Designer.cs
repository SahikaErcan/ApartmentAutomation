
namespace Apartment
{
    partial class UserChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserChoice));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResident = new System.Windows.Forms.Button();
            this.btnAdministrator = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(144, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1133, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "APARTMAN YÖNETİM SİSTEMİ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(160)))), ((int)(((byte)(143)))));
            this.panel1.Controls.Add(this.btnResident);
            this.panel1.Controls.Add(this.btnAdministrator);
            this.panel1.Location = new System.Drawing.Point(413, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 287);
            this.panel1.TabIndex = 1;
            // 
            // btnResident
            // 
            this.btnResident.BackColor = System.Drawing.Color.White;
            this.btnResident.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnResident.Location = new System.Drawing.Point(13, 150);
            this.btnResident.Name = "btnResident";
            this.btnResident.Size = new System.Drawing.Size(564, 125);
            this.btnResident.TabIndex = 1;
            this.btnResident.Text = "APARTMAN SAKİNİ GİRİŞİ";
            this.btnResident.UseVisualStyleBackColor = false;
            this.btnResident.Click += new System.EventHandler(this.btnResident_Click);
            // 
            // btnAdministrator
            // 
            this.btnAdministrator.BackColor = System.Drawing.Color.White;
            this.btnAdministrator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdministrator.Location = new System.Drawing.Point(13, 13);
            this.btnAdministrator.Name = "btnAdministrator";
            this.btnAdministrator.Size = new System.Drawing.Size(564, 125);
            this.btnAdministrator.TabIndex = 0;
            this.btnAdministrator.Text = "YÖNETİCİ GİRİŞİ";
            this.btnAdministrator.UseVisualStyleBackColor = false;
            this.btnAdministrator.Click += new System.EventHandler(this.btnAdministrator_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Location = new System.Drawing.Point(1332, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(46, 41);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // UserChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1390, 750);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnResident;
        private System.Windows.Forms.Button btnAdministrator;
        private System.Windows.Forms.Button btnLogout;
    }
}

