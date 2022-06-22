
namespace Apartment
{
    partial class AddRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRecord));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRentDebt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioBtnPayNo = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.radioBtnPayYes = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mskDate = new System.Windows.Forms.MaskedTextBox();
            this.txtRent = new System.Windows.Forms.TextBox();
            this.lblRent = new System.Windows.Forms.Label();
            this.radioBtnHost = new System.Windows.Forms.RadioButton();
            this.radioBtnHirer = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblRadioResident = new System.Windows.Forms.Label();
            this.lblRadioYesNo = new System.Windows.Forms.Label();
            this.lblBtnClick = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(160)))), ((int)(((byte)(143)))));
            this.groupBox1.Controls.Add(this.mskTC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mskPhone);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.mskDate);
            this.groupBox1.Controls.Add(this.txtRent);
            this.groupBox1.Controls.Add(this.lblRent);
            this.groupBox1.Controls.Add(this.radioBtnHost);
            this.groupBox1.Controls.Add(this.radioBtnHirer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(37, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 627);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apartman Sakini İşlemleri";
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(252, 111);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(255, 30);
            this.mskTC.TabIndex = 25;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "TC Numarası";
            // 
            // mskPhone
            // 
            this.mskPhone.Location = new System.Drawing.Point(251, 162);
            this.mskPhone.Mask = "(999) 000-0000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(255, 30);
            this.mskPhone.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Telefon Numarası";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtRentDebt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.radioBtnPayNo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.radioBtnPayYes);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(54, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 208);
            this.panel1.TabIndex = 23;
            // 
            // txtRentDebt
            // 
            this.txtRentDebt.Location = new System.Drawing.Point(197, 54);
            this.txtRentDebt.Name = "txtRentDebt";
            this.txtRentDebt.Size = new System.Drawing.Size(255, 30);
            this.txtRentDebt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Aidat Ödendi mi?";
            // 
            // radioBtnPayNo
            // 
            this.radioBtnPayNo.AutoSize = true;
            this.radioBtnPayNo.Location = new System.Drawing.Point(328, 7);
            this.radioBtnPayNo.Name = "radioBtnPayNo";
            this.radioBtnPayNo.Size = new System.Drawing.Size(83, 29);
            this.radioBtnPayNo.TabIndex = 1;
            this.radioBtnPayNo.TabStop = true;
            this.radioBtnPayNo.Text = "Hayır";
            this.radioBtnPayNo.UseVisualStyleBackColor = true;
            this.radioBtnPayNo.CheckedChanged += new System.EventHandler(this.radioBtnPayNo_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Borç Tutarı";
            // 
            // radioBtnPayYes
            // 
            this.radioBtnPayYes.AutoSize = true;
            this.radioBtnPayYes.Location = new System.Drawing.Point(198, 9);
            this.radioBtnPayYes.Name = "radioBtnPayYes";
            this.radioBtnPayYes.Size = new System.Drawing.Size(76, 29);
            this.radioBtnPayYes.TabIndex = 0;
            this.radioBtnPayYes.TabStop = true;
            this.radioBtnPayYes.Text = "Evet";
            this.radioBtnPayYes.UseVisualStyleBackColor = true;
            this.radioBtnPayYes.CheckedChanged += new System.EventHandler(this.radioBtnPayYes_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(5, 133);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(460, 61);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // mskDate
            // 
            this.mskDate.Location = new System.Drawing.Point(252, 212);
            this.mskDate.Mask = "00/00/0000";
            this.mskDate.Name = "mskDate";
            this.mskDate.Size = new System.Drawing.Size(255, 30);
            this.mskDate.TabIndex = 2;
            this.mskDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtRent
            // 
            this.txtRent.Location = new System.Drawing.Point(252, 315);
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(255, 30);
            this.txtRent.TabIndex = 15;
            this.txtRent.Visible = false;
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.Location = new System.Drawing.Point(57, 318);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(117, 25);
            this.lblRent.TabIndex = 14;
            this.lblRent.Text = "Kira Bedeli";
            this.lblRent.Visible = false;
            // 
            // radioBtnHost
            // 
            this.radioBtnHost.AutoSize = true;
            this.radioBtnHost.Location = new System.Drawing.Point(382, 263);
            this.radioBtnHost.Name = "radioBtnHost";
            this.radioBtnHost.Size = new System.Drawing.Size(125, 29);
            this.radioBtnHost.TabIndex = 4;
            this.radioBtnHost.TabStop = true;
            this.radioBtnHost.Text = "Ev Sahibi";
            this.radioBtnHost.UseVisualStyleBackColor = true;
            this.radioBtnHost.CheckedChanged += new System.EventHandler(this.radioBtnHost_CheckedChanged);
            // 
            // radioBtnHirer
            // 
            this.radioBtnHirer.AutoSize = true;
            this.radioBtnHirer.Location = new System.Drawing.Point(252, 263);
            this.radioBtnHirer.Name = "radioBtnHirer";
            this.radioBtnHirer.Size = new System.Drawing.Size(88, 29);
            this.radioBtnHirer.TabIndex = 3;
            this.radioBtnHirer.TabStop = true;
            this.radioBtnHirer.Text = "Kiracı";
            this.radioBtnHirer.UseVisualStyleBackColor = true;
            this.radioBtnHirer.CheckedChanged += new System.EventHandler(this.radioBtnHirer_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kayıt Tarihi";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(251, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(256, 30);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Adı Soyadı";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(629, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(41, 39);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblRadioResident
            // 
            this.lblRadioResident.AutoSize = true;
            this.lblRadioResident.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRadioResident.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRadioResident.Location = new System.Drawing.Point(170, 681);
            this.lblRadioResident.Name = "lblRadioResident";
            this.lblRadioResident.Size = new System.Drawing.Size(72, 17);
            this.lblRadioResident.TabIndex = 26;
            this.lblRadioResident.Text = "Resident";
            this.lblRadioResident.Visible = false;
            // 
            // lblRadioYesNo
            // 
            this.lblRadioYesNo.AutoSize = true;
            this.lblRadioYesNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRadioYesNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRadioYesNo.Location = new System.Drawing.Point(266, 681);
            this.lblRadioYesNo.Name = "lblRadioYesNo";
            this.lblRadioYesNo.Size = new System.Drawing.Size(55, 17);
            this.lblRadioYesNo.TabIndex = 27;
            this.lblRadioYesNo.Text = "YesNo";
            this.lblRadioYesNo.Visible = false;
            // 
            // lblBtnClick
            // 
            this.lblBtnClick.AutoSize = true;
            this.lblBtnClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBtnClick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBtnClick.Location = new System.Drawing.Point(327, 681);
            this.lblBtnClick.Name = "lblBtnClick";
            this.lblBtnClick.Size = new System.Drawing.Size(66, 17);
            this.lblBtnClick.TabIndex = 28;
            this.lblBtnClick.Text = "BtnClick";
            this.lblBtnClick.Visible = false;
            // 
            // AddRecord
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(160)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(670, 707);
            this.Controls.Add(this.lblBtnClick);
            this.Controls.Add(this.lblRadioYesNo);
            this.Controls.Add(this.lblRadioResident);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddRecord";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.RadioButton radioBtnPayNo;
        public System.Windows.Forms.RadioButton radioBtnPayYes;
        public System.Windows.Forms.MaskedTextBox mskDate;
        public System.Windows.Forms.TextBox txtRent;
        public System.Windows.Forms.RadioButton radioBtnHost;
        public System.Windows.Forms.RadioButton radioBtnHirer;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtRentDebt;
        public System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Label lblRadioYesNo;
        public System.Windows.Forms.Label lblRadioResident;
        public System.Windows.Forms.Label lblRent;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblBtnClick;
    }
}