namespace SprzątanieGrafikPracy
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_dodaj_pracownika = new System.Windows.Forms.Button();
            this.button_dodawanie_dni_planowych = new System.Windows.Forms.Button();
            this.button_przydzielanie_dni = new System.Windows.Forms.Button();
            this.button_raporty = new System.Windows.Forms.Button();
            this.button_przepracowane_godziny = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_dodaj_pracownika
            // 
            this.button_dodaj_pracownika.Location = new System.Drawing.Point(25, 23);
            this.button_dodaj_pracownika.Name = "button_dodaj_pracownika";
            this.button_dodaj_pracownika.Size = new System.Drawing.Size(187, 51);
            this.button_dodaj_pracownika.TabIndex = 0;
            this.button_dodaj_pracownika.Text = "Pracownicy";
            this.button_dodaj_pracownika.UseVisualStyleBackColor = true;
            this.button_dodaj_pracownika.Click += new System.EventHandler(this.button_dodaj_pracownika_Click);
            // 
            // button_dodawanie_dni_planowych
            // 
            this.button_dodawanie_dni_planowych.Location = new System.Drawing.Point(25, 104);
            this.button_dodawanie_dni_planowych.Name = "button_dodawanie_dni_planowych";
            this.button_dodawanie_dni_planowych.Size = new System.Drawing.Size(187, 51);
            this.button_dodawanie_dni_planowych.TabIndex = 1;
            this.button_dodawanie_dni_planowych.Text = "Dni planowe";
            this.button_dodawanie_dni_planowych.UseVisualStyleBackColor = true;
            this.button_dodawanie_dni_planowych.Click += new System.EventHandler(this.button_dodawanie_dni_planowych_Click);
            // 
            // button_przydzielanie_dni
            // 
            this.button_przydzielanie_dni.Location = new System.Drawing.Point(25, 185);
            this.button_przydzielanie_dni.Name = "button_przydzielanie_dni";
            this.button_przydzielanie_dni.Size = new System.Drawing.Size(187, 51);
            this.button_przydzielanie_dni.TabIndex = 2;
            this.button_przydzielanie_dni.Text = "Przydzielanie dni";
            this.button_przydzielanie_dni.UseVisualStyleBackColor = true;
            this.button_przydzielanie_dni.Click += new System.EventHandler(this.button_przydzielanie_dni_Click);
            // 
            // button_raporty
            // 
            this.button_raporty.Location = new System.Drawing.Point(25, 328);
            this.button_raporty.Name = "button_raporty";
            this.button_raporty.Size = new System.Drawing.Size(187, 51);
            this.button_raporty.TabIndex = 3;
            this.button_raporty.Text = "Raporty";
            this.button_raporty.UseVisualStyleBackColor = true;
            this.button_raporty.Click += new System.EventHandler(this.button_raporty_Click);
            // 
            // button_przepracowane_godziny
            // 
            this.button_przepracowane_godziny.Location = new System.Drawing.Point(25, 253);
            this.button_przepracowane_godziny.Name = "button_przepracowane_godziny";
            this.button_przepracowane_godziny.Size = new System.Drawing.Size(187, 51);
            this.button_przepracowane_godziny.TabIndex = 4;
            this.button_przepracowane_godziny.Text = "Przepracowane godziny";
            this.button_przepracowane_godziny.UseVisualStyleBackColor = true;
            this.button_przepracowane_godziny.Click += new System.EventHandler(this.button_przepracowane_godziny_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 406);
            this.Controls.Add(this.button_przepracowane_godziny);
            this.Controls.Add(this.button_raporty);
            this.Controls.Add(this.button_przydzielanie_dni);
            this.Controls.Add(this.button_dodawanie_dni_planowych);
            this.Controls.Add(this.button_dodaj_pracownika);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_dodaj_pracownika;
        private System.Windows.Forms.Button button_dodawanie_dni_planowych;
        private System.Windows.Forms.Button button_przydzielanie_dni;
        private System.Windows.Forms.Button button_raporty;
        private System.Windows.Forms.Button button_przepracowane_godziny;
    }
}

