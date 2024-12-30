using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathe_RechnerQuiz1
{
    public partial class Quiz : Form
    {

        private Klasse klasse;

        private List<char> zeichen = new List<char>();
        private int aufgabe = 1;
        private double ergebniss = 0.00;
        private int zeichennutzen = 0;
        int richtig = 0;
        int falsch = 0;



        public Quiz(Klasse klasse)
        {
            InitializeComponent();
            this.Width = 680;
            this.Height = 420;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.klasse = klasse;
            Quizaufgabe();
        }

        public void Quizaufgabe()
        {
            if (this.klasse.Benutzerdef == true)
            {
                if (this.klasse.Plus == true) { zeichen.Add('+'); zeichennutzen++; }
                if (this.klasse.Minus == true) { zeichen.Add('-'); zeichennutzen++; }
                if (this.klasse.Mal == true) { zeichen.Add('*'); zeichennutzen++; }
                if (this.klasse.Geteilt == true) { zeichen.Add('/'); zeichennutzen++; }
                this.klasse.Zeichennutzen = zeichennutzen;
            }
            else
            {
                zeichen.Add('+');
                zeichen.Add('-');
                zeichen.Add('*');
                zeichen.Add('/');
            }


            label_frage.Text = "Frage: " + aufgabe;

            Random random = new Random();
            double zahl1 = random.Next(this.klasse.Minzahl, this.klasse.Maxzahl);
            double zahl2 = random.Next(this.klasse.Minzahl, this.klasse.Maxzahl);
            int zahl3 = random.Next(0, this.klasse.Zeichennutzen);

            switch (zeichen[zahl3])
            {
                case '+':
                    ergebniss = zahl1 + zahl2;
                    label_aufgabe.Text = zahl1 + "+" + zahl2;
                    break;

                case '-':
                    ergebniss = zahl1 - zahl2;
                    label_aufgabe.Text = zahl1 + "-" + zahl2;
                    break;

                case '*':
                    ergebniss = zahl1 * zahl2;
                    label_aufgabe.Text = zahl1 + "*" + zahl2;
                    break;

                case '/':
                    ergebniss = zahl1 / zahl2;
                    ergebniss = Math.Round(ergebniss, 2);
                    label_aufgabe.Text = zahl1 + "/" + zahl2;
                    break;
            }
        }

        private void Quiz_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void zuruck_Click(object sender, EventArgs e)
        {
            Klasse klasse = new Klasse();
            klasse.Show();
            this.Hide();
        }


        private void button_auswertung_Click(object sender, EventArgs e)
        {
            double eingabe = 0;
            Boolean fehler = false;

            if (double.TryParse(ergebnissBox.Text, out eingabe))
            {
                fehler = false;
            }
            else
            {
                label_ergebniss.Visible = true;
                label_ergebniss.Text = "Dies ist Keine Zahl!";
                fehler = true;
            }

            if (fehler == false)
            {
                if (ergebniss == eingabe)
                {
                    label_ergebniss.Visible = true;
                    button_weiter.Visible = true;
                    label_ergebniss.Text = "RICHTIG! \nHier ist die nächste Aufgabe!";
                    richtig++;
                    label_richtig.Text = "Richtig = " + richtig;
                    aufgabe++;
                }
                else
                {
                    label_ergebniss.Visible = true;
                    button_weiter.Visible = true;
                    label_ergebniss.Text = "FALSCH! \ndas richtige Ergebniss währe gewesen: " + ergebniss;
                    falsch++;
                    label_falsch.Text = "Faslch = " + falsch;
                    aufgabe++;
                }
            }
        }

        private void button_weiter_Click(object sender, EventArgs e)
        {
            label_ergebniss.Visible = false;
            button_weiter.Visible = false;
            ergebnissBox.Clear();
            Quizaufgabe();
        }
    }
}
