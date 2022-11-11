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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_user = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label_date = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_mostra_password = new System.Windows.Forms.PictureBox();
            this.pictureBox_bcc = new System.Windows.Forms.PictureBox();
            this.label_error = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.button_accedi = new Progetto_Banca_Client.button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mostra_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bcc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.textBox_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_username.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(96, 236);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(224, 22);
            this.textBox_username.TabIndex = 3;
            // 
            // textBox_password
            // 
            this.textBox_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_password.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(96, 300);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(224, 22);
            this.textBox_password.TabIndex = 4;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // label_user
            // 
            this.label_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_user.Location = new System.Drawing.Point(93, 217);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(71, 16);
            this.label_user.TabIndex = 5;
            this.label_user.Text = "Username:";
            // 
            // label_password
            // 
            this.label_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_password.Location = new System.Drawing.Point(95, 281);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(69, 16);
            this.label_password.TabIndex = 6;
            this.label_password.Text = "Password:";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_date.Location = new System.Drawing.Point(3, 537);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(65, 15);
            this.label_date.TabIndex = 8;
            this.label_date.Text = "label_date";
            // 
            // label_login
            // 
            this.label_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_login.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.Location = new System.Drawing.Point(92, 167);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(232, 23);
            this.label_login.TabIndex = 11;
            this.label_login.Text = "Login";
            this.label_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::Progetto_Banca_Client.Properties.Resources.Q4797j0E_400x400;
            this.pictureBox1.Location = new System.Drawing.Point(374, 524);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox_mostra_password
            // 
            this.pictureBox_mostra_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_mostra_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_mostra_password.Image = global::Progetto_Banca_Client.Properties.Resources._495_4950508_show_password_show_password_icon_png_transparent_png;
            this.pictureBox_mostra_password.Location = new System.Drawing.Point(326, 300);
            this.pictureBox_mostra_password.Name = "pictureBox_mostra_password";
            this.pictureBox_mostra_password.Size = new System.Drawing.Size(28, 22);
            this.pictureBox_mostra_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_mostra_password.TabIndex = 9;
            this.pictureBox_mostra_password.TabStop = false;
            this.pictureBox_mostra_password.Click += new System.EventHandler(this.pictureBox_mostra_password_Click);
            this.pictureBox_mostra_password.MouseHover += new System.EventHandler(this.pictureBox_mostra_password_MouseHover);
            // 
            // pictureBox_bcc
            // 
            this.pictureBox_bcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_bcc.Image = global::Progetto_Banca_Client.Properties.Resources.LogoBcc;
            this.pictureBox_bcc.Location = new System.Drawing.Point(130, 21);
            this.pictureBox_bcc.Name = "pictureBox_bcc";
            this.pictureBox_bcc.Size = new System.Drawing.Size(157, 63);
            this.pictureBox_bcc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_bcc.TabIndex = 0;
            this.pictureBox_bcc.TabStop = false;
            this.pictureBox_bcc.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(121, 202);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(174, 15);
            this.label_error.TabIndex = 14;
            this.label_error.Text = "Username o Password errati.";
            this.label_error.Visible = false;
            // 
            // linkLabel
            // 
            this.linkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel.AutoSize = true;
            this.linkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel.Location = new System.Drawing.Point(204, 447);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(121, 16);
            this.linkLabel.TabIndex = 15;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Richiedi assistenza";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // button_accedi
            // 
            this.button_accedi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_accedi.BackColor = System.Drawing.Color.Green;
            this.button_accedi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_accedi.FlatAppearance.BorderSize = 0;
            this.button_accedi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_accedi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_accedi.ForeColor = System.Drawing.Color.Black;
            this.button_accedi.Location = new System.Drawing.Point(96, 378);
            this.button_accedi.Name = "button_accedi";
            this.button_accedi.Size = new System.Drawing.Size(224, 42);
            this.button_accedi.TabIndex = 13;
            this.button_accedi.Text = "ACCEDI";
            this.button_accedi.UseVisualStyleBackColor = false;
            this.button_accedi.Click += new System.EventHandler(this.button_accedi_Click);
            this.button_accedi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_accedi_KeyDown);
            this.button_accedi.MouseLeave += new System.EventHandler(this.button_accedi_MouseLeave);
            this.button_accedi.MouseHover += new System.EventHandler(this.button_accedi_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 559);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.button_accedi);
            this.Controls.Add(this.label_login);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(432, 598);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mostra_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bcc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_bcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.PictureBox pictureBox_mostra_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_login;
        private button button_accedi;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.LinkLabel linkLabel;
        public System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

