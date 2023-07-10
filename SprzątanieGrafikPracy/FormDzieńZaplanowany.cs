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
    public partial class FormDzieńZaplanowany : Form
    {
        DzieńZaplanowany dzieńZaplanowany;
        internal FormDzieńZaplanowany(DzieńZaplanowany dzieńZaplanowany)
        {
            this.dzieńZaplanowany = dzieńZaplanowany;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_zleceniodawca == null || numericUpDown_liczba_godzin.Value == 0)
            {
                MessageBox.Show("Wprowadź dane zaplanowanego dnia. ", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dzieńZaplanowany.Data_zaplanowanego_dnia = dateTimePicker_data_zaplanowanego_dnia.Value.Date;
            dzieńZaplanowany.Zleceniodawca = textBox_zleceniodawca.Text;
            dzieńZaplanowany.Liczba_zaplanowanych_godzin = (int)numericUpDown_liczba_godzin.Value;

            DialogResult = DialogResult.OK;
        }

        private void FormDzieńZaplanowany_Load(object sender, EventArgs e)
        {
            textBox_zleceniodawca.CharacterCasing = CharacterCasing.Upper;

            dateTimePicker_data_zaplanowanego_dnia.Value = dzieńZaplanowany.Data_zaplanowanego_dnia;
            textBox_zleceniodawca.Text = dzieńZaplanowany.Zleceniodawca;
            numericUpDown_liczba_godzin.Value = dzieńZaplanowany.Liczba_zaplanowanych_godzin;
        }
    }
}
