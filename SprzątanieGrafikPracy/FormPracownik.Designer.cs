namespace SprzątanieGrafikPracy
{
    partial class FormPracownik
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_numer_telefonu = new System.Windows.Forms.TextBox();
            this.dateTimePicker_data_rozpoczęcia_współpracy = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_data_urodzenia = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_stawka_godzinowa = new System.Windows.Forms.NumericUpDown();
            this.textBox_ulica = new System.Windows.Forms.TextBox();
            this.textBox_urząd_skarbowy = new System.Windows.Forms.TextBox();
            this.textBox_nazwisko = new System.Windows.Forms.TextBox();
            this.textBox_imię = new System.Windows.Forms.TextBox();
            this.label_Telefon = new System.Windows.Forms.Label();
            this.label_Stawka_godzinowa = new System.Windows.Forms.Label();
            this.button_anuluj = new System.Windows.Forms.Button();
            this.label_Data_rozpoczęcia_współpracy = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.label_Urząd_Skarbowy = new System.Windows.Forms.Label();
            this.label_Ulica = new System.Windows.Forms.Label();
            this.label_Data_urodzenia = new System.Windows.Forms.Label();
            this.label_Nazwisko = new System.Windows.Forms.Label();
            this.label_Imię = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stawka_godzinowa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_numer_telefonu);
            this.groupBox1.Controls.Add(this.dateTimePicker_data_rozpoczęcia_współpracy);
            this.groupBox1.Controls.Add(this.dateTimePicker_data_urodzenia);
            this.groupBox1.Controls.Add(this.numericUpDown_stawka_godzinowa);
            this.groupBox1.Controls.Add(this.textBox_ulica);
            this.groupBox1.Controls.Add(this.textBox_urząd_skarbowy);
            this.groupBox1.Controls.Add(this.textBox_nazwisko);
            this.groupBox1.Controls.Add(this.textBox_imię);
            this.groupBox1.Controls.Add(this.label_Telefon);
            this.groupBox1.Controls.Add(this.label_Stawka_godzinowa);
            this.groupBox1.Controls.Add(this.button_anuluj);
            this.groupBox1.Controls.Add(this.label_Data_rozpoczęcia_współpracy);
            this.groupBox1.Controls.Add(this.button_ok);
            this.groupBox1.Controls.Add(this.label_Urząd_Skarbowy);
            this.groupBox1.Controls.Add(this.label_Ulica);
            this.groupBox1.Controls.Add(this.label_Data_urodzenia);
            this.groupBox1.Controls.Add(this.label_Nazwisko);
            this.groupBox1.Controls.Add(this.label_Imię);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 509);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodawanie i edytowanie pracownika";
            // 
            // textBox_numer_telefonu
            // 
            this.textBox_numer_telefonu.Location = new System.Drawing.Point(13, 409);
            this.textBox_numer_telefonu.MaxLength = 9;
            this.textBox_numer_telefonu.Name = "textBox_numer_telefonu";
            this.textBox_numer_telefonu.Size = new System.Drawing.Size(219, 20);
            this.textBox_numer_telefonu.TabIndex = 23;
            this.textBox_numer_telefonu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_numer_telefonu_KeyPress);
            // 
            // dateTimePicker_data_rozpoczęcia_współpracy
            // 
            this.dateTimePicker_data_rozpoczęcia_współpracy.Location = new System.Drawing.Point(13, 308);
            this.dateTimePicker_data_rozpoczęcia_współpracy.Name = "dateTimePicker_data_rozpoczęcia_współpracy";
            this.dateTimePicker_data_rozpoczęcia_współpracy.Size = new System.Drawing.Size(219, 20);
            this.dateTimePicker_data_rozpoczęcia_współpracy.TabIndex = 22;
            // 
            // dateTimePicker_data_urodzenia
            // 
            this.dateTimePicker_data_urodzenia.Location = new System.Drawing.Point(13, 151);
            this.dateTimePicker_data_urodzenia.Name = "dateTimePicker_data_urodzenia";
            this.dateTimePicker_data_urodzenia.Size = new System.Drawing.Size(219, 20);
            this.dateTimePicker_data_urodzenia.TabIndex = 21;
            // 
            // numericUpDown_stawka_godzinowa
            // 
            this.numericUpDown_stawka_godzinowa.DecimalPlaces = 2;
            this.numericUpDown_stawka_godzinowa.Location = new System.Drawing.Point(13, 360);
            this.numericUpDown_stawka_godzinowa.Name = "numericUpDown_stawka_godzinowa";
            this.numericUpDown_stawka_godzinowa.Size = new System.Drawing.Size(219, 20);
            this.numericUpDown_stawka_godzinowa.TabIndex = 20;
            // 
            // textBox_ulica
            // 
            this.textBox_ulica.Location = new System.Drawing.Point(13, 202);
            this.textBox_ulica.Name = "textBox_ulica";
            this.textBox_ulica.Size = new System.Drawing.Size(219, 20);
            this.textBox_ulica.TabIndex = 18;
            // 
            // textBox_urząd_skarbowy
            // 
            this.textBox_urząd_skarbowy.Location = new System.Drawing.Point(13, 255);
            this.textBox_urząd_skarbowy.Name = "textBox_urząd_skarbowy";
            this.textBox_urząd_skarbowy.Size = new System.Drawing.Size(219, 20);
            this.textBox_urząd_skarbowy.TabIndex = 17;
            // 
            // textBox_nazwisko
            // 
            this.textBox_nazwisko.Location = new System.Drawing.Point(13, 100);
            this.textBox_nazwisko.Name = "textBox_nazwisko";
            this.textBox_nazwisko.Size = new System.Drawing.Size(219, 20);
            this.textBox_nazwisko.TabIndex = 16;
            // 
            // textBox_imię
            // 
            this.textBox_imię.Location = new System.Drawing.Point(13, 46);
            this.textBox_imię.Name = "textBox_imię";
            this.textBox_imię.Size = new System.Drawing.Size(219, 20);
            this.textBox_imię.TabIndex = 15;
            // 
            // label_Telefon
            // 
            this.label_Telefon.AutoSize = true;
            this.label_Telefon.Location = new System.Drawing.Point(10, 391);
            this.label_Telefon.Name = "label_Telefon";
            this.label_Telefon.Size = new System.Drawing.Size(79, 13);
            this.label_Telefon.TabIndex = 14;
            this.label_Telefon.Text = "Numer telefonu";
            // 
            // label_Stawka_godzinowa
            // 
            this.label_Stawka_godzinowa.AutoSize = true;
            this.label_Stawka_godzinowa.Location = new System.Drawing.Point(10, 344);
            this.label_Stawka_godzinowa.Name = "label_Stawka_godzinowa";
            this.label_Stawka_godzinowa.Size = new System.Drawing.Size(97, 13);
            this.label_Stawka_godzinowa.TabIndex = 13;
            this.label_Stawka_godzinowa.Text = "Stawka godzinowa";
            // 
            // button_anuluj
            // 
            this.button_anuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_anuluj.Location = new System.Drawing.Point(131, 446);
            this.button_anuluj.Name = "button_anuluj";
            this.button_anuluj.Size = new System.Drawing.Size(101, 41);
            this.button_anuluj.TabIndex = 9;
            this.button_anuluj.Text = "Anuluj";
            this.button_anuluj.UseVisualStyleBackColor = true;
            // 
            // label_Data_rozpoczęcia_współpracy
            // 
            this.label_Data_rozpoczęcia_współpracy.AutoSize = true;
            this.label_Data_rozpoczęcia_współpracy.Location = new System.Drawing.Point(10, 288);
            this.label_Data_rozpoczęcia_współpracy.Name = "label_Data_rozpoczęcia_współpracy";
            this.label_Data_rozpoczęcia_współpracy.Size = new System.Drawing.Size(148, 13);
            this.label_Data_rozpoczęcia_współpracy.TabIndex = 11;
            this.label_Data_rozpoczęcia_współpracy.Text = "Data rozpoczęcia współpracy";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(13, 446);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(101, 41);
            this.button_ok.TabIndex = 8;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // label_Urząd_Skarbowy
            // 
            this.label_Urząd_Skarbowy.AutoSize = true;
            this.label_Urząd_Skarbowy.Location = new System.Drawing.Point(10, 236);
            this.label_Urząd_Skarbowy.Name = "label_Urząd_Skarbowy";
            this.label_Urząd_Skarbowy.Size = new System.Drawing.Size(85, 13);
            this.label_Urząd_Skarbowy.TabIndex = 10;
            this.label_Urząd_Skarbowy.Text = "Urząd Skarbowy";
            // 
            // label_Ulica
            // 
            this.label_Ulica.AutoSize = true;
            this.label_Ulica.Location = new System.Drawing.Point(10, 184);
            this.label_Ulica.Name = "label_Ulica";
            this.label_Ulica.Size = new System.Drawing.Size(100, 13);
            this.label_Ulica.TabIndex = 9;
            this.label_Ulica.Text = "Adres zamieszkania";
            // 
            // label_Data_urodzenia
            // 
            this.label_Data_urodzenia.AutoSize = true;
            this.label_Data_urodzenia.Location = new System.Drawing.Point(10, 132);
            this.label_Data_urodzenia.Name = "label_Data_urodzenia";
            this.label_Data_urodzenia.Size = new System.Drawing.Size(79, 13);
            this.label_Data_urodzenia.TabIndex = 8;
            this.label_Data_urodzenia.Text = "Data urodzenia";
            // 
            // label_Nazwisko
            // 
            this.label_Nazwisko.AutoSize = true;
            this.label_Nazwisko.Location = new System.Drawing.Point(10, 80);
            this.label_Nazwisko.Name = "label_Nazwisko";
            this.label_Nazwisko.Size = new System.Drawing.Size(53, 13);
            this.label_Nazwisko.TabIndex = 7;
            this.label_Nazwisko.Text = "Nazwisko";
            // 
            // label_Imię
            // 
            this.label_Imię.AutoSize = true;
            this.label_Imię.Location = new System.Drawing.Point(10, 28);
            this.label_Imię.Name = "label_Imię";
            this.label_Imię.Size = new System.Drawing.Size(26, 13);
            this.label_Imię.TabIndex = 6;
            this.label_Imię.Text = "Imię";
            // 
            // FormPracownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 538);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPracownik";
            this.Text = "FormPracownik";
            this.Load += new System.EventHandler(this.FormPracownik_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stawka_godzinowa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_numer_telefonu;
        private System.Windows.Forms.DateTimePicker dateTimePicker_data_rozpoczęcia_współpracy;
        private System.Windows.Forms.DateTimePicker dateTimePicker_data_urodzenia;
        private System.Windows.Forms.NumericUpDown numericUpDown_stawka_godzinowa;
        private System.Windows.Forms.TextBox textBox_ulica;
        private System.Windows.Forms.TextBox textBox_urząd_skarbowy;
        private System.Windows.Forms.TextBox textBox_nazwisko;
        private System.Windows.Forms.TextBox textBox_imię;
        private System.Windows.Forms.Label label_Telefon;
        private System.Windows.Forms.Label label_Stawka_godzinowa;
        private System.Windows.Forms.Button button_anuluj;
        private System.Windows.Forms.Label label_Data_rozpoczęcia_współpracy;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label label_Urząd_Skarbowy;
        private System.Windows.Forms.Label label_Ulica;
        private System.Windows.Forms.Label label_Data_urodzenia;
        private System.Windows.Forms.Label label_Nazwisko;
        private System.Windows.Forms.Label label_Imię;
    }
}