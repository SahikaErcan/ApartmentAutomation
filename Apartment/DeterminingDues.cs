using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Apartment
{
    public partial class DeterminingDues : Form
    {
        public DeterminingDues()
        {
            InitializeComponent();
        }

        string fileDues = @"C:\Users\Excalibur\Desktop\ApartmentAutomation\Apartment\bin\Debug\DATA\duesCalculate.txt";
        private void DeterminingDues_Load(object sender, EventArgs e)
        {
            txtMaintenance.Text = "0";
            txtEnergy.Text = "0";
            txtOther.Text = "0";
            txtCleaning.Text = "0";
            txtLift.Text = "0";
            txtDues.Text = "40";
            lblDuesPrice.Text = txtDues.Text;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            using (StreamWriter streamWriter = new StreamWriter(fileDues))
            {
                streamWriter.WriteLine(lblDuesPrice.Text = (Convert.ToInt32(txtMaintenance.Text) + Convert.ToInt32(txtEnergy.Text) + Convert.ToInt32(txtCleaning.Text) + Convert.ToInt32(txtLift.Text) + Convert.ToInt32(txtOther.Text) + Convert.ToInt32(txtDues.Text)).ToString());
                streamWriter.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Administrator administrator = new Administrator();
            //administrator.Show();
            this.Hide();
        }
    }
}
