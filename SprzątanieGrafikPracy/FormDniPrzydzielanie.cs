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
    public partial class FormDniPrzydzielanie : Form
    {
        DzieńRoboczy dzieńRoboczy;
        internal FormDniPrzydzielanie(DzieńRoboczy dzieńRoboczy)
        {
            this.dzieńRoboczy = dzieńRoboczy;
            InitializeComponent();
        }

        private void FormDniPrzydzielanie_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            comboBox_zleceniodawca.Items.Clear();

            foreach (DzieńZaplanowany dzieńZaplanowany in DzieńZaplanowany.Lista_dni_zaplanowanych)
            {
                int index = dataGridView1.Rows.Add(dzieńZaplanowany.Values);
                dataGridView1.Rows[index].Tag = dzieńZaplanowany;
                comboBox_data.Items.Add(dzieńZaplanowany.Data_zaplanowanego_dnia);
                comboBox_zleceniodawca.Items.Add(dzieńZaplanowany.Zleceniodawca);
            }

            comboBox_pracownicy.Items.Clear();
            
            foreach (Pracownik pracownik in Pracownik.Lista_pracowników)
            {
                comboBox_pracownicy.Items[comboBox_pracownicy.Items.Add(pracownik)] = pracownik;
            }

            comboBox_data.SelectedItem = dzieńRoboczy.Data_dnia_roboczego;
            comboBox_zleceniodawca.SelectedItem = dzieńRoboczy.Zleceniodawca;
            comboBox_pracownicy.SelectedItem = dzieńRoboczy.Pracownik;
            numericUpDown_wybierz_liczbę_przydzielonych_godzin.Value = dzieńRoboczy.Liczba_przydzielonych_godzin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox_pracownicy.SelectedItem == null || comboBox_data.SelectedItem == null || comboBox_zleceniodawca.SelectedItem == null || numericUpDown_wybierz_liczbę_przydzielonych_godzin.Value == 0)
            {
                MessageBox.Show("Przydziel dane do pracownika. ", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DzieńZaplanowany dzieńZaplanowany in DzieńZaplanowany.Lista_dni_zaplanowanych)
            {
                if ((dzieńZaplanowany.Data_zaplanowanego_dnia.ToString() == comboBox_data.SelectedItem.ToString()) && (dzieńZaplanowany.Zleceniodawca == comboBox_zleceniodawca.SelectedItem.ToString()))
                {
                    dzieńRoboczy.Data_dnia_roboczego = (DateTime)comboBox_data.SelectedItem;
                    dzieńRoboczy.Zleceniodawca = comboBox_zleceniodawca.SelectedItem.ToString();
                    dzieńRoboczy.Pracownik = (Pracownik)comboBox_pracownicy.SelectedItem;
                    dzieńRoboczy.Liczba_przydzielonych_godzin = (int)numericUpDown_wybierz_liczbę_przydzielonych_godzin.Value;

                    DialogResult = DialogResult.OK;
                }
                
            }
            if (DialogResult != DialogResult.OK)
            {
                MessageBox.Show("Nie ma takiego zlecenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
        }
    }
}
