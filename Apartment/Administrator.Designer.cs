
namespace Apartment
{
    partial class Administrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.btnBack = new System.Windows.Forms.Button();
            this.listViewHirers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddResident = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDues = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(1327, 14);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(49, 45);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // listViewHirers
            // 
            this.listViewHirers.BackColor = System.Drawing.Color.White;
            this.listViewHirers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader8,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewHirers.FullRowSelect = true;
            this.listViewHirers.GridLines = true;
            this.listViewHirers.HideSelection = false;
            this.listViewHirers.Location = new System.Drawing.Point(26, 143);
            this.listViewHirers.Name = "listViewHirers";
            this.listViewHirers.Size = new System.Drawing.Size(1282, 576);
            this.listViewHirers.TabIndex = 8;
            this.listViewHirers.UseCompatibleStateImageBehavior = false;
            this.listViewHirers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adı Soyadı";
            this.columnHeader1.Width = 214;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TC Numarası";
            this.columnHeader4.Width = 171;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Telefon Numarası";
            this.columnHeader8.Width = 190;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kayıt Tarihi";
            this.columnHeader2.Width = 146;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kiracı mı?";
            this.columnHeader3.Width = 116;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kira Bedeli";
            this.columnHeader5.Width = 126;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Aidat Ödendi Mi?";
            this.columnHeader6.Width = 181;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Borç Tutarı";
            this.columnHeader7.Width = 126;
            // 
            // btnAddResident
            // 
            this.btnAddResident.BackColor = System.Drawing.Color.White;
            this.btnAddResident.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddResident.Location = new System.Drawing.Point(26, 34);
            this.btnAddResident.Name = "btnAddResident";
            this.btnAddResident.Size = new System.Drawing.Size(317, 79);
            this.btnAddResident.TabIndex = 9;
            this.btnAddResident.Text = "Apartman Sakini Ekle";
            this.btnAddResident.UseVisualStyleBackColor = false;
            this.btnAddResident.Click += new System.EventHandler(this.btnAddResident_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Location = new System.Drawing.Point(349, 34);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(317, 79);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Seçili Sakini Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEdit.Location = new System.Drawing.Point(672, 34);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(317, 79);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Seçili Bilgiyi Düzenle";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDues
            // 
            this.btnDues.BackColor = System.Drawing.Color.White;
            this.btnDues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDues.Location = new System.Drawing.Point(995, 34);
            this.btnDues.Name = "btnDues";
            this.btnDues.Size = new System.Drawing.Size(317, 79);
            this.btnDues.TabIndex = 12;
            this.btnDues.Text = "Aidat Miktarı Belirle";
            this.btnDues.UseVisualStyleBackColor = false;
            this.btnDues.Click += new System.EventHandler(this.btnDues_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1386, 742);
            this.Controls.Add(this.btnDues);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddResident);
            this.Controls.Add(this.listViewHirers);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnAddResident;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnDues;
        public System.Windows.Forms.ListView listViewHirers;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}