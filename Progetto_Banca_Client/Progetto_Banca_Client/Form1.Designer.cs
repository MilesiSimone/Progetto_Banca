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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_accedi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_user = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label_date = new System.Windows.Forms.Label();
            this.pictureBox_mostra_password = new System.Windows.Forms.PictureBox();
            this.pictureBox_bcc = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mostra_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_accedi
            // 
            this.button_accedi.AutoEllipsis = true;
            this.button_accedi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_accedi.BackColor = System.Drawing.Color.Green;
            this.button_accedi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_accedi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_accedi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_accedi.Location = new System.Drawing.Point(96, 386);
            this.button_accedi.Name = "button_accedi";
            this.button_accedi.Size = new System.Drawing.Size(224, 42);
            this.button_accedi.TabIndex = 0;
            this.button_accedi.Text = "ACCEDI";
            this.button_accedi.UseVisualStyleBackColor = false;
            this.button_accedi.MouseLeave += new System.EventHandler(this.button_accedi_MouseLeave);
            this.button_accedi.MouseHover += new System.EventHandler(this.button_accedi_MouseHover);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Siamo felici di rivederti.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(96, 236);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(224, 22);
            this.textBox_username.TabIndex = 3;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(96, 300);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(224, 22);
            this.textBox_password.TabIndex = 4;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_user.Location = new System.Drawing.Point(93, 217);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(70, 16);
            this.label_user.TabIndex = 5;
            this.label_user.Text = "Username:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_password.Location = new System.Drawing.Point(95, 281);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(68, 16);
            this.label_password.TabIndex = 6;
            this.label_password.Text = "Password:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox1.Location = new System.Drawing.Point(96, 339);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Resta connesso";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_date.Location = new System.Drawing.Point(3, 537);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(65, 15);
            this.label_date.TabIndex = 8;
            this.label_date.Text = "label_date";
            // 
            // pictureBox_mostra_password
            // 
            this.pictureBox_mostra_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_mostra_password.Image = global::Progetto_Banca_Client.Properties.Resources._495_4950508_show_password_show_password_icon_png_transparent_png;
            this.pictureBox_mostra_password.Location = new System.Drawing.Point(326, 300);
            this.pictureBox_mostra_password.Name = "pictureBox_mostra_password";
            this.pictureBox_mostra_password.Size = new System.Drawing.Size(28, 22);
            this.pictureBox_mostra_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_mostra_password.TabIndex = 9;
            this.pictureBox_mostra_password.TabStop = false;
            this.pictureBox_mostra_password.Click += new System.EventHandler(this.pictureBox_mostra_password_Click);
            // 
            // pictureBox_bcc
            // 
            this.pictureBox_bcc.Image = global::Progetto_Banca_Client.Properties.Resources.LogoBcc;
            this.pictureBox_bcc.Location = new System.Drawing.Point(130, 21);
            this.pictureBox_bcc.Name = "pictureBox_bcc";
            this.pictureBox_bcc.Size = new System.Drawing.Size(157, 63);
            this.pictureBox_bcc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_bcc.TabIndex = 0;
            this.pictureBox_bcc.TabStop = false;
            this.pictureBox_bcc.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Progetto_Banca_Client.Properties.Resources.Q4797j0E_400x400;
            this.pictureBox1.Location = new System.Drawing.Point(374, 524);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 559);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox_mostra_password);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_bcc);
            this.Controls.Add(this.button_accedi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mostra_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_bcc;
        private System.Windows.Forms.Button button_accedi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.PictureBox pictureBox_mostra_password;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

