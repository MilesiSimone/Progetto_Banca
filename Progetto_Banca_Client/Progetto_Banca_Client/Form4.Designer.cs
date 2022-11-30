namespace Progetto_Banca_Client
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView_BON = new System.Windows.Forms.ListView();
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Iban_benficiario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Importo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_bon_view = new System.Windows.Forms.Button();
            this.button_ricariche_view = new System.Windows.Forms.Button();
            this.label_date = new System.Windows.Forms.Label();
            this.causale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.detr_fisc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bon_ordinario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bon_istantaneo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saldo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_logo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(400, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESTRATTO CONTO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.White;
            this.panel_logo.BackgroundImage = global::Progetto_Banca_Client.Properties.Resources.LogoBcc;
            this.panel_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_logo.Controls.Add(this.panel3);
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(180, 95);
            this.panel_logo.TabIndex = 3;
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
            this.panel1.Controls.Add(this.panel_logo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 95);
            this.panel1.TabIndex = 4;
            // 
            // listView_BON
            // 
            this.listView_BON.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_BON.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_BON.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Data,
            this.Ora,
            this.Iban_benficiario,
            this.Importo,
            this.causale,
            this.detr_fisc,
            this.bon_ordinario,
            this.bon_istantaneo,
            this.saldo});
            this.listView_BON.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_BON.GridLines = true;
            this.listView_BON.HideSelection = false;
            this.listView_BON.Location = new System.Drawing.Point(186, 101);
            this.listView_BON.Name = "listView_BON";
            this.listView_BON.Size = new System.Drawing.Size(602, 337);
            this.listView_BON.TabIndex = 5;
            this.listView_BON.UseCompatibleStateImageBehavior = false;
            // 
            // Data
            // 
            this.Data.Text = "DATA";
            // 
            // Ora
            // 
            this.Ora.Text = "ORA";
            // 
            // Iban_benficiario
            // 
            this.Iban_benficiario.Text = "IBAN BENEFICIARIO";
            // 
            // Importo
            // 
            this.Importo.Text = "IMPORTO";
            // 
            // button_bon_view
            // 
            this.button_bon_view.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_bon_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_bon_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_bon_view.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button_bon_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bon_view.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bon_view.ForeColor = System.Drawing.Color.Black;
            this.button_bon_view.Image = global::Progetto_Banca_Client.Properties.Resources.icons8_frecce_direzionali_40;
            this.button_bon_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_bon_view.Location = new System.Drawing.Point(0, 160);
            this.button_bon_view.Name = "button_bon_view";
            this.button_bon_view.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button_bon_view.Size = new System.Drawing.Size(180, 85);
            this.button_bon_view.TabIndex = 11;
            this.button_bon_view.Text = "Bonifici";
            this.button_bon_view.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_bon_view.UseVisualStyleBackColor = false;
            this.button_bon_view.Click += new System.EventHandler(this.button_bon_view_Click);
            // 
            // button_ricariche_view
            // 
            this.button_ricariche_view.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_ricariche_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_ricariche_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ricariche_view.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button_ricariche_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ricariche_view.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ricariche_view.ForeColor = System.Drawing.Color.Black;
            this.button_ricariche_view.Image = global::Progetto_Banca_Client.Properties.Resources.icons8_carte_bancarie_40;
            this.button_ricariche_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ricariche_view.Location = new System.Drawing.Point(0, 251);
            this.button_ricariche_view.Name = "button_ricariche_view";
            this.button_ricariche_view.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button_ricariche_view.Size = new System.Drawing.Size(180, 85);
            this.button_ricariche_view.TabIndex = 13;
            this.button_ricariche_view.Text = "Ricariche";
            this.button_ricariche_view.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_ricariche_view.UseVisualStyleBackColor = false;
            this.button_ricariche_view.Click += new System.EventHandler(this.button_ricariche_view_Click);
            // 
            // label_date
            // 
            this.label_date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_date.Location = new System.Drawing.Point(53, 423);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(65, 15);
            this.label_date.TabIndex = 14;
            this.label_date.Text = "label_date";
            // 
            // causale
            // 
            this.causale.Text = "CAUSALE";
            // 
            // detr_fisc
            // 
            this.detr_fisc.Text = "DETR. FISCALE";
            // 
            // bon_ordinario
            // 
            this.bon_ordinario.Text = "BON. ORDINARIO";
            // 
            // bon_istantaneo
            // 
            this.bon_istantaneo.Text = "BON. ISTANTANEO";
            // 
            // saldo
            // 
            this.saldo.Text = "SALDO";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.button_ricariche_view);
            this.Controls.Add(this.button_bon_view);
            this.Controls.Add(this.listView_BON);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estratto conto";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel_logo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView_BON;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Ora;
        private System.Windows.Forms.ColumnHeader Iban_benficiario;
        private System.Windows.Forms.ColumnHeader Importo;
        private System.Windows.Forms.Button button_bon_view;
        private System.Windows.Forms.Button button_ricariche_view;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.ColumnHeader causale;
        private System.Windows.Forms.ColumnHeader detr_fisc;
        private System.Windows.Forms.ColumnHeader bon_ordinario;
        private System.Windows.Forms.ColumnHeader bon_istantaneo;
        private System.Windows.Forms.ColumnHeader saldo;
    }
}