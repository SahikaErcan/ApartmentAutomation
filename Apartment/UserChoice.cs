using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartment
{
    public partial class UserChoice : Form
    {
        public UserChoice()
        {
            InitializeComponent();
        }

        private void btnAdministrator_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            login.lblText.Text = "Yönetici Adınızı ve TC Kimlik Numaranızı giriniz...";
            login.pictureBox1.Image = Image.FromFile(@"C:\Users\Excalibur\Desktop\ApartmentAutomation\Apartment\bin\Debug\admin.png");
            this.Hide();
        }

        private void btnResident_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
