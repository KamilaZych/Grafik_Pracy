namespace SprzątanieGrafikPracy
{
    partial class Form_Dni_Przydzielone
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_usuń_przydzielony_dzień = new System.Windows.Forms.Button();
            this.button_edytuj_przydzielony_dzień = new System.Windows.Forms.Button();
            this.button_dodaj_przydzielony_dzień = new System.Windows.Forms.Button();
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
            this.Column4,
            this.Column3,
            this.Column2});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(498, 139);
            this.dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Data zaplanowanej usługi";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 160;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Zleceniodawca";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Pracownik";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ilość przydzielonych godzin";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // button_usuń_przydzielony_dzień
            // 
            this.button_usuń_przydzielony_dzień.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_usuń_przydzielony_dzień.Location = new System.Drawing.Point(357, 162);
            this.button_usuń_przydzielony_dzień.Name = "button_usuń_przydzielony_dzień";
            this.button_usuń_przydzielony_dzień.Size = new System.Drawing.Size(153, 48);
            this.button_usuń_przydzielony_dzień.TabIndex = 16;
            this.button_usuń_przydzielony_dzień.Text = "Usuń przydzielony dzień";
            this.button_usuń_przydzielony_dzień.UseVisualStyleBackColor = true;
            this.button_usuń_przydzielony_dzień.Click += new System.EventHandler(this.button_usuń_przydzielony_dzień_Click);
            // 
            // button_edytuj_przydzielony_dzień
            // 
            this.button_edytuj_przydzielony_dzień.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_edytuj_przydzielony_dzień.Location = new System.Drawing.Point(185, 162);
            this.button_edytuj_przydzielony_dzień.Name = "button_edytuj_przydzielony_dzień";
            this.button_edytuj_przydzielony_dzień.Size = new System.Drawing.Size(153, 48);
            this.button_edytuj_przydzielony_dzień.TabIndex = 15;
            this.button_edytuj_przydzielony_dzień.Text = "Edytuj przydzielony dzień";
            this.button_edytuj_przydzielony_dzień.UseVisualStyleBackColor = true;
            this.button_edytuj_przydzielony_dzień.Click += new System.EventHandler(this.button_edytuj_przydzielony_dzień_Click);
            // 
            // button_dodaj_przydzielony_dzień
            // 
            this.button_dodaj_przydzielony_dzień.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_dodaj_przydzielony_dzień.Location = new System.Drawing.Point(12, 162);
            this.button_dodaj_przydzielony_dzień.Name = "button_dodaj_przydzielony_dzień";
            this.button_dodaj_przydzielony_dzień.Size = new System.Drawing.Size(153, 48);
            this.button_dodaj_przydzielony_dzień.TabIndex = 14;
            this.button_dodaj_przydzielony_dzień.Text = "Dodaj przydzielony dzień";
            this.button_dodaj_przydzielony_dzień.UseVisualStyleBackColor = true;
            this.button_dodaj_przydzielony_dzień.Click += new System.EventHandler(this.button_dodaj_przydzielony_dzień_Click);
            // 
            // Form_Dni_Przydzielone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 222);
            this.Controls.Add(this.button_usuń_przydzielony_dzień);
            this.Controls.Add(this.button_edytuj_przydzielony_dzień);
            this.Controls.Add(this.button_dodaj_przydzielony_dzień);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_Dni_Przydzielone";
            this.Text = "Form_Dni_przydzielone";
            this.Load += new System.EventHandler(this.Form_Dni_Przydzielone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_usuń_przydzielony_dzień;
        private System.Windows.Forms.Button button_edytuj_przydzielony_dzień;
        private System.Windows.Forms.Button button_dodaj_przydzielony_dzień;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}