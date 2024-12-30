namespace Mathe_RechnerQuiz1
{
    partial class Menue
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_beschreibung = new System.Windows.Forms.Label();
            this.label_beschreibung1 = new System.Windows.Forms.Label();
            this.button_quiz = new System.Windows.Forms.Button();
            this.button_rechner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_beschreibung
            // 
            this.label_beschreibung.AutoSize = true;
            this.label_beschreibung.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label_beschreibung.Font = new System.Drawing.Font("Segoe UI Historic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_beschreibung.Location = new System.Drawing.Point(175, 63);
            this.label_beschreibung.Name = "label_beschreibung";
            this.label_beschreibung.Size = new System.Drawing.Size(471, 23);
            this.label_beschreibung.TabIndex = 0;
            this.label_beschreibung.Text = "Klicken Sie unten auf das, was Sie benutzen möchten!";
            // 
            // label_beschreibung1
            // 
            this.label_beschreibung1.AutoSize = true;
            this.label_beschreibung1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label_beschreibung1.Font = new System.Drawing.Font("Segoe UI Historic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_beschreibung1.Location = new System.Drawing.Point(131, 133);
            this.label_beschreibung1.Name = "label_beschreibung1";
            this.label_beschreibung1.Size = new System.Drawing.Size(558, 23);
            this.label_beschreibung1.TabIndex = 1;
            this.label_beschreibung1.Text = "Wählen Sie zwischen dem Taschenrechner und den Mathe Quiz!";
            // 
            // button_quiz
            // 
            this.button_quiz.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_quiz.BackgroundImage = global::Mathe_RechnerQuiz1.Properties.Resources.Quiz_knopf;
            this.button_quiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_quiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_quiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_quiz.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_quiz.ForeColor = System.Drawing.Color.Thistle;
            this.button_quiz.Location = new System.Drawing.Point(477, 241);
            this.button_quiz.Name = "button_quiz";
            this.button_quiz.Size = new System.Drawing.Size(184, 58);
            this.button_quiz.TabIndex = 3;
            this.button_quiz.Text = "Quiz";
            this.button_quiz.UseVisualStyleBackColor = false;
            this.button_quiz.Click += new System.EventHandler(this.button_quiz_Click);
            // 
            // button_rechner
            // 
            this.button_rechner.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_rechner.BackgroundImage = global::Mathe_RechnerQuiz1.Properties.Resources.Rechner_knopf;
            this.button_rechner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_rechner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_rechner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rechner.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rechner.ForeColor = System.Drawing.Color.MediumBlue;
            this.button_rechner.Location = new System.Drawing.Point(179, 241);
            this.button_rechner.Name = "button_rechner";
            this.button_rechner.Size = new System.Drawing.Size(183, 58);
            this.button_rechner.TabIndex = 2;
            this.button_rechner.Text = "Rechner";
            this.button_rechner.UseVisualStyleBackColor = false;
            this.button_rechner.Click += new System.EventHandler(this.button_rechner_Click);
            // 
            // Menue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 461);
            this.Controls.Add(this.button_quiz);
            this.Controls.Add(this.button_rechner);
            this.Controls.Add(this.label_beschreibung1);
            this.Controls.Add(this.label_beschreibung);
            this.Name = "Menue";
            this.Text = "Menue";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menue_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_beschreibung;
        private System.Windows.Forms.Label label_beschreibung1;
        private System.Windows.Forms.Button button_rechner;
        private System.Windows.Forms.Button button_quiz;
    }
}

