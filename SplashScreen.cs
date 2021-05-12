using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberoDormilon
{
    public partial class BarberoDormilon : Form
    {
        int nClients = 0;
        public BarberoDormilon()
        {
            InitializeComponent();
        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen(nClients);
            homeScreen.Show();
            this.Hide();
        }

        private void NUD_Clients_ValueChanged(object sender, EventArgs e)
        {
            nClients = (int)NUD_Clients.Value;
        }
    }
}
