using Mathe_RechnerQuiz1;
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
    public partial class Klasse : Form
    {
        private int minzahl;
        private int maxzahl;
        private int zeichennutzen;
        private Boolean plus = false;
        private Boolean minus = false;
        private Boolean mal = false;
        private Boolean geteilt = false;
        private Boolean fehlerfrei = false;
        private Boolean benutzerdef = false;

        public int Minzahl { get { return minzahl; } set { minzahl = value; } }
        public int Maxzahl { get { return maxzahl; } set { maxzahl = value; } }
        public int Zeichennutzen { get { return zeichennutzen; } set { zeichennutzen = value; } }
        public Boolean Plus { get { return plus; } set { plus = value; } }
        public Boolean Minus { get { return minus; } set { minus = value; } }
        public Boolean Mal { get { return mal; } set { mal = value; } }
        public Boolean Geteilt { get { return geteilt; } set { geteilt = value; } }
        public Boolean Benutzerdef { get { return benutzerdef; } set { benutzerdef = value; } }


        public Klasse()
        {
            InitializeComponent();
            this.Width = 680;
            this.Height = 420;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
        }

        private void zuruck_Click(object sender, EventArgs e)
        {
            Menue menue = new Menue();
            this.Hide();
            menue.Show();
        }

        private void plusAufgaben_CheckedChanged(object sender, EventArgs e)
        {
            if (plusAufgaben.Checked) { plus = true; }
            else { plus = false; }
        }

        private void minusAufgaben_CheckedChanged(object sender, EventArgs e)
        {
            if (minusAufgaben.Checked) { minus = true; }
            else { minus = false; }
        }

        private void malAufgaben_CheckedChanged(object sender, EventArgs e)
        {
            if (malAufgaben.Checked) { mal = true; }
            else { mal = false; }
        }

        private void geteiltAufgaben_CheckedChanged(object sender, EventArgs e)
        {
            if (geteiltAufgaben.Checked) { geteilt = true; }
            else { geteilt = false; }
        }



        private void button_Weiter_Click(object sender, EventArgs e)
        {

            if (klassenWahl.Text == "Klasse 1 - 2")
            {
                minzahl = 0;
                maxzahl = 50;
                zeichennutzen = 2;
                fehlerfrei = true;
                benutzerdef = false;
            }
            else if (klassenWahl.Text == "Klasse 3 - 4")
            {
                minzahl = 20;
                maxzahl = 500;
                zeichennutzen = 3;
                fehlerfrei = true;
                benutzerdef = false;
            }
            else if (klassenWahl.Text == "Klasse 4 - 5")
            {
                minzahl = 100;
                maxzahl = 1000;
                zeichennutzen = 4;
                fehlerfrei = true;
                benutzerdef = false;
            }
            else if (klassenWahl.Text == "Benutzerdefiniert")
            {
                if (!minZahlenBox.Text.All(char.IsDigit) || !maxZahlenBox.Text.All(char.IsDigit) || string.IsNullOrWhiteSpace(minZahlenBox.Text) || string.IsNullOrWhiteSpace(maxZahlenBox.Text))
                {
                    label_fehler.Visible = true;
                    label_fehler.Text = "ACHTUNG! Bei Benutzerdefinierten Aufgaben müssen Zahlen Werte eingegeben werden!";
                    fehlerfrei = false;
                }
                else
                {
                    minzahl = Convert.ToInt32(minZahlenBox.Text);
                    maxzahl = Convert.ToInt32(maxZahlenBox.Text);
                    fehlerfrei = true;
                    benutzerdef = true;
                }
            }
            else
            {
                label_fehler.Visible = true;
                label_fehler.Text = "ACHTUNG! Es muss eine klasse oder Benutzerdefiniert ausgewählt werden!";
                fehlerfrei = false;
            }

            if (klassenWahl.Text == "Benutzerdefiniert")
            {
                if (plus == false && minus == false && mal == false && geteilt == false)
                {
                    label_fehler.Visible = true;
                    label_fehler.Text = "ACHTUNG! Bei Benutzerdefinierten Aufgaben muss mindestens ein Aufgabentyp angekreuzt sein!";
                    fehlerfrei = false;
                }
                else if (minzahl > maxzahl)
                {
                    label_fehler.Visible = true;
                    label_fehler.Text = "ACHTUNG! Der Mindest Wert muss KLEINER als der Maxwert sein!";
                    fehlerfrei = false;
                }
            }

            if (fehlerfrei == true)
            {
                Quiz quiz = new Quiz(this);
                this.Visible = false;
                quiz.Show();
            }

        }

        private void Klasse_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
