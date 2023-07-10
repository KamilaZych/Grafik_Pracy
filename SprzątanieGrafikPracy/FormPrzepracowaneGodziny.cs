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
    public partial class FormPrzepracowaneGodziny : Form
    {
        DzieńRoboczy dzieńRoboczy;
        internal FormPrzepracowaneGodziny(DzieńRoboczy dzieńRoboczy)
        {
            this.dzieńRoboczy = dzieńRoboczy;
            InitializeComponent();
        }

        private void FormPrzepracowaneGodziny_Load(object sender, EventArgs e)
        {
            comboBox_data.Items.Clear();
            comboBox_zleceniodawca.Items.Clear();
            comboBox_liczba_godzin.Items.Clear();
            comboBox_pracownicy.Items.Clear();
            
            foreach (DzieńRoboczy dzieńRoboczy in DzieńRoboczy.Lista_dni_roboczych)
            {
                comboBox_data.Items.Add(dzieńRoboczy.Data_dnia_roboczego);
                comboBox_zleceniodawca.Items.Add(dzieńRoboczy.Zleceniodawca);
                comboBox_pracownicy.Items.Add(dzieńRoboczy.Pracownik);
                comboBox_liczba_godzin.Items.Add(dzieńRoboczy.Liczba_przydzielonych_godzin);
            }

            comboBox_data.SelectedItem = dzieńRoboczy.Data_dnia_roboczego;
            comboBox_zleceniodawca.SelectedItem = dzieńRoboczy.Zleceniodawca;
            comboBox_pracownicy.SelectedItem = dzieńRoboczy.Pracownik;
            comboBox_liczba_godzin.SelectedItem = dzieńRoboczy.Liczba_przydzielonych_godzin;
            numericUpDown_wybierz_liczbę_przepracowanych_godzin.Value = dzieńRoboczy.Liczba_wykonanych_godzin;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (numericUpDown_wybierz_liczbę_przepracowanych_godzin.Value == 0)
             {
                 MessageBox.Show("Podaj liczbę przepracowanych godzin.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }

            int sprawdzenie = 0;

            foreach (DzieńRoboczy dzieńRoboczy1 in DzieńRoboczy.Lista_dni_roboczych)
            {
                if (dzieńRoboczy1.Data_dnia_roboczego != (DateTime)comboBox_data.SelectedItem)
                { 
                    if(dzieńRoboczy1.Zleceniodawca != comboBox_zleceniodawca.SelectedItem.ToString())
                    {
                        if(dzieńRoboczy1.Pracownik != (Pracownik)comboBox_pracownicy.SelectedItem)
                        {
                            if(dzieńRoboczy1.Liczba_przydzielonych_godzin != (int)comboBox_liczba_godzin.SelectedItem)
                            {
                                sprawdzenie += 1;
                            }
                        }
                    }
                }

                if (sprawdzenie != (int)DzieńRoboczy.Lista_dni_roboczych.Count)
                {
                    dzieńRoboczy.Data_dnia_roboczego = (DateTime)comboBox_data.SelectedItem;         
                    dzieńRoboczy.Zleceniodawca = comboBox_zleceniodawca.SelectedItem.ToString();          
                    dzieńRoboczy.Pracownik = (Pracownik)comboBox_pracownicy.SelectedItem;            
                    dzieńRoboczy.Liczba_przydzielonych_godzin = (int)comboBox_liczba_godzin.SelectedItem;
                    dzieńRoboczy.Liczba_wykonanych_godzin = (int)numericUpDown_wybierz_liczbę_przepracowanych_godzin.Value;
                    
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Nie ma takiego zlecenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
