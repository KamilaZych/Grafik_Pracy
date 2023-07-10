namespace SprzątanieGrafikPracy
{
    partial class FormRaport
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
            this.button_raport_za_mało_lub_za_dużo_godzin = new System.Windows.Forms.Button();
            this.button_raport_gdy_pracownik_przepracował_mniej = new System.Windows.Forms.Button();
            this.button_raport_przepracowane_faktycznie_godziny = new System.Windows.Forms.Button();
            this.button_raport_dla_wybranego_pracownika = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1_mniej_lub_więcej = new System.Windows.Forms.ComboBox();
            this.comboBox2_raport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_raport_za_mało_lub_za_dużo_godzin
            // 
            this.button_raport_za_mało_lub_za_dużo_godzin.Location = new System.Drawing.Point(12, 12);
            this.button_raport_za_mało_lub_za_dużo_godzin.Name = "button_raport_za_mało_lub_za_dużo_godzin";
            this.button_raport_za_mało_lub_za_dużo_godzin.Size = new System.Drawing.Size(675, 36);
            this.button_raport_za_mało_lub_za_dużo_godzin.TabIndex = 0;
            this.button_raport_za_mało_lub_za_dużo_godzin.Text = "Dni w których jest za mało lub za dużo godzin";
            this.button_raport_za_mało_lub_za_dużo_godzin.UseVisualStyleBackColor = true;
            this.button_raport_za_mało_lub_za_dużo_godzin.Click += new System.EventHandler(this.button_za_mało_lub_za_dużo_godzin_Click);
            // 
            // button_raport_gdy_pracownik_przepracował_mniej
            // 
            this.button_raport_gdy_pracownik_przepracował_mniej.Location = new System.Drawing.Point(12, 56);
            this.button_raport_gdy_pracownik_przepracował_mniej.Name = "button_raport_gdy_pracownik_przepracował_mniej";
            this.button_raport_gdy_pracownik_przepracował_mniej.Size = new System.Drawing.Size(675, 36);
            this.button_raport_gdy_pracownik_przepracował_mniej.TabIndex = 1;
            this.button_raport_gdy_pracownik_przepracował_mniej.Text = "Pracownicy którzy przepracowali mniej lub więcej godzin";
            this.button_raport_gdy_pracownik_przepracował_mniej.UseVisualStyleBackColor = true;
            this.button_raport_gdy_pracownik_przepracował_mniej.Click += new System.EventHandler(this.button_gdy_pracownik_przepracował_mniej_Click);
            // 
            // button_raport_przepracowane_faktycznie_godziny
            // 
            this.button_raport_przepracowane_faktycznie_godziny.Location = new System.Drawing.Point(12, 100);
            this.button_raport_przepracowane_faktycznie_godziny.Name = "button_raport_przepracowane_faktycznie_godziny";
            this.button_raport_przepracowane_faktycznie_godziny.Size = new System.Drawing.Size(675, 36);
            this.button_raport_przepracowane_faktycznie_godziny.TabIndex = 2;
            this.button_raport_przepracowane_faktycznie_godziny.Text = "Raport dla wszystkich pracowników";
            this.button_raport_przepracowane_faktycznie_godziny.UseVisualStyleBackColor = true;
            this.button_raport_przepracowane_faktycznie_godziny.Click += new System.EventHandler(this.button_raport_przepracowane_faktycznie_godziny_Click);
            // 
            // button_raport_dla_wybranego_pracownika
            // 
            this.button_raport_dla_wybranego_pracownika.Location = new System.Drawing.Point(8, 85);
            this.button_raport_dla_wybranego_pracownika.Name = "button_raport_dla_wybranego_pracownika";
            this.button_raport_dla_wybranego_pracownika.Size = new System.Drawing.Size(313, 51);
            this.button_raport_dla_wybranego_pracownika.TabIndex = 3;
            this.button_raport_dla_wybranego_pracownika.Text = "Raport dla wybranego pracownika";
            this.button_raport_dla_wybranego_pracownika.UseVisualStyleBackColor = true;
            this.button_raport_dla_wybranego_pracownika.Click += new System.EventHandler(this.button_raport_dla_wybranego_pracownika_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Wybrany pracownik który przepracował mniej lub więcej godzin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1_mniej_lub_więcej
            // 
            this.comboBox1_mniej_lub_więcej.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1_mniej_lub_więcej.FormattingEnabled = true;
            this.comboBox1_mniej_lub_więcej.Location = new System.Drawing.Point(10, 52);
            this.comboBox1_mniej_lub_więcej.Name = "comboBox1_mniej_lub_więcej";
            this.comboBox1_mniej_lub_więcej.Size = new System.Drawing.Size(311, 21);
            this.comboBox1_mniej_lub_więcej.TabIndex = 6;
            // 
            // comboBox2_raport
            // 
            this.comboBox2_raport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2_raport.FormattingEnabled = true;
            this.comboBox2_raport.Location = new System.Drawing.Point(8, 52);
            this.comboBox2_raport.Name = "comboBox2_raport";
            this.comboBox2_raport.Size = new System.Drawing.Size(311, 21);
            this.comboBox2_raport.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Wybierz pracownika, który przepracował mniej lub więcej godzin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Wybierz pracownika, aby sprawdzić raport";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1_mniej_lub_więcej);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 151);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybieranie pracownika, który przepracował godziny";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_raport_dla_wybranego_pracownika);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox2_raport);
            this.groupBox2.Location = new System.Drawing.Point(354, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 151);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Raport dla wybranego pracownika";
            // 
            // FormRaport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 313);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_raport_przepracowane_faktycznie_godziny);
            this.Controls.Add(this.button_raport_gdy_pracownik_przepracował_mniej);
            this.Controls.Add(this.button_raport_za_mało_lub_za_dużo_godzin);
            this.Name = "FormRaport";
            this.Text = "FormRaport";
            this.Load += new System.EventHandler(this.FormRaport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_raport_za_mało_lub_za_dużo_godzin;
        private System.Windows.Forms.Button button_raport_gdy_pracownik_przepracował_mniej;
        private System.Windows.Forms.Button button_raport_przepracowane_faktycznie_godziny;
        private System.Windows.Forms.Button button_raport_dla_wybranego_pracownika;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1_mniej_lub_więcej;
        private System.Windows.Forms.ComboBox comboBox2_raport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}