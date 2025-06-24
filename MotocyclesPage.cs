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
    public partial class MotocyclesPage : Form
    {
        public MotocyclesPage()
        {
            InitializeComponent();
        }

        private void MotocyclesPage_Load(object sender, EventArgs e)
        {
            motoDateLbl.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void MotocyclesPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void motoGoBackButton_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.Show();
        }

        private void motoAddButton_Click(object sender, EventArgs e)
        {
            Motocycle motorcycle = new Motocycle();
            motorcycle.date = DateTime.Now;
            motorcycle.id = txtID.Text;
            motorcycle.brand = txtMarka.Text;
            motorcycle.model = txtModel.Text;
            motorcycle.color = txtRenk.Text;
            motorcycle.hp = txtHp.Text;

            String[] motoList = { motorcycle.date.ToString(), motorcycle.id, motorcycle.brand, motorcycle.model, motorcycle.color, motorcycle.hp };

            ListViewItem lst = new ListViewItem(motoList);

            bool checkSystem = false;
            for (int i = 0; i < listViewMotorcycles.Items.Count; i++)
            {
                if (listViewMotorcycles.Items[i].SubItems[0].Text == txtID.Text)
                {
                    checkSystem = true;
                    MessageBox.Show(txtID.Text + " numaralı ID'ye sahip motosiklet zaten mevcut.");
                }
            }
            if (checkSystem == false)
            {
                if (motorcycle.id != "" && motorcycle.brand != "" && motorcycle.model != "" && motorcycle.color != "" && motorcycle.hp != "")
                {
                    listViewMotorcycles.Items.Add(lst);
                }
                else
                {
                    MessageBox.Show("Kayıt bilgilerinde eksiklikler var!");
                }
            }
        }

        private void motoClearButton_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtMarka.Clear();
            txtModel.Clear();
            txtRenk.Clear();
            txtHp.Clear();
        }

        private void motoDeleteButton_Click(object sender, EventArgs e)
        {
            int choice = listViewMotorcycles.CheckedItems.Count;

            foreach (ListViewItem savedItems in listViewMotorcycles.CheckedItems)
            {
                savedItems.Remove();
            }
            MessageBox.Show(choice.ToString() + " adet kayıt silindi.");
        }
    }
}
