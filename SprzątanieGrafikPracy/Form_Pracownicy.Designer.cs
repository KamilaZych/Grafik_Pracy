namespace SprzątanieGrafikPracy
{
    partial class Form_Pracownicy
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_usuń_pracownika = new System.Windows.Forms.Button();
            this.button_edytuj_pracownika = new System.Windows.Forms.Button();
            this.button_dodaj_pracownika = new System.Windows.Forms.Button();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(639, 282);
            this.dataGridView1.TabIndex = 5;
            // 
            // button_usuń_pracownika
            // 
            this.button_usuń_pracownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_usuń_pracownika.Location = new System.Drawing.Point(447, 306);
            this.button_usuń_pracownika.Name = "button_usuń_pracownika";
            this.button_usuń_pracownika.Size = new System.Drawing.Size(204, 54);
            this.button_usuń_pracownika.TabIndex = 10;
            this.button_usuń_pracownika.Text = "Usuń zaznaczonego pracownika";
            this.button_usuń_pracownika.UseVisualStyleBackColor = true;
            this.button_usuń_pracownika.Click += new System.EventHandler(this.button_usuń_pracownika_Click);
            // 
            // button_edytuj_pracownika
            // 
            this.button_edytuj_pracownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_edytuj_pracownika.Location = new System.Drawing.Point(230, 306);
            this.button_edytuj_pracownika.Name = "button_edytuj_pracownika";
            this.button_edytuj_pracownika.Size = new System.Drawing.Size(204, 54);
            this.button_edytuj_pracownika.TabIndex = 9;
            this.button_edytuj_pracownika.Text = "Edytuj zaznaczonego pracownika";
            this.button_edytuj_pracownika.UseVisualStyleBackColor = true;
            this.button_edytuj_pracownika.Click += new System.EventHandler(this.button_edytuj_pracownika_Click);
            // 
            // button_dodaj_pracownika
            // 
            this.button_dodaj_pracownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_dodaj_pracownika.Location = new System.Drawing.Point(12, 306);
            this.button_dodaj_pracownika.Name = "button_dodaj_pracownika";
            this.button_dodaj_pracownika.Size = new System.Drawing.Size(204, 54);
            this.button_dodaj_pracownika.TabIndex = 8;
            this.button_dodaj_pracownika.Text = "Dodaj pracownika";
            this.button_dodaj_pracownika.UseVisualStyleBackColor = true;
            this.button_dodaj_pracownika.Click += new System.EventHandler(this.button_dodaj_pracownika_Click);
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Telefon";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 70;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Stawka godzinowa";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Data rozpoczęcia współpracy";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 75;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Urząd Skarbowy";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Adres zamieszkania";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 90;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Data urodzenia";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 75;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nazwisko";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Imię";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Form_Pracownicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 373);
            this.Controls.Add(this.button_usuń_pracownika);
            this.Controls.Add(this.button_edytuj_pracownika);
            this.Controls.Add(this.button_dodaj_pracownika);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_Pracownicy";
            this.Text = "Pracownicy";
            this.Load += new System.EventHandler(this.Form_Pracownicy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_usuń_pracownika;
        private System.Windows.Forms.Button button_edytuj_pracownika;
        private System.Windows.Forms.Button button_dodaj_pracownika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}