using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Progetto_Banca_Client
{
    public partial class Form4 : Form
    {
        int s = 0;
        public Form4()
        {
            InitializeComponent();
            DateTime thisDay = DateTime.Today;
            label_date.Text = thisDay.ToString("dd/MM/yyyy");
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button_bon_view_Click(object sender, EventArgs e)
        {
            if (s == 2)
            {
                button_ricariche_view.ForeColor = Color.Black;
            }
            s = 1;
            button_bon_view.ForeColor = Color.Green;
            //listView.View = View.Details;
            listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView.Items.Add("ciao");
            listView.Columns.Add("DATA");
            listView.Columns.Add("ORA");
            listView.Columns.Add("IBAN BENEFICIARIO");
            listView.Columns.Add("IMPORTO");
            listView.Columns.Add("CAUSALE");
        }

        private void button_ricariche_view_Click(object sender, EventArgs e)
        {
            if (s == 1)
            {
                button_bon_view.ForeColor = Color.Black;
            }
            s = 2;
            button_ricariche_view.ForeColor = Color.Green;
        }
    }
}
