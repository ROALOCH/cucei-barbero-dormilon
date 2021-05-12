
namespace BarberoDormilon
{
    partial class HomeScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GB_Queue = new System.Windows.Forms.GroupBox();
            this.LBL_P3 = new System.Windows.Forms.Label();
            this.LBL_P2 = new System.Windows.Forms.Label();
            this.LBL_P1 = new System.Windows.Forms.Label();
            this.GB_Barber = new System.Windows.Forms.GroupBox();
            this.LBL_Barber = new System.Windows.Forms.Label();
            this.LBL_Message = new System.Windows.Forms.Label();
            this.BTN_Start = new System.Windows.Forms.Button();
            this.BTN_Exit = new System.Windows.Forms.Button();
            this.WorkerBarber = new System.ComponentModel.BackgroundWorker();
            this.WorkerQueue = new System.ComponentModel.BackgroundWorker();
            this.BTN_NewClient = new System.Windows.Forms.Button();
            this.GB_Queue.SuspendLayout();
            this.GB_Barber.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Queue
            // 
            this.GB_Queue.Controls.Add(this.LBL_P3);
            this.GB_Queue.Controls.Add(this.LBL_P2);
            this.GB_Queue.Controls.Add(this.LBL_P1);
            this.GB_Queue.Location = new System.Drawing.Point(198, 30);
            this.GB_Queue.Name = "GB_Queue";
            this.GB_Queue.Size = new System.Drawing.Size(366, 129);
            this.GB_Queue.TabIndex = 0;
            this.GB_Queue.TabStop = false;
            this.GB_Queue.Text = "Cola de Espera";
            // 
            // LBL_P3
            // 
            this.LBL_P3.BackColor = System.Drawing.Color.YellowGreen;
            this.LBL_P3.Location = new System.Drawing.Point(254, 36);
            this.LBL_P3.Name = "LBL_P3";
            this.LBL_P3.Size = new System.Drawing.Size(75, 75);
            this.LBL_P3.TabIndex = 3;
            // 
            // LBL_P2
            // 
            this.LBL_P2.BackColor = System.Drawing.Color.YellowGreen;
            this.LBL_P2.Location = new System.Drawing.Point(141, 36);
            this.LBL_P2.Name = "LBL_P2";
            this.LBL_P2.Size = new System.Drawing.Size(75, 75);
            this.LBL_P2.TabIndex = 2;
            // 
            // LBL_P1
            // 
            this.LBL_P1.BackColor = System.Drawing.Color.YellowGreen;
            this.LBL_P1.Location = new System.Drawing.Point(28, 36);
            this.LBL_P1.Name = "LBL_P1";
            this.LBL_P1.Size = new System.Drawing.Size(75, 75);
            this.LBL_P1.TabIndex = 1;
            // 
            // GB_Barber
            // 
            this.GB_Barber.Controls.Add(this.LBL_Barber);
            this.GB_Barber.Location = new System.Drawing.Point(198, 232);
            this.GB_Barber.Name = "GB_Barber";
            this.GB_Barber.Size = new System.Drawing.Size(366, 253);
            this.GB_Barber.TabIndex = 4;
            this.GB_Barber.TabStop = false;
            this.GB_Barber.Text = "Silla del Barbero";
            // 
            // LBL_Barber
            // 
            this.LBL_Barber.BackColor = System.Drawing.Color.YellowGreen;
            this.LBL_Barber.Location = new System.Drawing.Point(110, 58);
            this.LBL_Barber.Name = "LBL_Barber";
            this.LBL_Barber.Size = new System.Drawing.Size(150, 150);
            this.LBL_Barber.TabIndex = 1;
            this.LBL_Barber.Text = "DURMIENDO";
            this.LBL_Barber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Message
            // 
            this.LBL_Message.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_Message.Location = new System.Drawing.Point(587, 39);
            this.LBL_Message.Name = "LBL_Message";
            this.LBL_Message.Size = new System.Drawing.Size(151, 120);
            this.LBL_Message.TabIndex = 5;
            this.LBL_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_Start
            // 
            this.BTN_Start.BackColor = System.Drawing.Color.White;
            this.BTN_Start.FlatAppearance.BorderSize = 0;
            this.BTN_Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.BTN_Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BTN_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Start.ForeColor = System.Drawing.Color.Black;
            this.BTN_Start.Location = new System.Drawing.Point(671, 481);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(101, 33);
            this.BTN_Start.TabIndex = 6;
            this.BTN_Start.Text = "INICIAR";
            this.BTN_Start.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Start.UseVisualStyleBackColor = false;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.BackColor = System.Drawing.Color.White;
            this.BTN_Exit.Enabled = false;
            this.BTN_Exit.FlatAppearance.BorderSize = 0;
            this.BTN_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.BTN_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BTN_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Exit.ForeColor = System.Drawing.Color.Black;
            this.BTN_Exit.Location = new System.Drawing.Point(671, 520);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(101, 33);
            this.BTN_Exit.TabIndex = 7;
            this.BTN_Exit.Text = "TERMINAR";
            this.BTN_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Exit.UseVisualStyleBackColor = false;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            // 
            // WorkerBarber
            // 
            this.WorkerBarber.WorkerReportsProgress = true;
            this.WorkerBarber.WorkerSupportsCancellation = true;
            this.WorkerBarber.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WorkerBarber_DoWork);
            this.WorkerBarber.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.WorkerBarber_ProgressChanged);
            // 
            // WorkerQueue
            // 
            this.WorkerQueue.WorkerReportsProgress = true;
            this.WorkerQueue.WorkerSupportsCancellation = true;
            this.WorkerQueue.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WorkerQueue_DoWork);
            this.WorkerQueue.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.WorkerQueue_ProgressChanged);
            // 
            // BTN_NewClient
            // 
            this.BTN_NewClient.BackColor = System.Drawing.Color.White;
            this.BTN_NewClient.Enabled = false;
            this.BTN_NewClient.FlatAppearance.BorderSize = 0;
            this.BTN_NewClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.BTN_NewClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BTN_NewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NewClient.ForeColor = System.Drawing.Color.Black;
            this.BTN_NewClient.Location = new System.Drawing.Point(629, 185);
            this.BTN_NewClient.Name = "BTN_NewClient";
            this.BTN_NewClient.Size = new System.Drawing.Size(143, 33);
            this.BTN_NewClient.TabIndex = 8;
            this.BTN_NewClient.Text = "NUEVO CLIENTE";
            this.BTN_NewClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_NewClient.UseVisualStyleBackColor = false;
            this.BTN_NewClient.Click += new System.EventHandler(this.BTN_NewClient_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BTN_NewClient);
            this.Controls.Add(this.BTN_Exit);
            this.Controls.Add(this.BTN_Start);
            this.Controls.Add(this.LBL_Message);
            this.Controls.Add(this.GB_Barber);
            this.Controls.Add(this.GB_Queue);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeScreen";
            this.GB_Queue.ResumeLayout(false);
            this.GB_Barber.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Queue;
        private System.Windows.Forms.Label LBL_P3;
        private System.Windows.Forms.Label LBL_P2;
        private System.Windows.Forms.Label LBL_P1;
        private System.Windows.Forms.GroupBox GB_Barber;
        private System.Windows.Forms.Label LBL_Barber;
        private System.Windows.Forms.Label LBL_Message;
        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.Button BTN_Exit;
        private System.ComponentModel.BackgroundWorker WorkerBarber;
        private System.ComponentModel.BackgroundWorker WorkerQueue;
        private System.Windows.Forms.Button BTN_NewClient;
    }
}