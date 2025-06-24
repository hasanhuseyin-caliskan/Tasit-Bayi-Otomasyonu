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
    public partial class AutomobilesPage : Form
    {
        public AutomobilesPage()
        {
            InitializeComponent();
        }

        private void AutomobilesPage_Load(object sender, EventArgs e)
        {
            carDateLbl.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void AutomobilesPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void carsGoBack_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Automobile automobile = new Automobile();
            automobile.date = DateTime.Now;
            automobile.id = maskedTextBox1.Text;
            automobile.brand = textBox1.Text;
            automobile.model = textBox2.Text;
            automobile.year = maskedTextBox2.Text;
            automobile.displacement = maskedTextBox3.Text;
            automobile.horsepower = maskedTextBox4.Text;
            automobile.color = textBox3.Text;

            String[] autoList = { automobile.date.ToString(), automobile.id, automobile.brand, automobile.model, automobile.year, automobile.displacement, automobile.horsepower, automobile.color };

            ListViewItem lst = new ListViewItem(autoList);

            bool checkSystem = false;
            for (int i = 0; i < listViewCars.Items.Count; i++)
            {
                if (listViewCars.Items[i].SubItems[0].Text == maskedTextBox1.Text)
                {
                    checkSystem = true;
                    MessageBox.Show(maskedTextBox1.Text + " ID numaralı otomobil zaten mevcut.");
                }
            }
            if (checkSystem == false)
            {
                if (automobile.id != "" && automobile.brand != "" && automobile.model != "" && automobile.year != "" && automobile.displacement != "" && automobile.horsepower !="" && automobile.color !="")
                {
                    listViewCars.Items.Add(lst);
                }
                else
                {
                    MessageBox.Show("Kayıt bilgilerinde eksiklikler var!");
                }
            }
        }

        private void carClearButton_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear(); textBox1.Clear(); textBox2.Clear(); maskedTextBox2.Clear(); maskedTextBox3.Clear(); maskedTextBox4.Clear(); textBox3.Clear();
        }

        private void carDeleteButton_Click(object sender, EventArgs e)
        {
            int choice = listViewCars.CheckedItems.Count;

            foreach (ListViewItem savedItems in listViewCars.CheckedItems)
            {
                savedItems.Remove();
            }
            MessageBox.Show(choice.ToString() + " adet kayıt silindi.");
        }
    }
}
