using System;

namespace Mathe_RechnerQuiz1
{
    partial class Rechner
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
            this.label_uberschrift1 = new System.Windows.Forms.Label();
            this.label_uberschrift2 = new System.Windows.Forms.Label();
            this.eingabebox = new System.Windows.Forms.TextBox();
            this.label_ergebniss = new System.Windows.Forms.Label();
            this.label_ergebniss1 = new System.Windows.Forms.Label();
            this.label_fehler = new System.Windows.Forms.Label();
            this.zuruck = new System.Windows.Forms.Button();
            this.button_bestatigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_uberschrift1
            // 
            this.label_uberschrift1.AutoSize = true;
            this.label_uberschrift1.BackColor = System.Drawing.SystemColors.Info;
            this.label_uberschrift1.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_uberschrift1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_uberschrift1.Location = new System.Drawing.Point(24, 9);
            this.label_uberschrift1.Name = "label_uberschrift1";
            this.label_uberschrift1.Size = new System.Drawing.Size(258, 25);
            this.label_uberschrift1.TabIndex = 1;
            this.label_uberschrift1.Text = "Dieser Rechner kann +,  -,  *,  / ";
            // 
            // label_uberschrift2
            // 
            this.label_uberschrift2.AutoSize = true;
            this.label_uberschrift2.BackColor = System.Drawing.SystemColors.Info;
            this.label_uberschrift2.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_uberschrift2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_uberschrift2.Location = new System.Drawing.Point(24, 58);
            this.label_uberschrift2.Name = "label_uberschrift2";
            this.label_uberschrift2.Size = new System.Drawing.Size(444, 25);
            this.label_uberschrift2.TabIndex = 4;
            this.label_uberschrift2.Text = "Dieser Rechner kann keine Bruch- oder Kommerzahlen!";
            // 
            // eingabebox
            // 
            this.eingabebox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.eingabebox.Location = new System.Drawing.Point(29, 112);
            this.eingabebox.Name = "eingabebox";
            this.eingabebox.Size = new System.Drawing.Size(421, 22);
            this.eingabebox.TabIndex = 5;
            // 
            // label_ergebniss
            // 
            this.label_ergebniss.BackColor = System.Drawing.Color.DarkOrchid;
            this.label_ergebniss.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ergebniss.ForeColor = System.Drawing.Color.Thistle;
            this.label_ergebniss.Location = new System.Drawing.Point(25, 182);
            this.label_ergebniss.Name = "label_ergebniss";
            this.label_ergebniss.Size = new System.Drawing.Size(80, 23);
            this.label_ergebniss.TabIndex = 7;
            this.label_ergebniss.Text = "Ergebniss:";
            // 
            // label_ergebniss1
            // 
            this.label_ergebniss1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label_ergebniss1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label_ergebniss1.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ergebniss1.ForeColor = System.Drawing.Color.Black;
            this.label_ergebniss1.Location = new System.Drawing.Point(101, 182);
            this.label_ergebniss1.Name = "label_ergebniss1";
            this.label_ergebniss1.Size = new System.Drawing.Size(277, 23);
            this.label_ergebniss1.TabIndex = 8;
            // 
            // label_fehler
            // 
            this.label_fehler.BackColor = System.Drawing.SystemColors.Info;
            this.label_fehler.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fehler.ForeColor = System.Drawing.Color.Maroon;
            this.label_fehler.Location = new System.Drawing.Point(113, 268);
            this.label_fehler.Name = "label_fehler";
            this.label_fehler.Size = new System.Drawing.Size(237, 131);
            this.label_fehler.TabIndex = 15;
            this.label_fehler.Visible = false;
            // 
            // zuruck
            // 
            this.zuruck.BackColor = System.Drawing.SystemColors.ControlLight;
            this.zuruck.BackgroundImage = global::Mathe_RechnerQuiz1.Properties.Resources.dark_violett;
            this.zuruck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zuruck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zuruck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zuruck.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zuruck.ForeColor = System.Drawing.SystemColors.Control;
            this.zuruck.Location = new System.Drawing.Point(673, 391);
            this.zuruck.Name = "zuruck";
            this.zuruck.Size = new System.Drawing.Size(81, 28);
            this.zuruck.TabIndex = 16;
            this.zuruck.Text = "Zurück";
            this.zuruck.UseVisualStyleBackColor = false;
            this.zuruck.Click += new System.EventHandler(this.zuruck_Click);
            // 
            // button_bestatigen
            // 
            this.button_bestatigen.BackColor = System.Drawing.Color.LightGray;
            this.button_bestatigen.BackgroundImage = global::Mathe_RechnerQuiz1.Properties.Resources.rechner_knopfee;
            this.button_bestatigen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_bestatigen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_bestatigen.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bestatigen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_bestatigen.Location = new System.Drawing.Point(516, 101);
            this.button_bestatigen.Name = "button_bestatigen";
            this.button_bestatigen.Size = new System.Drawing.Size(137, 43);
            this.button_bestatigen.TabIndex = 6;
            this.button_bestatigen.Text = "Auswerten";
            this.button_bestatigen.UseVisualStyleBackColor = false;
            this.button_bestatigen.Click += new System.EventHandler(this.button_bestatigen_Click);
            // 
            // Rechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mathe_RechnerQuiz1.Properties.Resources.Rechner_hintergrund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zuruck);
            this.Controls.Add(this.label_fehler);
            this.Controls.Add(this.label_ergebniss1);
            this.Controls.Add(this.label_ergebniss);
            this.Controls.Add(this.button_bestatigen);
            this.Controls.Add(this.eingabebox);
            this.Controls.Add(this.label_uberschrift2);
            this.Controls.Add(this.label_uberschrift1);
            this.DoubleBuffered = true;
            this.Name = "Rechner";
            this.Text = "Rechner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rechner_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_uberschrift1;
        private System.Windows.Forms.Label label_uberschrift2;
        private System.Windows.Forms.TextBox eingabebox;
        private System.Windows.Forms.Button button_bestatigen;
        private System.Windows.Forms.Label label_ergebniss;
        private System.Windows.Forms.Label label_ergebniss1;
        private System.Windows.Forms.Label label_fehler;
        private System.Windows.Forms.Button zuruck;
    }
}