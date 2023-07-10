namespace SprzątanieGrafikPracy
{
    partial class FormDzieńZaplanowany
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
            this.dateTimePicker_data_zaplanowanego_dnia = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_liczba_godzin = new System.Windows.Forms.NumericUpDown();
            this.label_Stawka_godzinowa = new System.Windows.Forms.Label();
            this.label_liczba_godzin = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_zleceniodawca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_liczba_godzin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker_data_zaplanowanego_dnia
            // 
            this.dateTimePicker_data_zaplanowanego_dnia.Location = new System.Drawing.Point(13, 53);
            this.dateTimePicker_data_zaplanowanego_dnia.Name = "dateTimePicker_data_zaplanowanego_dnia";
            this.dateTimePicker_data_zaplanowanego_dnia.Size = new System.Drawing.Size(219, 20);
            this.dateTimePicker_data_zaplanowanego_dnia.TabIndex = 23;
            // 
            // numericUpDown_liczba_godzin
            // 
            this.numericUpDown_liczba_godzin.Location = new System.Drawing.Point(13, 166);
            this.numericUpDown_liczba_godzin.Name = "numericUpDown_liczba_godzin";
            this.numericUpDown_liczba_godzin.Size = new System.Drawing.Size(219, 20);
            this.numericUpDown_liczba_godzin.TabIndex = 22;
            // 
            // label_Stawka_godzinowa
            // 
            this.label_Stawka_godzinowa.AutoSize = true;
            this.label_Stawka_godzinowa.Location = new System.Drawing.Point(10, 32);
            this.label_Stawka_godzinowa.Name = "label_Stawka_godzinowa";
            this.label_Stawka_godzinowa.Size = new System.Drawing.Size(131, 13);
            this.label_Stawka_godzinowa.TabIndex = 25;
            this.label_Stawka_godzinowa.Text = "Data zaplanowanego dnia";
            // 
            // label_liczba_godzin
            // 
            this.label_liczba_godzin.AutoSize = true;
            this.label_liczba_godzin.Location = new System.Drawing.Point(10, 146);
            this.label_liczba_godzin.Name = "label_liczba_godzin";
            this.label_liczba_godzin.Size = new System.Drawing.Size(72, 13);
            this.label_liczba_godzin.TabIndex = 24;
            this.label_liczba_godzin.Text = "Liczba godzin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_zleceniodawca);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label_Stawka_godzinowa);
            this.groupBox1.Controls.Add(this.label_liczba_godzin);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dateTimePicker_data_zaplanowanego_dnia);
            this.groupBox1.Controls.Add(this.numericUpDown_liczba_godzin);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 260);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodawanie i edytowanie zaplanowanego dnia";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(131, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_zleceniodawca
            // 
            this.textBox_zleceniodawca.Location = new System.Drawing.Point(13, 110);
            this.textBox_zleceniodawca.Name = "textBox_zleceniodawca";
            this.textBox_zleceniodawca.Size = new System.Drawing.Size(219, 20);
            this.textBox_zleceniodawca.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Zleceniodawca";
            // 
            // FormDzieńZaplanowany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 282);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDzieńZaplanowany";
            this.Text = "FormDzieńZaplanowany";
            this.Load += new System.EventHandler(this.FormDzieńZaplanowany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_liczba_godzin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_data_zaplanowanego_dnia;
        private System.Windows.Forms.NumericUpDown numericUpDown_liczba_godzin;
        private System.Windows.Forms.Label label_Stawka_godzinowa;
        private System.Windows.Forms.Label label_liczba_godzin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_zleceniodawca;
    }
}