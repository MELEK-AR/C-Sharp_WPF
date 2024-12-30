namespace Mathe_RechnerQuiz1
{
    partial class Klasse
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
            this.label_aufgabentyp = new System.Windows.Forms.Label();
            this.label_fehler = new System.Windows.Forms.Label();
            this.zuruck = new System.Windows.Forms.Button();
            this.button_Weiter = new System.Windows.Forms.Button();
            this.labelBis = new System.Windows.Forms.Label();
            this.maxZahlenBox = new System.Windows.Forms.TextBox();
            this.labelVon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.minZahlenBox = new System.Windows.Forms.TextBox();
            this.geteiltAufgaben = new System.Windows.Forms.CheckBox();
            this.malAufgaben = new System.Windows.Forms.CheckBox();
            this.minusAufgaben = new System.Windows.Forms.CheckBox();
            this.plusAufgaben = new System.Windows.Forms.CheckBox();
            this.klassenWahl = new System.Windows.Forms.ComboBox();
            this.label_klassenwahl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_aufgabentyp
            // 
            this.label_aufgabentyp.BackColor = System.Drawing.Color.DarkOrchid;
            this.label_aufgabentyp.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_aufgabentyp.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label_aufgabentyp.Location = new System.Drawing.Point(348, 272);
            this.label_aufgabentyp.Name = "label_aufgabentyp";
            this.label_aufgabentyp.Size = new System.Drawing.Size(107, 25);
            this.label_aufgabentyp.TabIndex = 29;
            this.label_aufgabentyp.Text = "Aufgabentyp";
            // 
            // label_fehler
            // 
            this.label_fehler.BackColor = System.Drawing.Color.LavenderBlush;
            this.label_fehler.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fehler.ForeColor = System.Drawing.Color.Maroon;
            this.label_fehler.Location = new System.Drawing.Point(38, 292);
            this.label_fehler.Name = "label_fehler";
            this.label_fehler.Size = new System.Drawing.Size(237, 131);
            this.label_fehler.TabIndex = 28;
            this.label_fehler.Visible = false;
            // 
            // zuruck
            // 
            this.zuruck.BackColor = System.Drawing.SystemColors.ControlLight;
            this.zuruck.BackgroundImage = global::Mathe_RechnerQuiz1.Properties.Resources.dark_violett1;
            this.zuruck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zuruck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zuruck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zuruck.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zuruck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zuruck.Location = new System.Drawing.Point(681, 395);
            this.zuruck.Name = "zuruck";
            this.zuruck.Size = new System.Drawing.Size(81, 28);
            this.zuruck.TabIndex = 27;
            this.zuruck.Text = "Zurück";
            this.zuruck.UseVisualStyleBackColor = false;
            this.zuruck.Click += new System.EventHandler(this.zuruck_Click);
            // 
            // button_Weiter
            // 
            this.button_Weiter.BackColor = System.Drawing.SystemColors.Control;
            this.button_Weiter.BackgroundImage = global::Mathe_RechnerQuiz1.Properties.Resources.Quiz_knopfe;
            this.button_Weiter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Weiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Weiter.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Weiter.Location = new System.Drawing.Point(626, 179);
            this.button_Weiter.Name = "button_Weiter";
            this.button_Weiter.Size = new System.Drawing.Size(136, 55);
            this.button_Weiter.TabIndex = 26;
            this.button_Weiter.Text = "Weiter";
            this.button_Weiter.UseVisualStyleBackColor = false;
            this.button_Weiter.Click += new System.EventHandler(this.button_Weiter_Click);
            // 
            // labelBis
            // 
            this.labelBis.BackColor = System.Drawing.Color.DarkOrchid;
            this.labelBis.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBis.ForeColor = System.Drawing.Color.LavenderBlush;
            this.labelBis.Location = new System.Drawing.Point(309, 212);
            this.labelBis.Name = "labelBis";
            this.labelBis.Size = new System.Drawing.Size(48, 22);
            this.labelBis.TabIndex = 25;
            this.labelBis.Text = "Bis:";
            // 
            // maxZahlenBox
            // 
            this.maxZahlenBox.Location = new System.Drawing.Point(352, 212);
            this.maxZahlenBox.Name = "maxZahlenBox";
            this.maxZahlenBox.Size = new System.Drawing.Size(130, 22);
            this.maxZahlenBox.TabIndex = 24;
            // 
            // labelVon
            // 
            this.labelVon.BackColor = System.Drawing.Color.DarkOrchid;
            this.labelVon.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVon.ForeColor = System.Drawing.Color.LavenderBlush;
            this.labelVon.Location = new System.Drawing.Point(309, 165);
            this.labelVon.Name = "labelVon";
            this.labelVon.Size = new System.Drawing.Size(48, 22);
            this.labelVon.TabIndex = 23;
            this.labelVon.Text = "Von:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkOrchid;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(358, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Zahlen";
            // 
            // minZahlenBox
            // 
            this.minZahlenBox.Location = new System.Drawing.Point(352, 165);
            this.minZahlenBox.Name = "minZahlenBox";
            this.minZahlenBox.Size = new System.Drawing.Size(130, 22);
            this.minZahlenBox.TabIndex = 21;
            // 
            // geteiltAufgaben
            // 
            this.geteiltAufgaben.AutoSize = true;
            this.geteiltAufgaben.BackColor = System.Drawing.Color.MediumOrchid;
            this.geteiltAufgaben.Font = new System.Drawing.Font("Segoe UI Historic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geteiltAufgaben.ForeColor = System.Drawing.SystemColors.ControlText;
            this.geteiltAufgaben.Location = new System.Drawing.Point(429, 376);
            this.geteiltAufgaben.Name = "geteiltAufgaben";
            this.geteiltAufgaben.Size = new System.Drawing.Size(40, 27);
            this.geteiltAufgaben.TabIndex = 20;
            this.geteiltAufgaben.Text = "/";
            this.geteiltAufgaben.UseVisualStyleBackColor = false;
            this.geteiltAufgaben.Click += new System.EventHandler(this.geteiltAufgaben_CheckedChanged);
            // 
            // malAufgaben
            // 
            this.malAufgaben.AutoSize = true;
            this.malAufgaben.BackColor = System.Drawing.Color.MediumOrchid;
            this.malAufgaben.Font = new System.Drawing.Font("Segoe UI Historic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.malAufgaben.ForeColor = System.Drawing.SystemColors.ControlText;
            this.malAufgaben.Location = new System.Drawing.Point(338, 376);
            this.malAufgaben.Name = "malAufgaben";
            this.malAufgaben.Size = new System.Drawing.Size(40, 27);
            this.malAufgaben.TabIndex = 19;
            this.malAufgaben.Text = "*";
            this.malAufgaben.UseVisualStyleBackColor = false;
            this.malAufgaben.Click += new System.EventHandler(this.malAufgaben_CheckedChanged);
            // 
            // minusAufgaben
            // 
            this.minusAufgaben.AutoSize = true;
            this.minusAufgaben.BackColor = System.Drawing.Color.MediumOrchid;
            this.minusAufgaben.Font = new System.Drawing.Font("Segoe UI Historic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusAufgaben.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minusAufgaben.Location = new System.Drawing.Point(429, 324);
            this.minusAufgaben.Name = "minusAufgaben";
            this.minusAufgaben.Size = new System.Drawing.Size(40, 27);
            this.minusAufgaben.TabIndex = 18;
            this.minusAufgaben.Text = "-";
            this.minusAufgaben.UseVisualStyleBackColor = false;
            this.minusAufgaben.Click += new System.EventHandler(this.minusAufgaben_CheckedChanged);
            // 
            // plusAufgaben
            // 
            this.plusAufgaben.AutoSize = true;
            this.plusAufgaben.BackColor = System.Drawing.Color.MediumOrchid;
            this.plusAufgaben.Font = new System.Drawing.Font("Segoe UI Historic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusAufgaben.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.plusAufgaben.Location = new System.Drawing.Point(338, 324);
            this.plusAufgaben.Name = "plusAufgaben";
            this.plusAufgaben.Size = new System.Drawing.Size(45, 27);
            this.plusAufgaben.TabIndex = 17;
            this.plusAufgaben.Text = "+";
            this.plusAufgaben.UseVisualStyleBackColor = false;
            this.plusAufgaben.Click += new System.EventHandler(this.plusAufgaben_CheckedChanged);
            // 
            // klassenWahl
            // 
            this.klassenWahl.BackColor = System.Drawing.Color.Violet;
            this.klassenWahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.klassenWahl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.klassenWahl.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klassenWahl.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.klassenWahl.FormattingEnabled = true;
            this.klassenWahl.Items.AddRange(new object[] {
            "Klasse 1 - 2",
            "Klasse 3 - 4",
            "Klasse 4 - 5",
            "Benutzerdefiniert"});
            this.klassenWahl.Location = new System.Drawing.Point(43, 121);
            this.klassenWahl.Name = "klassenWahl";
            this.klassenWahl.Size = new System.Drawing.Size(174, 28);
            this.klassenWahl.TabIndex = 16;
            // 
            // label_klassenwahl
            // 
            this.label_klassenwahl.BackColor = System.Drawing.Color.DarkOrchid;
            this.label_klassenwahl.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_klassenwahl.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label_klassenwahl.Location = new System.Drawing.Point(38, 27);
            this.label_klassenwahl.Name = "label_klassenwahl";
            this.label_klassenwahl.Size = new System.Drawing.Size(623, 57);
            this.label_klassenwahl.TabIndex = 15;
            this.label_klassenwahl.Text = "Wählen Sie unten eine Klasse, um die Schwierigkeit einzustellen, oder wählen Sie " +
    "einen eigenen Schwierigkeitsgrad aus.";
            // 
            // Klasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mathe_RechnerQuiz1.Properties.Resources.Quiz_hintergrund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_aufgabentyp);
            this.Controls.Add(this.label_fehler);
            this.Controls.Add(this.zuruck);
            this.Controls.Add(this.button_Weiter);
            this.Controls.Add(this.labelBis);
            this.Controls.Add(this.maxZahlenBox);
            this.Controls.Add(this.labelVon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minZahlenBox);
            this.Controls.Add(this.geteiltAufgaben);
            this.Controls.Add(this.malAufgaben);
            this.Controls.Add(this.minusAufgaben);
            this.Controls.Add(this.plusAufgaben);
            this.Controls.Add(this.klassenWahl);
            this.Controls.Add(this.label_klassenwahl);
            this.DoubleBuffered = true;
            this.Name = "Klasse";
            this.Text = "Klasse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Klasse_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_aufgabentyp;
        private System.Windows.Forms.Label label_fehler;
        private System.Windows.Forms.Button zuruck;
        private System.Windows.Forms.Button button_Weiter;
        private System.Windows.Forms.Label labelBis;
        private System.Windows.Forms.TextBox maxZahlenBox;
        private System.Windows.Forms.Label labelVon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox minZahlenBox;
        private System.Windows.Forms.CheckBox geteiltAufgaben;
        private System.Windows.Forms.CheckBox malAufgaben;
        private System.Windows.Forms.CheckBox minusAufgaben;
        private System.Windows.Forms.CheckBox plusAufgaben;
        private System.Windows.Forms.ComboBox klassenWahl;
        private System.Windows.Forms.Label label_klassenwahl;
    }
}