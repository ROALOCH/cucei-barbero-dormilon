
namespace BarberoDormilon
{
    partial class BarberoDormilon
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PB_Logo = new System.Windows.Forms.PictureBox();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.BTN_Start = new System.Windows.Forms.Button();
            this.NUD_Clients = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Clients)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Logo
            // 
            this.PB_Logo.Image = global::BarberoDormilon.Properties.Resources.barberoLogo;
            this.PB_Logo.Location = new System.Drawing.Point(217, 27);
            this.PB_Logo.Name = "PB_Logo";
            this.PB_Logo.Size = new System.Drawing.Size(350, 350);
            this.PB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Logo.TabIndex = 0;
            this.PB_Logo.TabStop = false;
            // 
            // LBL_Title
            // 
            this.LBL_Title.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.Location = new System.Drawing.Point(217, 365);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(350, 48);
            this.LBL_Title.TabIndex = 1;
            this.LBL_Title.Text = "Barbero Dormilón";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_Start
            // 
            this.BTN_Start.BackColor = System.Drawing.Color.White;
            this.BTN_Start.FlatAppearance.BorderSize = 0;
            this.BTN_Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.BTN_Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BTN_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Start.ForeColor = System.Drawing.Color.Black;
            this.BTN_Start.Location = new System.Drawing.Point(322, 508);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(140, 29);
            this.BTN_Start.TabIndex = 2;
            this.BTN_Start.Text = "OK";
            this.BTN_Start.UseVisualStyleBackColor = false;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // NUD_Clients
            // 
            this.NUD_Clients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NUD_Clients.Location = new System.Drawing.Point(320, 460);
            this.NUD_Clients.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NUD_Clients.Name = "NUD_Clients";
            this.NUD_Clients.Size = new System.Drawing.Size(144, 26);
            this.NUD_Clients.TabIndex = 4;
            this.NUD_Clients.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_Clients.ValueChanged += new System.EventHandler(this.NUD_Clients_ValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(217, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número de Clientes Iniciales";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BarberoDormilon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.NUD_Clients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Start);
            this.Controls.Add(this.LBL_Title);
            this.Controls.Add(this.PB_Logo);
            this.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BarberoDormilon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarberoDormilon";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Clients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Logo;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.NumericUpDown NUD_Clients;
        private System.Windows.Forms.Label label1;
    }
}

