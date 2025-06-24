using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTOMOTIV_BAYI_OTOMASYONU
{
    public partial class carIdBox : Form
    {
        public carIdBox()
        {
            InitializeComponent();
        }

        private void EmployeesPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void eGoBackButton_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void eAddButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.TCno=empTCBox.Text;
            employee.name = nameBox.Text;
            employee.surname = surnameBox.Text;
            employee.email = emailBox.Text;
            employee.age=ageBox.Text;
            employee.address= addressBox.Text;

            String[] empList = {employee.TCno, employee.name, employee.surname, employee.email, employee.age, employee.address};

            ListViewItem lst=new ListViewItem(empList);

            bool checkSystem=false;
            for(int i=0; i<listView.Items.Count; i++)
            {
                if (listView.Items[i].SubItems[0].Text == empTCBox.Text)
                {
                    checkSystem = true;
                    MessageBox.Show(empTCBox.Text + " kimlik numaralı çalışan zaten mevcut.");
                }
            }
            if (checkSystem == false)
            {
                if (employee.TCno != "" && employee.name != "" && employee.surname != "" && employee.email != "" && employee.age != "" && employee.address != "")
                {
                    listView.Items.Add(lst);
                }
                else
                {
                    MessageBox.Show("Kayıt bilgilerinde eksiklikler var!");
                }
            }
        }

        private void eDeleteButton_Click(object sender, EventArgs e)
        {
            int choice = listView.CheckedItems.Count;

            foreach (ListViewItem savedItems in listView.CheckedItems)
            {
                savedItems.Remove();
            }
            MessageBox.Show(choice.ToString() + " adet kayıt silindi.");
        }

        private void eClearButton_Click(object sender, EventArgs e)
        {
            empTCBox.Clear(); nameBox.Clear(); surnameBox.Clear(); emailBox.Clear(); ageBox.Clear(); addressBox.Clear();
        }
    }
}
