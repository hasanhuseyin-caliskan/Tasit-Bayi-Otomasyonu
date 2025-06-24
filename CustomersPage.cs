using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OTOMOTIV_BAYI_OTOMASYONU
{
    public partial class CustomersPage : Form
    {
        public CustomersPage()
        {
            InitializeComponent();
        }

        private void CustomersPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void customerGoBack_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void customerAddButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.TCno = cusTCBox.Text;
            customer.name=cusNameBox.Text;
            customer.surname=cusSurnameBox.Text;
            customer.email=cusEmailBox.Text;
            customer.phoneNumber=cusTelBox.Text;
            customer.licenseClass=cusLicenseBox.Text;

            String[] cusList = { customer.TCno, customer.name, customer.surname, customer.email, customer.phoneNumber, customer.licenseClass};

            ListViewItem lst = new ListViewItem(cusList);

            bool checkSystem = false;
            for (int i = 0; i < listView.Items.Count; i++)
            {
                if (listView.Items[i].SubItems[0].Text == cusTCBox.Text)
                {
                    checkSystem = true;
                    MessageBox.Show(cusTCBox.Text + " kimlik numaralı müşteri zaten mevcut.");
                }
            }
            if (checkSystem == false)
            {
                if (customer.TCno != "" && customer.name != "" && customer.surname != "" && customer.email != "" && customer.phoneNumber != "" && customer.licenseClass != "")
                {
                    listView.Items.Add(lst);
                }
                else
                {
                    MessageBox.Show("Kayıt bilgilerinde eksiklikler var!");
                }
            }
        }
        private void customerDeleteButton_Click(object sender, EventArgs e)
        {
            int choice = listView.CheckedItems.Count;

            foreach (ListViewItem savedItems in listView.CheckedItems)
            {
                savedItems.Remove();
            }
            MessageBox.Show(choice.ToString() + " adet kayıt silindi.");
        }

        private void customerClearButton_Click(object sender, EventArgs e)
        {
            cusTCBox.Clear(); cusNameBox.Clear(); cusSurnameBox.Clear(); cusEmailBox.Clear(); cusTelBox.Clear(); cusLicenseBox.Clear();
        }
    }
}
