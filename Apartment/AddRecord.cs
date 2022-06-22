using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartment
{
    public partial class AddRecord : Form
    {
        public AddRecord()
        {
            InitializeComponent();
        }

        string filePathResidents = @"C:\Users\Excalibur\Desktop\ApartmentAutomation\Apartment\bin\Debug\DATA\residents.txt";

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblBtnClick.Text = "Tıklandı";

            FileStream fileStream = new FileStream(filePathResidents, FileMode.Append, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);


            if (lblRadioResident.Text == "Kiracı")
            {
                streamWriter.WriteLine(txtName.Text + "\t" + mskTC.Text + "\t" + mskPhone.Text + "\t" + mskDate.Text + "\t" + lblRadioResident.Text + "\t" + txtRent.Text + "\t" + lblRadioYesNo.Text + "\t" + txtRentDebt.Text);
            }
            else
            {
                txtRent.Text = "YOK";
                streamWriter.WriteLine(txtName.Text + "\t" + mskTC.Text + "\t" + mskPhone.Text + "\t" + mskDate.Text + "\t" + lblRadioResident.Text + "\t" + txtRent.Text + "\t" + lblRadioYesNo.Text + "\t" + txtRentDebt.Text);
            }
            streamWriter.Flush();
            streamWriter.Close();
            fileStream.Close();


            if (txtName.Text != "" && mskTC.Text != "" && mskPhone.MaskFull && mskDate.MaskCompleted && txtRent.Text != "" && txtRentDebt.Text != "" && (radioBtnHirer.Checked == true || radioBtnHost.Checked == true) && (radioBtnPayYes.Checked == true || radioBtnPayNo.Checked == true))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                if (txtName.Text == "") errorProvider1.SetError(txtName, "Boş alanı doldurunuz.");
                if (!mskTC.MaskFull) errorProvider1.SetError(txtName, "TC numarası doğru girilmedi.");
                if (!mskPhone.MaskFull) errorProvider1.SetError(mskPhone, "Telefon numarası doğru girilmedi.");
                if (!mskDate.MaskFull) errorProvider1.SetError(mskDate, "Tarih doğru girilmedi.");
                if (txtRent.Text == "") errorProvider1.SetError(txtRent, "Boş alanı doldurunuz.");
                if (txtRentDebt.Text == "") errorProvider1.SetError(txtRentDebt, "Boş alanı doldurunuz.");
                if (radioBtnHirer.Checked == false && radioBtnHost.Checked == false) errorProvider1.SetError(radioBtnHost, "Butonlardan birini seçiniz.");
                if (radioBtnPayYes.Checked == false && radioBtnPayNo.Checked == false) errorProvider1.SetError(radioBtnPayNo, "Butonlardan birini seçiniz.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Administrator administrator = new Administrator();
            //administrator.Show();
            this.Hide();
        }

        private void radioBtnHirer_CheckedChanged(object sender, EventArgs e)
        {
            lblRadioResident.Text = radioBtnHirer.Text;
            lblRent.Visible = true;
            txtRent.Visible = true;
            panel1.Location = new Point(54, 364);
        }

        private void radioBtnHost_CheckedChanged(object sender, EventArgs e)
        {
            lblRadioResident.Text = radioBtnHost.Text;
            lblRent.Visible = false;
            txtRent.Visible = false;
            panel1.Location = new Point(54, 315);
        }

        private void radioBtnPayYes_CheckedChanged(object sender, EventArgs e)
        {
            lblRadioYesNo.Text = radioBtnPayYes.Text;
        }

        private void radioBtnPayNo_CheckedChanged(object sender, EventArgs e)
        {
            lblRadioYesNo.Text = radioBtnPayNo.Text;
        }
    }
}
