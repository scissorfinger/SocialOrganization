using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialOrganization.Forms
{
    public partial class formsDashboard : Form
    {
        public formsDashboard()
        {
            InitializeComponent();
            dashboardUC1.BringToFront();
            labelTitle.Text = "Dashboard";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboardUC1.BringToFront();
            labelTitle.Text = "Dashboard";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            donersUC1.BringToFront();
            labelTitle.Text = "Dodaj lub zaktualizuj rekord.";
        }
    }
}
