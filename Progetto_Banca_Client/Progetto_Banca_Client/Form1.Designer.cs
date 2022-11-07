namespace Progetto_Banca_Client
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_bcc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bcc)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_bcc
            // 
            this.pictureBox_bcc.Image = global::Progetto_Banca_Client.Properties.Resources.LogoBcc;
            this.pictureBox_bcc.Location = new System.Drawing.Point(114, 34);
            this.pictureBox_bcc.Name = "pictureBox_bcc";
            this.pictureBox_bcc.Size = new System.Drawing.Size(157, 63);
            this.pictureBox_bcc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_bcc.TabIndex = 0;
            this.pictureBox_bcc.TabStop = false;
            this.pictureBox_bcc.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 559);
            this.Controls.Add(this.pictureBox_bcc);
            this.Name = "Form1";
            this.Text = "Login Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bcc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_bcc;
    }
}

