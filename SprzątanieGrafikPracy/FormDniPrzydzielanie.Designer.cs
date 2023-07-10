namespace SprzątanieGrafikPracy
{
    partial class FormDniPrzydzielanie
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
            this.comboBox_data = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_zleceniodawca = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker_przydzielanie_dni = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label_wybierz_pracownika = new System.Windows.Forms.Label();
            this.comboBox_pracownicy = new System.Windows.Forms.ComboBox();
            this.label_wybierz_dzień_zaplanowany = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown_wybierz_liczbę_przydzielonych_godzin = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_wybierz_liczbę_przydzielonych_godzin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown_wybierz_liczbę_przydzielonych_godzin);
            this.groupBox1.Controls.Add(this.comboBox_data);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_zleceniodawca);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.dateTimePicker_przydzielanie_dni);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_wybierz_pracownika);
            this.groupBox1.Controls.Add(this.comboBox_pracownicy);
            this.groupBox1.Controls.Add(this.label_wybierz_dzień_zaplanowany);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 444);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Przydzielanie/edytowanie dni zaplanowanych do pracownika";
            // 
            // comboBox_data
            // 
            this.comboBox_data.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_data.FormattingEnabled = true;
            this.comboBox_data.Location = new System.Drawing.Point(10, 197);
            this.comboBox_data.Name = "comboBox_data";
            this.comboBox_data.Size = new System.Drawing.Size(377, 21);
            this.comboBox_data.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Wybierz zleceniodawce";
            // 
            // comboBox_zleceniodawca
            // 
            this.comboBox_zleceniodawca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_zleceniodawca.FormattingEnabled = true;
            this.comboBox_zleceniodawca.Location = new System.Drawing.Point(10, 245);
            this.comboBox_zleceniodawca.Name = "comboBox_zleceniodawca";
            this.comboBox_zleceniodawca.Size = new System.Drawing.Size(377, 21);
            this.comboBox_zleceniodawca.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column3,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(381, 139);
            this.dataGridView1.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Data planowanej usługi";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Zleceniodawca";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Ilość godzin";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dateTimePicker_przydzielanie_dni
            // 
            this.dateTimePicker_przydzielanie_dni.Location = new System.Drawing.Point(6, 138);
            this.dateTimePicker_przydzielanie_dni.Name = "dateTimePicker_przydzielanie_dni";
            this.dateTimePicker_przydzielanie_dni.Size = new System.Drawing.Size(377, 20);
            this.dateTimePicker_przydzielanie_dni.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Wybierz liczbę godzin";
            // 
            // label_wybierz_pracownika
            // 
            this.label_wybierz_pracownika.AutoSize = true;
            this.label_wybierz_pracownika.Location = new System.Drawing.Point(7, 330);
            this.label_wybierz_pracownika.Name = "label_wybierz_pracownika";
            this.label_wybierz_pracownika.Size = new System.Drawing.Size(103, 13);
            this.label_wybierz_pracownika.TabIndex = 12;
            this.label_wybierz_pracownika.Text = "Wybierz pracownika";
            // 
            // comboBox_pracownicy
            // 
            this.comboBox_pracownicy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_pracownicy.FormattingEnabled = true;
            this.comboBox_pracownicy.Location = new System.Drawing.Point(10, 349);
            this.comboBox_pracownicy.Name = "comboBox_pracownicy";
            this.comboBox_pracownicy.Size = new System.Drawing.Size(377, 21);
            this.comboBox_pracownicy.TabIndex = 11;
            // 
            // label_wybierz_dzień_zaplanowany
            // 
            this.label_wybierz_dzień_zaplanowany.AutoSize = true;
            this.label_wybierz_dzień_zaplanowany.Location = new System.Drawing.Point(7, 179);
            this.label_wybierz_dzień_zaplanowany.Name = "label_wybierz_dzień_zaplanowany";
            this.label_wybierz_dzień_zaplanowany.Size = new System.Drawing.Size(138, 13);
            this.label_wybierz_dzień_zaplanowany.TabIndex = 10;
            this.label_wybierz_dzień_zaplanowany.Text = "Wybierz zaplanowany dzień";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(205, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown_wybierz_liczbę_przydzielonych_godzin
            // 
            this.numericUpDown_wybierz_liczbę_przydzielonych_godzin.Location = new System.Drawing.Point(10, 298);
            this.numericUpDown_wybierz_liczbę_przydzielonych_godzin.Name = "numericUpDown_wybierz_liczbę_przydzielonych_godzin";
            this.numericUpDown_wybierz_liczbę_przydzielonych_godzin.Size = new System.Drawing.Size(377, 20);
            this.numericUpDown_wybierz_liczbę_przydzielonych_godzin.TabIndex = 20;
            // 
            // FormDniPrzydzielanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 473);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDniPrzydzielanie";
            this.Text = "FormDniPrzydzielanie";
            this.Load += new System.EventHandler(this.FormDniPrzydzielanie_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_wybierz_liczbę_przydzielonych_godzin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox_pracownicy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_wybierz_pracownika;
        private System.Windows.Forms.DateTimePicker dateTimePicker_przydzielanie_dni;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label_wybierz_dzień_zaplanowany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_zleceniodawca;
        private System.Windows.Forms.ComboBox comboBox_data;
        private System.Windows.Forms.NumericUpDown numericUpDown_wybierz_liczbę_przydzielonych_godzin;
    }
}