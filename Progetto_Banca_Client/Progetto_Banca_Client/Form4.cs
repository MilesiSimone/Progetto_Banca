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
            listView_BON.View = View.Details;
            listView_BON.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listView_BON.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView_BON.Items.Add("ciao");
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
