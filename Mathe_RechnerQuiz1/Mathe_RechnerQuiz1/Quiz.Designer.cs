namespace Mathe_RechnerQuiz1
{
    partial class Quiz
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
            this.label3 = new System.Windows.Forms.Label();
            this.label_falsch = new System.Windows.Forms.Label();
            this.label_richtig = new System.Windows.Forms.Label();
            this.button_weiter = new System.Windows.Forms.Button();
            this.zuruck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_auswertung = new System.Windows.Forms.Button();
            this.label_ergebniss = new System.Windows.Forms.Label();
            this.ergebnissBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_aufgabe = new System.Windows.Forms.Label();
            this.label_frage = new System.Windows.Forms.Label();
            this.label_uberschrifft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkOrchid;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label3.Location = new System.Drawing.Point(12, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 46);
            this.label3.TabIndex = 30;
            this.label3.Text = "Runde auf die 2. kommerstelle!";
            // 
            // label_falsch
            // 
            this.label_falsch.AutoSize = true;
            this.label_falsch.BackColor = System.Drawing.Color.DarkOrchid;
            this.label_falsch.Font = new System.Drawing.Font("Segoe UI Historic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_falsch.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label_falsch.Location = new System.Drawing.Point(602, 57);
            this.label_falsch.Name = "label_falsch";
            this.label_falsch.Size = new System.Drawing.Size(87, 23);
            this.label_falsch.TabIndex = 29;
            this.label_falsch.Text = "Falsch = 0";
            // 
            // label_richtig
            // 
            this.label_richtig.AutoSize = true;
            this.label_richtig.BackColor = System.Drawing.Color.DarkOrchid;
            this.label_richtig.Font = new System.Drawing.Font("Segoe UI Historic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_richtig.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label_richtig.Location = new System.Drawing.Point(602, 20);
            this.label_richtig.Name = "label_richtig";
            this.label_richtig.Size = new System.Drawing.Size(93, 23);
            this.label_richtig.TabIndex = 28;
            this.label_richtig.Text = "Richtig = 0";
            // 
            // button_weiter
            // 
            this.button_weiter.BackColor = System.Drawing.Color.MediumPurple;
            this.button_weiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_weiter.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_weiter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_weiter.Location = new System.Drawing.Point(236, 394);
            this.button_weiter.Name = "button_weiter";
            this.button_weiter.Size = new System.Drawing.Size(104, 36);
            this.button_weiter.TabIndex = 27;
            this.button_weiter.Text = "Weiter";
            this.button_weiter.UseVisualStyleBackColor = false;
            this.button_weiter.Visible = false;
            this.button_weiter.Click += new System.EventHandler(this.button_weiter_Click);
            // 
            // zuruck
            // 
            this.zuruck.BackColor = System.Drawing.SystemColors.ControlLight;
            this.zuruck.BackgroundImage = global::Mathe_RechnerQuiz1.Properties.Resources.dark_violett;
            this.zuruck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zuruck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zuruck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zuruck.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zuruck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.zuruck.Location = new System.Drawing.Point(683, 398);
            this.zuruck.Name = "zuruck";
            this.zuruck.Size = new System.Drawing.Size(81, 28);
            this.zuruck.TabIndex = 26;
            this.zuruck.Text = "Zurück";
            this.zuruck.UseVisualStyleBackColor = false;
            this.zuruck.Click += new System.EventHandler(this.zuruck_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkOrchid;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label2.Location = new System.Drawing.Point(162, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Aufgabe:";
            // 
            // button_auswertung
            // 
            this.button_auswertung.BackColor = System.Drawing.Color.MediumOrchid;
            this.button_auswertung.BackgroundImage = global::Mathe_RechnerQuiz1.Properties.Resources.Quiz_knopfe1;
            this.button_auswertung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_auswertung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_auswertung.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_auswertung.ForeColor = System.Drawing.Color.LavenderBlush;
            this.button_auswertung.Location = new System.Drawing.Point(248, 223);
            this.button_auswertung.Name = "button_auswertung";
            this.button_auswertung.Size = new System.Drawing.Size(117, 46);
            this.button_auswertung.TabIndex = 24;
            this.button_auswertung.Text = "Auswerten";
            this.button_auswertung.UseVisualStyleBackColor = false;
            this.button_auswertung.Click += new System.EventHandler(this.button_auswertung_Click);
            // 
            // label_ergebniss
            // 
            this.label_ergebniss.BackColor = System.Drawing.Color.LavenderBlush;
            this.label_ergebniss.Font = new System.Drawing.Font("Segoe UI Historic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ergebniss.Location = new System.Drawing.Point(162, 294);
            this.label_ergebniss.Name = "label_ergebniss";
            this.label_ergebniss.Size = new System.Drawing.Size(251, 76);
            this.label_ergebniss.TabIndex = 23;
            this.label_ergebniss.Visible = false;
            // 
            // ergebnissBox
            // 
            this.ergebnissBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.ergebnissBox.Location = new System.Drawing.Point(247, 179);
            this.ergebnissBox.Name = "ergebnissBox";
            this.ergebnissBox.Size = new System.Drawing.Size(166, 22);
            this.ergebnissBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrchid;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(162, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ergebniss? :";
            // 
            // label_aufgabe
            // 
            this.label_aufgabe.BackColor = System.Drawing.Color.LavenderBlush;
            this.label_aufgabe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_aufgabe.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_aufgabe.Location = new System.Drawing.Point(248, 133);
            this.label_aufgabe.Name = "label_aufgabe";
            this.label_aufgabe.Size = new System.Drawing.Size(165, 23);
            this.label_aufgabe.TabIndex = 20;
            this.label_aufgabe.Text = "1+1";
            // 
            // label_frage
            // 
            this.label_frage.AutoSize = true;
            this.label_frage.BackColor = System.Drawing.Color.DarkOrchid;
            this.label_frage.Font = new System.Drawing.Font("Segoe UI Historic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_frage.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label_frage.Location = new System.Drawing.Point(36, 57);
            this.label_frage.Name = "label_frage";
            this.label_frage.Size = new System.Drawing.Size(70, 23);
            this.label_frage.TabIndex = 19;
            this.label_frage.Text = "Frage: 1";
            // 
            // label_uberschrifft
            // 
            this.label_uberschrifft.BackColor = System.Drawing.Color.DarkOrchid;
            this.label_uberschrifft.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_uberschrifft.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label_uberschrifft.Location = new System.Drawing.Point(364, 20);
            this.label_uberschrifft.Name = "label_uberschrifft";
            this.label_uberschrifft.Size = new System.Drawing.Size(75, 36);
            this.label_uberschrifft.TabIndex = 18;
            this.label_uberschrifft.Text = " QUIZ";
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mathe_RechnerQuiz1.Properties.Resources.Quiz_hintergrund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_falsch);
            this.Controls.Add(this.label_richtig);
            this.Controls.Add(this.button_weiter);
            this.Controls.Add(this.zuruck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_auswertung);
            this.Controls.Add(this.label_ergebniss);
            this.Controls.Add(this.ergebnissBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_aufgabe);
            this.Controls.Add(this.label_frage);
            this.Controls.Add(this.label_uberschrifft);
            this.DoubleBuffered = true;
            this.Name = "Quiz";
            this.Text = "Quiz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Quiz_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_falsch;
        private System.Windows.Forms.Label label_richtig;
        private System.Windows.Forms.Button button_weiter;
        private System.Windows.Forms.Button zuruck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_auswertung;
        private System.Windows.Forms.Label label_ergebniss;
        private System.Windows.Forms.TextBox ergebnissBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_aufgabe;
        private System.Windows.Forms.Label label_frage;
        private System.Windows.Forms.Label label_uberschrifft;
    }
}