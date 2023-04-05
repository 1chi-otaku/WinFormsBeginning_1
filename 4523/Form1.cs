using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4523
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            int symbols_count = 0;

            str = "Ilechko Serhii";
            MessageBox.Show(str, "1");
            symbols_count += str.Length;

            str = "29.06.2004";
            MessageBox.Show(str, "2");
            symbols_count += str.Length;

            str = "Odesa, Ukraine";
            MessageBox.Show(str, "3");
            symbols_count += str.Length;

            MessageBox.Show("The end of resume.", "Average symbols per Dialog - " + symbols_count / 3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult beginning = MessageBox.Show("Please think of a number between 1 and 2000", "Guesser", MessageBoxButtons.OKCancel);
            if(beginning == DialogResult.Cancel) { return; }

            DialogResult IsTrueAnswer = DialogResult.No;

            uint tries = 0;
            while(IsTrueAnswer != DialogResult.Yes && tries < 30)
            {
                tries++;
                Random r = new Random();
                int a = r.Next(0, 2001);
                IsTrueAnswer = MessageBox.Show("Is it " + a, "?",MessageBoxButtons.YesNo);
            }
            if (IsTrueAnswer == DialogResult.Yes)
                MessageBox.Show("I Won!", "Tries count - " + tries.ToString());
            else
                MessageBox.Show("I lost =(", "Tries count - " + tries.ToString());
        }

    }
}
