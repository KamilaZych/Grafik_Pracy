namespace SprzątanieGrafikPracy
{
    partial class FormPrzepracowaneGodziny
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
            this.comboBox_liczba_godzin = new System.Windows.Forms.ComboBox();
            this.comboBox_data = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_zleceniodawca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_pracownicy = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_wybierz_liczbę_przepracowanych_godzin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_wybierz_liczbę_przepracowanych_godzin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_liczba_godzin);
            this.groupBox1.Controls.Add(this.comboBox_data);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_zleceniodawca);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox_pracownicy);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDown_wybierz_liczbę_przepracowanych_godzin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button_ok);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 343);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Przydzielanie dni zaplanowanych";
            // 
            // comboBox_liczba_godzin
            // 
            this.comboBox_liczba_godzin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_liczba_godzin.FormattingEnabled = true;
            this.comboBox_liczba_godzin.Location = new System.Drawing.Point(9, 147);
            this.comboBox_liczba_godzin.Name = "comboBox_liczba_godzin";
            this.comboBox_liczba_godzin.Size = new System.Drawing.Size(482, 21);
            this.comboBox_liczba_godzin.TabIndex = 28;
            // 
            // comboBox_data
            // 
            this.comboBox_data.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_data.FormattingEnabled = true;
            this.comboBox_data.Location = new System.Drawing.Point(10, 42);
            this.comboBox_data.Name = "comboBox_data";
            this.comboBox_data.Size = new System.Drawing.Size(481, 21);
            this.comboBox_data.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Wybierz zleceniodawce";
            // 
            // comboBox_zleceniodawca
            // 
            this.comboBox_zleceniodawca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_zleceniodawca.FormattingEnabled = true;
            this.comboBox_zleceniodawca.Location = new System.Drawing.Point(9, 90);
            this.comboBox_zleceniodawca.Name = "comboBox_zleceniodawca";
            this.comboBox_zleceniodawca.Size = new System.Drawing.Size(482, 21);
            this.comboBox_zleceniodawca.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Wybierz liczbę godzin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Wybierz pracownika";
            // 
            // comboBox_pracownicy
            // 
            this.comboBox_pracownicy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_pracownicy.FormattingEnabled = true;
            this.comboBox_pracownicy.Location = new System.Drawing.Point(9, 196);
            this.comboBox_pracownicy.Name = "comboBox_pracownicy";
            this.comboBox_pracownicy.Size = new System.Drawing.Size(482, 21);
            this.comboBox_pracownicy.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Wybierz zaplanowany dzień";
            // 
            // numericUpDown_wybierz_liczbę_przepracowanych_godzin
            // 
            this.numericUpDown_wybierz_liczbę_przepracowanych_godzin.Location = new System.Drawing.Point(10, 253);
            this.numericUpDown_wybierz_liczbę_przepracowanych_godzin.Name = "numericUpDown_wybierz_liczbę_przepracowanych_godzin";
            this.numericUpDown_wybierz_liczbę_przepracowanych_godzin.Size = new System.Drawing.Size(481, 20);
            this.numericUpDown_wybierz_liczbę_przepracowanych_godzin.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Wybierz liczbę godzin przepracowanych";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(259, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(10, 288);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(232, 41);
            this.button_ok.TabIndex = 8;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // FormPrzepracowaneGodziny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 366);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPrzepracowaneGodziny";
            this.Text = "FormPrzepracowaneGodziny";
            this.Load += new System.EventHandler(this.FormPrzepracowaneGodziny_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_wybierz_liczbę_przepracowanych_godzin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.NumericUpDown numericUpDown_wybierz_liczbę_przepracowanych_godzin;
        private System.Windows.Forms.ComboBox comboBox_liczba_godzin;
        private System.Windows.Forms.ComboBox comboBox_data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_zleceniodawca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_pracownicy;
        private System.Windows.Forms.Label label6;
    }
}