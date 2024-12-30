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
    public partial class Menue : Form
    {
        public Menue()
        {
            InitializeComponent();
            this.Width = 680;
            this.Height = 420;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100); // pixel links und pon von oben

            this.MinimumSize = new Size(500, 300);
            this.MaximumSize = new Size(1000, 800);
        }

        private void button_rechner_Click(object sender, EventArgs e)
        {
            Rechner rechner = new Rechner();
            this.Visible = false;
            rechner.Show();

        }

        private void button_quiz_Click(object sender, EventArgs e)
        {
            Klasse klasse = new Klasse();
            this.Visible = false;
            klasse.Show();
        }

        private void Menue_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
