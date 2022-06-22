
namespace Apartment
{
    partial class Resident
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resident));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDuesPay = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtDebt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRentMoney = new System.Windows.Forms.TextBox();
            this.lblRent = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTenant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDues = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPayOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(574, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 45);
            this.btnBack.TabIndex = 7;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDuesPay
            // 
            this.btnDuesPay.BackColor = System.Drawing.Color.White;
            this.btnDuesPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDuesPay.Location = new System.Drawing.Point(319, 523);
            this.btnDuesPay.Name = "btnDuesPay";
            this.btnDuesPay.Size = new System.Drawing.Size(211, 61);
            this.btnDuesPay.TabIndex = 9;
            this.btnDuesPay.Text = "Aidat Öde";
            this.btnDuesPay.UseVisualStyleBackColor = false;
            this.btnDuesPay.Click += new System.EventHandler(this.btnDuesPay_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(160)))), ((int)(((byte)(143)))));
            this.lblName.Location = new System.Drawing.Point(102, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(276, 55);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Adı_Soyadı";
            // 
            // txtDebt
            // 
            this.txtDebt.Enabled = false;
            this.txtDebt.Location = new System.Drawing.Point(275, 456);
            this.txtDebt.Name = "txtDebt";
            this.txtDebt.Size = new System.Drawing.Size(255, 30);
            this.txtDebt.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Aidat Ödendi mi?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(80, 459);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Borç Tutarı";
            // 
            // txtRentMoney
            // 
            this.txtRentMoney.Enabled = false;
            this.txtRentMoney.Location = new System.Drawing.Point(275, 353);
            this.txtRentMoney.Name = "txtRentMoney";
            this.txtRentMoney.Size = new System.Drawing.Size(255, 30);
            this.txtRentMoney.TabIndex = 15;
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.Location = new System.Drawing.Point(80, 356);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(117, 25);
            this.lblRent.TabIndex = 14;
            this.lblRent.Text = "Kira Bedeli";
            // 
            // txtTC
            // 
            this.txtTC.Enabled = false;
            this.txtTC.Location = new System.Drawing.Point(275, 148);
            this.txtTC.Mask = "00000000000";
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(255, 30);
            this.txtTC.TabIndex = 35;
            this.txtTC.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "TC Numarası";
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(274, 199);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(255, 30);
            this.txtPhone.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 25);
            this.label8.TabIndex = 34;
            this.label8.Text = "Telefon Numarası";
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(275, 249);
            this.txtDate.Mask = "00/00/0000";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(255, 30);
            this.txtDate.TabIndex = 29;
            this.txtDate.ValidatingType = typeof(System.DateTime);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(80, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 25);
            this.label11.TabIndex = 33;
            this.label11.Text = "Kayıt Tarihi";
            // 
            // txtTenant
            // 
            this.txtTenant.Enabled = false;
            this.txtTenant.Location = new System.Drawing.Point(274, 300);
            this.txtTenant.Name = "txtTenant";
            this.txtTenant.Size = new System.Drawing.Size(255, 30);
            this.txtTenant.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Kiracı Mı?";
            // 
            // txtDues
            // 
            this.txtDues.Enabled = false;
            this.txtDues.Location = new System.Drawing.Point(274, 404);
            this.txtDues.Name = "txtDues";
            this.txtDues.Size = new System.Drawing.Size(255, 30);
            this.txtDues.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.txtPay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPayOk);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(646, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 455);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aidat Öde";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Location = new System.Drawing.Point(218, 267);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 61);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPay
            // 
            this.txtPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPay.Location = new System.Drawing.Point(56, 159);
            this.txtPay.Multiline = true;
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(320, 52);
            this.txtPay.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ödemek İstediğiniz Tutarı Giriniz";
            // 
            // btnPayOk
            // 
            this.btnPayOk.BackColor = System.Drawing.Color.White;
            this.btnPayOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPayOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPayOk.Location = new System.Drawing.Point(54, 267);
            this.btnPayOk.Name = "btnPayOk";
            this.btnPayOk.Size = new System.Drawing.Size(158, 61);
            this.btnPayOk.TabIndex = 10;
            this.btnPayOk.Text = "Onayla";
            this.btnPayOk.UseVisualStyleBackColor = false;
            this.btnPayOk.Click += new System.EventHandler(this.btnPayOk_Click);
            // 
            // Resident
            // 
            this.AcceptButton = this.btnDuesPay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(639, 752);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDebt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDues);
            this.Controls.Add(this.txtTenant);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRentMoney);
            this.Controls.Add(this.lblRent);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnDuesPay);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Resident";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resident";
            this.Load += new System.EventHandler(this.Resident_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDuesPay;
        public System.Windows.Forms.TextBox txtDebt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtRentMoney;
        public System.Windows.Forms.Label lblRent;
        public System.Windows.Forms.MaskedTextBox txtTC;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.MaskedTextBox txtDate;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtTenant;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtDues;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPayOk;
        public System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCancel;
    }
}