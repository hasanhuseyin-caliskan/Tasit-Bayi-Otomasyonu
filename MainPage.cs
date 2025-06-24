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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void automobiles_Click(object sender, EventArgs e)
        {
            AutomobilesPage a = new AutomobilesPage();
            this.Hide();
            a.Show();
        }

        private void motocycles_Click(object sender, EventArgs e)
        {
            MotocyclesPage m = new MotocyclesPage();
            this.Hide();
            m.Show();
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            CustomersPage c = new CustomersPage();
            this.Hide();
            c.Show();
        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            carIdBox emp=new carIdBox();
            emp.Show();
            this.Hide();
        }
    }
}
