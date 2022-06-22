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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            UserChoice userChoice = new UserChoice();
            userChoice.Show();
            this.Hide();
        }

        string filePathResidents = @"C:\Users\Excalibur\Desktop\ApartmentAutomation\Apartment\bin\Debug\DATA\residents.txt";
        string filePathAdmin = @"C:\Users\Excalibur\Desktop\ApartmentAutomation\Apartment\bin\Debug\DATA\admin.txt";

        private void Login_Load(object sender, EventArgs e)
        {
            string[] admin = new string[listAdmin.Items.Count];
            admin = File.ReadAllLines(filePathAdmin);
            listAdmin.Items.AddRange(admin);

            string[] resident = new string[listResident.Items.Count];
            resident = File.ReadAllLines(filePathResidents);
            listResident.Items.AddRange(resident);
        }

        int wrongLogin = 0;
        void clean()
        {
            wrongLogin++;
            if (wrongLogin >= 5)
            {
                MessageBox.Show("Giriş hakkınız kalmadı. Uygulamadan çıkılıyor...");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Yönetici Adı veya Parola yanlış girilmiştir.\nKalan giriş hakkınız: " + (5 - wrongLogin), "YANLIŞ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Clear();
                txtTC.Clear();
                txtUser.Focus();
            }                   
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtTC.PasswordChar.ToString() == "●")
            {
                Image image = Image.FromFile("C:\\Users\\Excalibur\\Desktop\\ApartmentAutomation\\Apartment\\bin\\Debug\\openEyes.png");
                Bitmap bitmap = new Bitmap(image, 57, 54);
                btnShow.BackgroundImage = bitmap;

                txtTC.PasswordChar = '\0';
            }
            else
            {
                Image image = Image.FromFile("C:\\Users\\Excalibur\\Desktop\\ApartmentAutomation\\Apartment\\bin\\Debug\\closeEyes.png");
                Bitmap bitmap = new Bitmap(image, 57, 54);
                btnShow.BackgroundImage = bitmap;

                txtTC.PasswordChar = '●';
            }
        }      
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (lblText.Text == "Yönetici Adınızı ve TC Kimlik Numaranızı giriniz...")
            {
                for (int i = 0; i < listAdmin.Items.Count; i++)
                {
                    if ((txtUser.Text != "" && listAdmin.Items[i].ToString().Split('\t')[0].ToLower().Trim().Contains(txtUser.Text.Trim().ToLower())) && (txtTC.Text != "" && listAdmin.Items[i].ToString().Split('\t')[1].ToLower().Trim().Contains(txtTC.Text.ToLower().Trim())))
                    {
                        Administrator administrator = new Administrator();
                        administrator.Show();
                        this.Hide();
                        break;
                    }
                    else
                    {
                        if (listAdmin.Items.Count - i == 1)
                        {
                            clean();
                            break;
                        }
                    }
                }
            }
            else
            {
                for (int j = 0; j < listResident.Items.Count; j++)
                {
                    if ((txtUser.Text != "" && listResident.Items[j].ToString().Split('\t')[0].ToLower().Trim().Contains(txtUser.Text.ToLower().Trim())) && (txtTC.Text != "" && listResident.Items[j].ToString().Split('\t')[1].ToLower().Trim().Contains(txtTC.Text.ToLower().Trim())))
                    {
                        Resident residentForm = new Resident();
                        residentForm.lblName.Text = listResident.Items[j].ToString().Split('\t')[0];                       
                        residentForm.Show();
                        
                        this.Hide();
                        break;
                    }
                    else
                    {
                        if (listResident.Items.Count - j == 1)
                        {
                            clean();
                            break;
                        }
                    }
                }
            }
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar!= 8)
            {
                e.Handled = true; // rakam ve backspace değilse tut
                // backspace in ASCI kodu 8 dir.

                // Handled: Klavyeden girilen karakterin tutulması yani engellenmesini sağlar. True/False
                // KeyChar: Klavyeden basılan karakterin alınmasını sağlar.
            }
        }
    }
}
