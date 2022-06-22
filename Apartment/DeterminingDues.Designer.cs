
namespace Apartment
{
    partial class DeterminingDues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeterminingDues));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDuesPrice = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.txtDues = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLift = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCleaning = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnergy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaintenance = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(176, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mevcut Ücret:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDuesPrice);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(41, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 601);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aidat Belirleme";
            // 
            // lblDuesPrice
            // 
            this.lblDuesPrice.AutoSize = true;
            this.lblDuesPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDuesPrice.ForeColor = System.Drawing.Color.White;
            this.lblDuesPrice.Location = new System.Drawing.Point(393, 52);
            this.lblDuesPrice.Name = "lblDuesPrice";
            this.lblDuesPrice.Size = new System.Drawing.Size(33, 36);
            this.lblDuesPrice.TabIndex = 3;
            this.lblDuesPrice.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnCalculate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtOther);
            this.groupBox2.Controls.Add(this.txtDues);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtLift);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtCleaning);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtEnergy);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMaintenance);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(60, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 430);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Masraflar ve Türleri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Diğer";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(217, 344);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(218, 50);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Hesapla";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Aidat";
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(217, 244);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(218, 30);
            this.txtOther.TabIndex = 13;
            // 
            // txtDues
            // 
            this.txtDues.Location = new System.Drawing.Point(217, 290);
            this.txtDues.Name = "txtDues";
            this.txtDues.Size = new System.Drawing.Size(218, 30);
            this.txtDues.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Asansör";
            // 
            // txtLift
            // 
            this.txtLift.Location = new System.Drawing.Point(217, 198);
            this.txtLift.Name = "txtLift";
            this.txtLift.Size = new System.Drawing.Size(218, 30);
            this.txtLift.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Temizlik";
            // 
            // txtCleaning
            // 
            this.txtCleaning.Location = new System.Drawing.Point(217, 152);
            this.txtCleaning.Name = "txtCleaning";
            this.txtCleaning.Size = new System.Drawing.Size(218, 30);
            this.txtCleaning.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enerji";
            // 
            // txtEnergy
            // 
            this.txtEnergy.Location = new System.Drawing.Point(217, 104);
            this.txtEnergy.Name = "txtEnergy";
            this.txtEnergy.Size = new System.Drawing.Size(218, 30);
            this.txtEnergy.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bakım / Onarım";
            // 
            // txtMaintenance
            // 
            this.txtMaintenance.Location = new System.Drawing.Point(217, 58);
            this.txtMaintenance.Name = "txtMaintenance";
            this.txtMaintenance.Size = new System.Drawing.Size(218, 30);
            this.txtMaintenance.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(650, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(41, 39);
            this.btnBack.TabIndex = 2;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DeterminingDues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(160)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(693, 674);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DeterminingDues";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DeterminingDues";
            this.Load += new System.EventHandler(this.DeterminingDues_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDuesPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaintenance;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDues;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLift;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCleaning;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEnergy;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOther;
    }
}