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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName=userNameTextBox.Text;
            string userPassword=userPasswordTextBox.Text;

            if(userName=="admin"&&userPassword=="1234")
            {
                MainPage mainPage = new MainPage();
                this.Hide();
                mainPage.Show();
            }
            else
            {
                MessageBox.Show("Giriş başarısız.");
            }
        }
    }
}
