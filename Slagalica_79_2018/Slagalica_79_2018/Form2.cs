using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Slagalica_79_2018
{
    public partial class Form2 : Form
    {
        private string ime;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                DialogResult dR = MessageBox.Show("Morate da unesete ime", "Greška");
            }
            else
            {
                ime = textBox1.Text;
                Form1 igra = new Form1(ime);

                igra.ShowDialog();
                this.Close();
            }
        }
    }
}
