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
using Tulpep.NotificationWindow;

namespace Apartment
{
    public partial class Resident : Form
    {
        public Resident()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserChoice userChoice = new UserChoice();
            userChoice.Show();
            this.Hide();
        }

        Login login = new Login();
        string filePathResidents = @"C:\Users\Excalibur\Desktop\ApartmentAutomation\Apartment\bin\Debug\DATA\residents.txt";

        private void Resident_Load(object sender, EventArgs e)
        {
            using (StreamReader streamReader = new StreamReader(filePathResidents))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (line.Split('\t')[0] == lblName.Text)
                    {
                        txtTC.Text = line.Split('\t')[1];
                        txtPhone.Text = line.Split('\t')[2];
                        txtDate.Text = line.Split('\t')[3];
                        txtTenant.Text = line.Split('\t')[4];
                        txtRentMoney.Text = line.Split('\t')[5];
                        txtDues.Text = line.Split('\t')[6];
                        txtDebt.Text = line.Split('\t')[7];
                    }
                }
                streamReader.Close();
            }
            if (txtDebt.Text == "0")
            {
                btnDuesPay.Visible = false;
            }
            else
            {
                PopupNotifier popupNotifier = new PopupNotifier();
                popupNotifier.Delay = 6000;

                popupNotifier.AnimationDuration = 1000;

                popupNotifier.Image = Properties.Resources.information;
                popupNotifier.ImagePadding = new Padding(10);

                popupNotifier.TitleText = "UYARI";
                popupNotifier.TitlePadding = new Padding(95, 7, 0, 0);
                popupNotifier.TitleFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

                popupNotifier.ContentText = txtDebt.Text + " TL borcunuz bulunmaktadır.";
                popupNotifier.ContentPadding = new Padding(10);
                popupNotifier.ContentFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);



                popupNotifier.Popup();
            }

            if (txtDues.Text == "Hayır")
            {
                PopupNotifier popupNotifier = new PopupNotifier();

                popupNotifier.AnimationDuration = 1000;

                popupNotifier.Image = Properties.Resources.information;
                popupNotifier.ImagePadding = new Padding(10);

                popupNotifier.TitleText = "UYARI !";
                popupNotifier.TitlePadding = new Padding(95, 7, 0, 0);
                popupNotifier.TitleFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

                popupNotifier.ContentText = "Bu ay ki aidat ücretiniz ödenmemiştir.";
                popupNotifier.ContentPadding = new Padding(10);
                popupNotifier.ContentFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

                popupNotifier.Popup();
            }
        }

        private void btnDuesPay_Click(object sender, EventArgs e)
        {
            this.Width = 1172;
            this.Height = 750;
            btnBack.Location = new Point(1110, 12);
        }

        void fileReadUpdate(string fileName, string debt, string dues)
        {
            StringBuilder newFile = new StringBuilder();
            string updateDues = "", updateDebt = "";
            string temp = "";
            string[] file = File.ReadAllLines(fileName, Encoding.UTF8);

            foreach (string line in file)
            {
                if (line.Split('\t')[0] == lblName.Text)
                {
                    string[] words = line.Split('\t');
                    words[6] = dues;
                    words[7] = debt;
                    updateDues = words[6];
                    updateDebt = words[7];
                    temp = words[0] + '\t' + words[1] + '\t' + words[2] + '\t' + words[3] + '\t' + words[4] + '\t' + words[5] + '\t' + updateDues + '\t' + updateDebt;
                    newFile.Append(temp + "\r\n");
                    File.WriteAllText(@"C:\Users\Excalibur\Desktop\ApartmentAutomation\Apartment\bin\Debug\DATA\Residents.txt", newFile.ToString());

                }
                else
                {
                    temp = line.Split('\t')[0] + '\t' + line.Split('\t')[1] + '\t' + line.Split('\t')[2] + '\t' + line.Split('\t')[3] + '\t' + line.Split('\t')[4] + '\t' + line.Split('\t')[5] + '\t' + line.Split('\t')[6] + '\t' + line.Split('\t')[7];

                    //  \r carriage return     \n newline
                    newFile.Append(temp + "\r\n");
                    File.WriteAllText(@"C:\Users\Excalibur\Desktop\ApartmentAutomation\Apartment\bin\Debug\DATA\Residents.txt", newFile.ToString());
                }
            }
        }

        private void btnPayOk_Click(object sender, EventArgs e)
        {
            int remainder = Convert.ToInt32(txtDebt.Text) - Convert.ToInt32(txtPay.Text);

            if (remainder < 0)
            {
                MessageBox.Show("Fazladan ödeme yapmaya çalışıyorsunuz. Toplam Borcunuz:" + txtDebt.Text);
                txtPay.Text = "";
            }            
            else
            {
                if (remainder == 0)
                {
                    txtDues.Text = "Evet";
                }
                txtDebt.Text = remainder.ToString();
                this.Width = 636;
                this.Height = 750;
                btnBack.Location = new Point(574, 12);

                fileReadUpdate(filePathResidents, remainder.ToString(), txtDues.Text);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Width = 636;
            this.Height = 750;
            btnBack.Location = new Point(574, 12);
        }
    }
}
