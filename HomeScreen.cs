using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberoDormilon
{
    public partial class HomeScreen : Form
    {
        int nClients = 0;

        // Duration in Milliseconds
        int haircutMinDuration = 1000;
        int haircutMaxDuration = 4000;

        String colorEmpty = "YellowGreen";
        String colorOccupied = "DarkRed";

        String msgIdle = "DURMIENDO";
        String msgBussy = "TRABAJANDO";

        String bussyMsg = "¡ESTA LLENO! REGRESO LUEGO";

        Random randomInt = new Random();

        public HomeScreen(int nClients)
        {
            this.nClients = nClients;
            InitializeComponent();
            updateVisualChairs(nClients);
        }

        private void queue()
        {
            if (nClients == 3)
            {
                WorkerQueue.ReportProgress(1);
                return;
            }

            nClients++;
            WorkerQueue.ReportProgress(0);
        }

        private void dequeue()
        {
            nClients--;
        }

        private void showBussyMessage()
        {
            LBL_Message.Text = bussyMsg;
            this.Refresh();
            Thread.Sleep(2000);
            LBL_Message.Text = "";
            this.Refresh();
        }

        private void updateVisualChairs(int nClients)
        {
            switch (nClients)
            {
                case 0:
                    changeChairState(LBL_P1, true);
                    changeChairState(LBL_P2, true);
                    changeChairState(LBL_P3, true);
                    break;
                case 1:
                    changeChairState(LBL_P1, false);
                    changeChairState(LBL_P2, true);
                    changeChairState(LBL_P3, true);
                    break;
                case 2:
                    changeChairState(LBL_P1, false);
                    changeChairState(LBL_P2, false);
                    changeChairState(LBL_P3, true);
                    break;
                case 3:
                    changeChairState(LBL_P1, false);
                    changeChairState(LBL_P2, false);
                    changeChairState(LBL_P3, false);
                    break;
                default: break;
            }

            this.Refresh();
        }

        private void changeChairState(Label lbl, bool empty)
        {
            String color = empty ? colorEmpty : colorOccupied;
            lbl.BackColor = Color.FromName(color);
        }
        private void changeBarberState(bool idle)
        {
            String color = idle ? colorEmpty : colorOccupied;
            String msg = idle ? msgIdle : msgBussy;

            LBL_Barber.BackColor = Color.FromName(color);
            LBL_Barber.Text = msg;

            this.Refresh();
        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            BTN_Start.Enabled = false;
            BTN_Exit.Enabled = true;
            BTN_NewClient.Enabled = true;

            WorkerBarber.RunWorkerAsync();
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            WorkerBarber.CancelAsync();
            WorkerQueue.CancelAsync();

            BTN_Start.Enabled = true;
            BTN_Exit.Enabled = false;
            BTN_NewClient.Enabled = false;
        }

        private void barberStartWorking()
        {
            if (nClients > 0)
            {
                WorkerBarber.ReportProgress(1);
                dequeue();

                int haircutDuration = randomInt.Next(haircutMinDuration, haircutMaxDuration);
                Thread.Sleep(haircutDuration);
            }
            else
            {
                WorkerBarber.ReportProgress(0);
            }

        }

        private void WorkerBarber_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                barberStartWorking();

                if (WorkerBarber.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
            }
        }

        private void WorkerBarber_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // 0 for Idle, 1 for Bussy
            int workerState = e.ProgressPercentage;
            bool idle = true;

            switch (workerState)
            {
                case 0: idle = true; WorkerBarber.CancelAsync(); break;
                case 1: idle = false; break;
                default: break;
            }

            changeBarberState(idle);
            updateVisualChairs(nClients);
        }

        private void WorkerQueue_DoWork(object sender, DoWorkEventArgs e)
        {
            queue();
            WorkerQueue.CancelAsync();

            if (WorkerQueue.CancellationPending == true)
            {
                e.Cancel = true;
                return;
            }
        }

        private void WorkerQueue_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // 0 for Update, 1 for Full
            int workerState = e.ProgressPercentage;

            switch (workerState)
            {
                case 0: updateVisualChairs(nClients); break;
                case 1: showBussyMessage(); break;
                default: break;
            }
        }

        private void BTN_NewClient_Click(object sender, EventArgs e)
        {
            queue();

            if (WorkerBarber.IsBusy != true)
            {
                WorkerBarber.RunWorkerAsync();
            }
        }
    }
}
