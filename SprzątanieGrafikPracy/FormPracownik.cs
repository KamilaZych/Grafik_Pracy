using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SprzątanieGrafikPracy
{
    public partial class FormPracownik : Form
    {
        Pracownik pracownik;
        internal FormPracownik(Pracownik pracownik)
        {
            this.pracownik = pracownik;
            InitializeComponent();
        }

        private void FormPracownik_Load(object sender, EventArgs e)
        {
            textBox_imię.CharacterCasing = CharacterCasing.Upper;
            textBox_nazwisko.CharacterCasing = CharacterCasing.Upper;
            textBox_ulica.CharacterCasing = CharacterCasing.Upper;
            textBox_urząd_skarbowy.CharacterCasing = CharacterCasing.Upper;

            
            textBox_imię.Text = pracownik.Imię;
            textBox_nazwisko.Text = pracownik.Nazwisko;
            dateTimePicker_data_urodzenia.Value = pracownik.Data_urodzenia;
            textBox_ulica.Text = pracownik.Adres_zamieszkania;
            textBox_urząd_skarbowy.Text = pracownik.Urząd_skarbowy;
            dateTimePicker_data_rozpoczęcia_współpracy.Value = pracownik.Data_rozpoczęcia_współpracy;
            numericUpDown_stawka_godzinowa.Value = pracownik.Stawka_godzinowa;
            textBox_numer_telefonu.Text = pracownik.Numer_telefonu;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (textBox_imię.Text == "" || textBox_nazwisko.Text == "" || textBox_ulica.Text == "" || textBox_urząd_skarbowy.Text == "" || 
                numericUpDown_stawka_godzinowa.Value == 0 || textBox_numer_telefonu.Text == "")
            {
                MessageBox.Show("Wprowadź dane pracownika. ", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pracownik.Imię = textBox_imię.Text;
            pracownik.Nazwisko=textBox_nazwisko.Text;
            pracownik.Data_urodzenia = dateTimePicker_data_urodzenia.Value.Date;
            pracownik.Adres_zamieszkania = textBox_ulica.Text; 
            pracownik.Urząd_skarbowy = textBox_urząd_skarbowy.Text;
            pracownik.Data_rozpoczęcia_współpracy = dateTimePicker_data_rozpoczęcia_współpracy.Value.Date;
            pracownik.Stawka_godzinowa = numericUpDown_stawka_godzinowa.Value;
            pracownik.Numer_telefonu = textBox_numer_telefonu.Text;

            DialogResult = DialogResult.OK;
        }

        private void textBox_numer_telefonu_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
