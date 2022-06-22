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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        string filePathResidents = @"C:\Users\Excalibur\Desktop\ApartmentAutomation\Apartment\bin\Debug\DATA\residents.txt";

        // When the form screen is opened, the data comes to the listViewHirers
        private void Administrator_Load(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream(filePathResidents, FileMode.Open, FileAccess.Read);

            using (StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    int sira = listViewHirers.Items.Count;

                    listViewHirers.Items.Add(line.Split('\t')[0]);
                    listViewHirers.Items[sira].SubItems.Add(line.Split('\t')[1]);
                    listViewHirers.Items[sira].SubItems.Add(line.Split('\t')[2]);
                    listViewHirers.Items[sira].SubItems.Add(line.Split('\t')[3]);
                    listViewHirers.Items[sira].SubItems.Add(line.Split('\t')[4]);
                    listViewHirers.Items[sira].SubItems.Add(line.Split('\t')[5]);
                    listViewHirers.Items[sira].SubItems.Add(line.Split('\t')[6]);
                    listViewHirers.Items[sira].SubItems.Add(line.Split('\t')[7]);
                }
                fileStream.Flush();
                fileStream.Close();
                streamReader.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserChoice user = new UserChoice();
            user.Show();
            this.Hide();
        }

        AddRecord addRecord = new AddRecord();
        public void rowAdd()
        {
            DialogResult result = addRecord.ShowDialog();
            if (result == DialogResult.OK)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = addRecord.txtName.Text;
                listViewItem.SubItems.Add(addRecord.mskTC.Text);
                listViewItem.SubItems.Add(addRecord.mskPhone.Text);
                listViewItem.SubItems.Add(addRecord.mskDate.Text);
                if (addRecord.radioBtnHirer.Checked == true) listViewItem.SubItems.Add(addRecord.radioBtnHirer.Text);
                else listViewItem.SubItems.Add(addRecord.radioBtnHost.Text);
                listViewItem.SubItems.Add(addRecord.txtRent.Text);
                if (addRecord.radioBtnPayYes.Checked == true) listViewItem.SubItems.Add(addRecord.radioBtnPayYes.Text);
                else listViewItem.SubItems.Add(addRecord.radioBtnPayNo.Text);
                listViewItem.SubItems.Add(addRecord.txtRentDebt.Text);

                listViewHirers.Items.Add(listViewItem);               
            }

            addRecord.txtName.Text = "";
            addRecord.txtRent.Text = "";
            addRecord.txtRentDebt.Text = "";
            addRecord.mskDate.Text = "";
            addRecord.mskPhone.Text = "";
            addRecord.mskTC.Text = "";
            addRecord.radioBtnHirer.Checked = false;
            addRecord.radioBtnHost.Checked = false;
            addRecord.radioBtnPayNo.Checked = false;
            addRecord.radioBtnPayYes.Checked = false;
        }
        public void rowDelete()
        {
            // delete selected data in listView
            foreach (ListViewItem row in listViewHirers.SelectedItems)
            {
                listViewHirers.Items.Remove(row);
            }

            //Export the final version of listView to txt file
            using (StreamWriter streamWriter = new StreamWriter(filePathResidents))
            {
                if (listViewHirers.Items.Count > 0)
                {
                    foreach (ListViewItem listViewItem in listViewHirers.Items)
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        foreach (ListViewItem.ListViewSubItem listViewSubItem in listViewItem.SubItems)
                        {
                            stringBuilder.Append(string.Format("{0}\t", listViewSubItem.Text));
                        }
                        streamWriter.WriteLine(stringBuilder.ToString());
                    }
                    streamWriter.Close();
                }
            }
        }

        private void btnAddResident_Click(object sender, EventArgs e)
        {
            rowAdd();          
        }       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            rowDelete();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {          
            addRecord.txtName.Text = listViewHirers.SelectedItems[0].SubItems[0].Text;
            addRecord.mskTC.Text = listViewHirers.SelectedItems[0].SubItems[1].Text;
            addRecord.mskPhone.Text = listViewHirers.SelectedItems[0].SubItems[2].Text;
            addRecord.mskDate.Text = listViewHirers.SelectedItems[0].SubItems[3].Text;
            addRecord.lblRadioResident.Text = listViewHirers.SelectedItems[0].SubItems[4].Text;
            if (addRecord.lblRadioResident.Text == "Kiracı")
            {
                addRecord.radioBtnHirer.Checked = true;
                addRecord.lblRent.Visible = true;
                addRecord.txtRent.Visible = true;
                addRecord.panel1.Location = new Point(54, 313);
                addRecord.txtRent.Text = listViewHirers.SelectedItems[0].SubItems[5].Text;
            }
            else
            {
                addRecord.radioBtnHost.Checked = true;
            }
            addRecord.lblRadioYesNo.Text = listViewHirers.SelectedItems[0].SubItems[6].Text;
            if (addRecord.lblRadioYesNo.Text == "Evet")
            {
                addRecord.radioBtnPayYes.Checked = true;
            }
            else
            {
                addRecord.radioBtnPayYes.Checked = true;
            }
            addRecord.txtRentDebt.Text = listViewHirers.SelectedItems[0].SubItems[7].Text;
            addRecord.btnAdd.Text = "DÜZENLE";

            rowAdd();

            if (addRecord.lblBtnClick.Text == "Tıklandı")
            {
                rowDelete();
            }            
        }

        private void btnDues_Click(object sender, EventArgs e)
        {
            DeterminingDues determiningDues = new DeterminingDues();
            determiningDues.Show();
        }
    }
}
