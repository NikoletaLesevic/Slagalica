using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Slagalica_79_2018
{
    public partial class Form3 : Form
    {
        RezultatiDB db = new RezultatiDB();
        public Form3()
        {
            InitializeComponent();
            init();
        }
        private void init()
        {
            dataGridView1.Rows.Clear();
            List<Rezultat> rezultati = db.dajRezultate();

            foreach(Rezultat r in rezultati)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = r.ime;
                row.Cells[1].Value = r.brPoteza;
                row.Cells[2].Value = r.vreme;

                dataGridView1.Rows.Add(row);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            init();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<Rezultat> rezultati = db.dajRezultate2();

            foreach (Rezultat r in rezultati)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = r.ime;
                row.Cells[1].Value = r.brPoteza;
                row.Cells[2].Value = r.vreme;

                dataGridView1.Rows.Add(row);
            }
        }
    }
}
