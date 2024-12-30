using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathe_RechnerQuiz1
{
    public partial class Rechner : Form
    {
        public Rechner()
        {
            InitializeComponent();
            this.Width = 680;
            this.Height = 420;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
        }

        private void button_bestatigen_Click(object sender, EventArgs e)
        {
            string eingabe = Convert.ToString(eingabebox.Text);
            double[] zahlen = new double[100];
            char[] zeichen = new char[100];
            double ergebniss = 0;

            string[] s = new string[100];
            int z = 0;

            s = eingabe.Split('+', '-', '/', '*');

            for (int y = 0; y < eingabe.Length; y++)
            {
                if (eingabe[y] == '-' || eingabe[y] == '+' || eingabe[y] == '*' || eingabe[y] == '/')
                {
                    zeichen[z] = eingabe[y];
                    z++;
                }
            }

            for (int a = 0; a < s.Length; a++)
            {
                if (double.TryParse(s[a], out zahlen[a]))
                {
                    label_fehler.Visible = false;
                }
                else
                {
                    label_fehler.Visible = true;
                    label_fehler.Text = "Dies ist Keine Zahl!";
                    break;
                }
            }

            Boolean schleife = true;

            int i = 0;
            int j = 1;

            while (schleife)
            {
                if (zahlen[j] == '\0')
                {
                    schleife = false;
                }
                switch (zeichen[i])
                {
                    case '+':
                        ergebniss = zahlen[i] + zahlen[j];
                        i++;
                        j++;
                        zahlen[i] = ergebniss;
                        break;

                    case '-':
                        ergebniss = zahlen[i] - zahlen[j];
                        i++;
                        j++;
                        zahlen[i] = ergebniss;
                        break;

                    case '*':
                        ergebniss = zahlen[i] * zahlen[j];
                        i++;
                        j++;
                        zahlen[i] = ergebniss;
                        break;

                    case '/':
                        ergebniss = zahlen[i] / zahlen[j];
                        i++;
                        j++;
                        zahlen[i] = ergebniss;
                        break;
                }
            }
            ergebniss = Math.Round(ergebniss, 5);
            label_ergebniss1.Text = ergebniss.ToString();
        }

        private void zuruck_Click(object sender, EventArgs e)
        {
            Menue menue = new Menue();
            this.Hide();
            menue.Show();

        }

        private void Rechner_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
