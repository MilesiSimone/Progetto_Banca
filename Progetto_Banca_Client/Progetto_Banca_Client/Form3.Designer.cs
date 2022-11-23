namespace Progetto_Banca_Client
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label_date = new System.Windows.Forms.Label();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_conto_ben = new System.Windows.Forms.Label();
            this.textBox_iban = new System.Windows.Forms.TextBox();
            this.label_dati = new System.Windows.Forms.Label();
            this.label_importo = new System.Windows.Forms.Label();
            this.textBox_importo = new System.Windows.Forms.TextBox();
            this.label_causale = new System.Windows.Forms.Label();
            this.textBox_causale = new System.Windows.Forms.TextBox();
            this.label_det_fisc = new System.Windows.Forms.Label();
            this.checkBox_det_fisc = new System.Windows.Forms.CheckBox();
            this.label_tipo_bon = new System.Windows.Forms.Label();
            this.checkBox_bon_ordinario = new System.Windows.Forms.CheckBox();
            this.checkBox_bon_istantaneo = new System.Windows.Forms.CheckBox();
            this.pictureBox_att = new System.Windows.Forms.PictureBox();
            this.label_att_1 = new System.Windows.Forms.Label();
            this.label_att_2 = new System.Windows.Forms.Label();
            this.label_num_carta = new System.Windows.Forms.Label();
            this.label_dati_ricarica = new System.Windows.Forms.Label();
            this.button_invia_bon = new Progetto_Banca_Client.button();
            this.button_invia_ricarica = new Progetto_Banca_Client.button();
            this.comboBox_num_carta = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel_logo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_att)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label_date);
            this.panel2.Controls.Add(this.panel_logo);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 565);
            this.panel2.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 350);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(180, 85);
            this.button4.TabIndex = 12;
            this.button4.Text = "Pagamenti";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::Progetto_Banca_Client.Properties.Resources.icons8_carte_bancarie_40;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 265);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(180, 85);
            this.button3.TabIndex = 11;
            this.button3.Text = "Ricarica Carta";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::Progetto_Banca_Client.Properties.Resources.icons8_24_40;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 180);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(180, 85);
            this.button2.TabIndex = 10;
            this.button2.Text = "F24";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::Progetto_Banca_Client.Properties.Resources.icons8_frecce_direzionali_40;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 95);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(180, 85);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bonifici";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_date
            // 
            this.label_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_date.Location = new System.Drawing.Point(12, 539);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(65, 15);
            this.label_date.TabIndex = 9;
            this.label_date.Text = "label_date";
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.White;
            this.panel_logo.BackgroundImage = global::Progetto_Banca_Client.Properties.Resources.LogoBcc;
            this.panel_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_logo.Controls.Add(this.panel3);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(180, 95);
            this.panel_logo.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCoral;
            this.panel3.Location = new System.Drawing.Point(178, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(759, 470);
            this.panel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 95);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(512, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "OPERAZIONI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_conto_ben
            // 
            this.label_conto_ben.AutoSize = true;
            this.label_conto_ben.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_conto_ben.Location = new System.Drawing.Point(279, 159);
            this.label_conto_ben.Name = "label_conto_ben";
            this.label_conto_ben.Size = new System.Drawing.Size(125, 16);
            this.label_conto_ben.TabIndex = 3;
            this.label_conto_ben.Text = "Conto Beneficiario";
            this.label_conto_ben.Visible = false;
            // 
            // textBox_iban
            // 
            this.textBox_iban.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_iban.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_iban.Location = new System.Drawing.Point(282, 178);
            this.textBox_iban.MaxLength = 27;
            this.textBox_iban.Name = "textBox_iban";
            this.textBox_iban.Size = new System.Drawing.Size(209, 22);
            this.textBox_iban.TabIndex = 4;
            this.textBox_iban.Visible = false;
            this.textBox_iban.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_iban_KeyPress);
            // 
            // label_dati
            // 
            this.label_dati.AutoSize = true;
            this.label_dati.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dati.Location = new System.Drawing.Point(320, 264);
            this.label_dati.Name = "label_dati";
            this.label_dati.Size = new System.Drawing.Size(108, 16);
            this.label_dati.TabIndex = 5;
            this.label_dati.Text = "Dati operazione:";
            this.label_dati.Visible = false;
            // 
            // label_importo
            // 
            this.label_importo.AutoSize = true;
            this.label_importo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_importo.Location = new System.Drawing.Point(279, 305);
            this.label_importo.Name = "label_importo";
            this.label_importo.Size = new System.Drawing.Size(56, 16);
            this.label_importo.TabIndex = 6;
            this.label_importo.Text = "Importo";
            this.label_importo.Visible = false;
            // 
            // textBox_importo
            // 
            this.textBox_importo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_importo.Location = new System.Drawing.Point(282, 326);
            this.textBox_importo.Name = "textBox_importo";
            this.textBox_importo.Size = new System.Drawing.Size(209, 22);
            this.textBox_importo.TabIndex = 7;
            this.textBox_importo.Text = "0,00 €";
            this.textBox_importo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_importo.Visible = false;
            this.textBox_importo.Click += new System.EventHandler(this.textBox_importo_Click);
            this.textBox_importo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_importo_KeyPress);
            this.textBox_importo.Leave += new System.EventHandler(this.textBox_importo_MouseLeave);
            // 
            // label_causale
            // 
            this.label_causale.AutoSize = true;
            this.label_causale.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_causale.Location = new System.Drawing.Point(279, 363);
            this.label_causale.Name = "label_causale";
            this.label_causale.Size = new System.Drawing.Size(58, 16);
            this.label_causale.TabIndex = 8;
            this.label_causale.Text = "Causale";
            this.label_causale.Visible = false;
            // 
            // textBox_causale
            // 
            this.textBox_causale.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_causale.Location = new System.Drawing.Point(282, 382);
            this.textBox_causale.Name = "textBox_causale";
            this.textBox_causale.Size = new System.Drawing.Size(209, 22);
            this.textBox_causale.TabIndex = 9;
            this.textBox_causale.Visible = false;
            // 
            // label_det_fisc
            // 
            this.label_det_fisc.AutoSize = true;
            this.label_det_fisc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_det_fisc.Location = new System.Drawing.Point(636, 159);
            this.label_det_fisc.Name = "label_det_fisc";
            this.label_det_fisc.Size = new System.Drawing.Size(176, 16);
            this.label_det_fisc.TabIndex = 10;
            this.label_det_fisc.Text = "Bonifico detrazione fiscale";
            this.label_det_fisc.Visible = false;
            // 
            // checkBox_det_fisc
            // 
            this.checkBox_det_fisc.AutoSize = true;
            this.checkBox_det_fisc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_det_fisc.Location = new System.Drawing.Point(639, 180);
            this.checkBox_det_fisc.Name = "checkBox_det_fisc";
            this.checkBox_det_fisc.Size = new System.Drawing.Size(199, 20);
            this.checkBox_det_fisc.TabIndex = 11;
            this.checkBox_det_fisc.Text = "Bonifico per detrazione fiscale";
            this.checkBox_det_fisc.UseVisualStyleBackColor = true;
            this.checkBox_det_fisc.Visible = false;
            // 
            // label_tipo_bon
            // 
            this.label_tipo_bon.AutoSize = true;
            this.label_tipo_bon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tipo_bon.Location = new System.Drawing.Point(636, 307);
            this.label_tipo_bon.Name = "label_tipo_bon";
            this.label_tipo_bon.Size = new System.Drawing.Size(90, 16);
            this.label_tipo_bon.TabIndex = 12;
            this.label_tipo_bon.Text = "Tipo bonifico";
            this.label_tipo_bon.Visible = false;
            // 
            // checkBox_bon_ordinario
            // 
            this.checkBox_bon_ordinario.AutoSize = true;
            this.checkBox_bon_ordinario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_bon_ordinario.Location = new System.Drawing.Point(639, 326);
            this.checkBox_bon_ordinario.Name = "checkBox_bon_ordinario";
            this.checkBox_bon_ordinario.Size = new System.Drawing.Size(125, 20);
            this.checkBox_bon_ordinario.TabIndex = 13;
            this.checkBox_bon_ordinario.Text = "Bonifico ordinario";
            this.checkBox_bon_ordinario.UseVisualStyleBackColor = true;
            this.checkBox_bon_ordinario.Visible = false;
            this.checkBox_bon_ordinario.Click += new System.EventHandler(this.checkBox_bon_ordinario_Click);
            // 
            // checkBox_bon_istantaneo
            // 
            this.checkBox_bon_istantaneo.AutoSize = true;
            this.checkBox_bon_istantaneo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_bon_istantaneo.Location = new System.Drawing.Point(639, 352);
            this.checkBox_bon_istantaneo.Name = "checkBox_bon_istantaneo";
            this.checkBox_bon_istantaneo.Size = new System.Drawing.Size(136, 20);
            this.checkBox_bon_istantaneo.TabIndex = 14;
            this.checkBox_bon_istantaneo.Text = "Bonifico istantaneo";
            this.checkBox_bon_istantaneo.UseMnemonic = false;
            this.checkBox_bon_istantaneo.UseVisualStyleBackColor = true;
            this.checkBox_bon_istantaneo.Visible = false;
            this.checkBox_bon_istantaneo.Click += new System.EventHandler(this.checkBox_bon_istantaneo_Click);
            // 
            // pictureBox_att
            // 
            this.pictureBox_att.Image = global::Progetto_Banca_Client.Properties.Resources.icons8_attenzione_96;
            this.pictureBox_att.Location = new System.Drawing.Point(529, 233);
            this.pictureBox_att.Name = "pictureBox_att";
            this.pictureBox_att.Size = new System.Drawing.Size(96, 96);
            this.pictureBox_att.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_att.TabIndex = 18;
            this.pictureBox_att.TabStop = false;
            this.pictureBox_att.Visible = false;
            // 
            // label_att_1
            // 
            this.label_att_1.AutoSize = true;
            this.label_att_1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_att_1.Location = new System.Drawing.Point(381, 351);
            this.label_att_1.Name = "label_att_1";
            this.label_att_1.Size = new System.Drawing.Size(406, 18);
            this.label_att_1.TabIndex = 19;
            this.label_att_1.Text = "Non puoi ancora consultare questa tipologia di prodotto.";
            this.label_att_1.Visible = false;
            // 
            // label_att_2
            // 
            this.label_att_2.AutoSize = true;
            this.label_att_2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_att_2.Location = new System.Drawing.Point(420, 377);
            this.label_att_2.Name = "label_att_2";
            this.label_att_2.Size = new System.Drawing.Size(355, 18);
            this.label_att_2.TabIndex = 20;
            this.label_att_2.Text = "Stiamo lavorando per offrirti un servizio migliore!";
            this.label_att_2.Visible = false;
            // 
            // label_num_carta
            // 
            this.label_num_carta.AutoSize = true;
            this.label_num_carta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_num_carta.Location = new System.Drawing.Point(279, 248);
            this.label_num_carta.Name = "label_num_carta";
            this.label_num_carta.Size = new System.Drawing.Size(93, 16);
            this.label_num_carta.TabIndex = 21;
            this.label_num_carta.Text = "Numero carta";
            this.label_num_carta.Visible = false;
            // 
            // label_dati_ricarica
            // 
            this.label_dati_ricarica.AutoSize = true;
            this.label_dati_ricarica.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dati_ricarica.Location = new System.Drawing.Point(336, 215);
            this.label_dati_ricarica.Name = "label_dati_ricarica";
            this.label_dati_ricarica.Size = new System.Drawing.Size(104, 16);
            this.label_dati_ricarica.TabIndex = 23;
            this.label_dati_ricarica.Text = "Dati operazione";
            this.label_dati_ricarica.Visible = false;
            // 
            // button_invia_bon
            // 
            this.button_invia_bon.BackColor = System.Drawing.Color.Green;
            this.button_invia_bon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_invia_bon.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button_invia_bon.FlatAppearance.BorderSize = 0;
            this.button_invia_bon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_invia_bon.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_invia_bon.ForeColor = System.Drawing.Color.White;
            this.button_invia_bon.Location = new System.Drawing.Point(719, 455);
            this.button_invia_bon.Name = "button_invia_bon";
            this.button_invia_bon.Size = new System.Drawing.Size(157, 62);
            this.button_invia_bon.TabIndex = 17;
            this.button_invia_bon.Text = "INVIA";
            this.button_invia_bon.UseVisualStyleBackColor = false;
            this.button_invia_bon.Visible = false;
            this.button_invia_bon.Click += new System.EventHandler(this.button_invia_bon_Click);
            // 
            // button_invia_ricarica
            // 
            this.button_invia_ricarica.BackColor = System.Drawing.Color.Green;
            this.button_invia_ricarica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_invia_ricarica.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button_invia_ricarica.FlatAppearance.BorderSize = 0;
            this.button_invia_ricarica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_invia_ricarica.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_invia_ricarica.ForeColor = System.Drawing.Color.White;
            this.button_invia_ricarica.Location = new System.Drawing.Point(588, 280);
            this.button_invia_ricarica.Name = "button_invia_ricarica";
            this.button_invia_ricarica.Size = new System.Drawing.Size(157, 62);
            this.button_invia_ricarica.TabIndex = 24;
            this.button_invia_ricarica.Text = "INVIA";
            this.button_invia_ricarica.UseVisualStyleBackColor = false;
            this.button_invia_ricarica.Visible = false;
            // 
            // comboBox_num_carta
            // 
            this.comboBox_num_carta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_num_carta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_num_carta.FormattingEnabled = true;
            this.comboBox_num_carta.Location = new System.Drawing.Point(283, 267);
            this.comboBox_num_carta.MaxLength = 16;
            this.comboBox_num_carta.Name = "comboBox_num_carta";
            this.comboBox_num_carta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_num_carta.Size = new System.Drawing.Size(208, 24);
            this.comboBox_num_carta.TabIndex = 25;
            this.comboBox_num_carta.Visible = false;
            this.comboBox_num_carta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(937, 563);
            this.Controls.Add(this.comboBox_num_carta);
            this.Controls.Add(this.label_dati_ricarica);
            this.Controls.Add(this.label_num_carta);
            this.Controls.Add(this.label_att_2);
            this.Controls.Add(this.pictureBox_att);
            this.Controls.Add(this.button_invia_bon);
            this.Controls.Add(this.checkBox_bon_istantaneo);
            this.Controls.Add(this.checkBox_bon_ordinario);
            this.Controls.Add(this.label_tipo_bon);
            this.Controls.Add(this.checkBox_det_fisc);
            this.Controls.Add(this.label_det_fisc);
            this.Controls.Add(this.textBox_causale);
            this.Controls.Add(this.label_causale);
            this.Controls.Add(this.textBox_importo);
            this.Controls.Add(this.label_importo);
            this.Controls.Add(this.label_dati);
            this.Controls.Add(this.textBox_iban);
            this.Controls.Add(this.label_conto_ben);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_invia_ricarica);
            this.Controls.Add(this.label_att_1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(953, 602);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area_Personale Operazioni";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_logo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_att)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_conto_ben;
        private System.Windows.Forms.TextBox textBox_iban;
        private System.Windows.Forms.Label label_dati;
        private System.Windows.Forms.Label label_importo;
        private System.Windows.Forms.TextBox textBox_importo;
        private System.Windows.Forms.Label label_causale;
        private System.Windows.Forms.TextBox textBox_causale;
        private System.Windows.Forms.Label label_det_fisc;
        private System.Windows.Forms.CheckBox checkBox_det_fisc;
        private System.Windows.Forms.Label label_tipo_bon;
        private System.Windows.Forms.CheckBox checkBox_bon_ordinario;
        private System.Windows.Forms.CheckBox checkBox_bon_istantaneo;
        private button button_invia_bon;
        private System.Windows.Forms.PictureBox pictureBox_att;
        private System.Windows.Forms.Label label_att_1;
        private System.Windows.Forms.Label label_att_2;
        private System.Windows.Forms.Label label_num_carta;
        private System.Windows.Forms.Label label_dati_ricarica;
        private button button_invia_ricarica;
        public System.Windows.Forms.ComboBox comboBox_num_carta;
    }
}