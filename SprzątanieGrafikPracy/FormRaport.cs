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
    public partial class FormRaport : Form
    {
        public FormRaport()
        {
            InitializeComponent();
        }

        private void button_za_mało_lub_za_dużo_godzin_Click(object sender, EventArgs e)
        {
            string msg1 = "Dni które mają za małą liczbę przepracowanych godzin.\n";
            string msg2 = "Dni które mają za dużą liczbę przepracowanych godzin.\n";
            string msg3 = "Dni które mają równą liczbę przepracowanych godzin.\n";

            int dzień_godziny = 0 ;

            foreach (DzieńZaplanowany dzieńZaplanowany in DzieńZaplanowany.Lista_dni_zaplanowanych)
            {
                int licznik = 0;
                foreach (DzieńRoboczy dzieńRoboczy in DzieńRoboczy.Lista_dni_roboczych)
                {
                    if (dzieńZaplanowany.Data_zaplanowanego_dnia == dzieńRoboczy.Data_dnia_roboczego)
                    {
                        if (dzieńZaplanowany.Zleceniodawca == dzieńRoboczy.Zleceniodawca)
                        {
                            dzień_godziny = dzień_godziny + dzieńRoboczy.Liczba_wykonanych_godzin;
                            licznik++;
                        }
                    }
                    else
                    {
                        licznik++;
                    }
                    if (licznik == DzieńRoboczy.Lista_dni_roboczych.Count)
                    {
                        if (dzieńZaplanowany.Liczba_zaplanowanych_godzin > dzień_godziny)
                        {
                            msg1 += "- " + dzieńZaplanowany.Data_zaplanowanego_dnia.ToShortDateString() + " " + dzieńZaplanowany.Zleceniodawca.ToString() + " " + dzień_godziny + "\n";
                            dzień_godziny = 0;
                        }
                        if (dzieńZaplanowany.Liczba_zaplanowanych_godzin == dzień_godziny)
                        {
                            msg3 += "- " + dzieńZaplanowany.Data_zaplanowanego_dnia.ToShortDateString() + " " + dzieńZaplanowany.Zleceniodawca.ToString() + " " + dzień_godziny + "\n";
                            dzień_godziny = 0;
                        }
                        if (dzieńZaplanowany.Liczba_zaplanowanych_godzin < dzień_godziny)
                        {
                            msg2 += "- " + dzieńZaplanowany.Data_zaplanowanego_dnia.ToShortDateString() + " " + dzieńZaplanowany.Zleceniodawca.ToString() + " " + dzień_godziny + "\n";
                            dzień_godziny = 0;
                        }
                    }
                }
            }

            if (msg1 == "Dni które mają za małą liczbę przepracowanych godzin.\n")
            {
                msg1 = "Brak dni z za małą liczbą przepracowanych godzin.\n";
            }
            if (msg2 == "Dni które mają za dużą liczbę przepracowanych godzin.\n")
            {
                msg2 = "Brak dni z za dużą liczbą przepracowanych godzin.\n";
            }
            if (msg3 == "Dni które mają równą liczbę przepracowanych godzin.\n")
            {
                msg3 = "Brak dni z równą liczbą przepracowanych godzin.\n";
            }

            string msg4 = msg1 + "\n" + msg3 + "\n" + msg2;
            MessageBox.Show(msg4, "MNIEJSZA, RÓWNA I WIĘKSZA ILOŚĆ GODZIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_gdy_pracownik_przepracował_mniej_Click(object sender, EventArgs e)
        {
            string msg1 = "MNIEJSZA PRZEPRACOWANA ILOŚĆ GODZIN NIŻ PRZYDZIELONA\n\n";
            string msg2 = "\nWIĘKSZA PRZEPRACOWANA ILOŚĆ GODZIN NIŻ PRZYDZIELONA\n\n";

            foreach (Pracownik pracownik in Pracownik.Lista_pracowników)
            {
                pracownik.ilość_mniej_godzin = 0;
                pracownik.ile_razy_mniej_godzin = 0;
                pracownik.ilość_więcej_godzin = 0;
                pracownik.ile_razy_więcej_godzin = 0;
            }
            
            foreach (DzieńRoboczy dzieńRoboczy in DzieńRoboczy.Lista_dni_roboczych)
            {
                foreach (Pracownik pracownik in Pracownik.Lista_pracowników)
                {
                    if (dzieńRoboczy.Pracownik.ToString() == pracownik.ToString())
                    {
                        if (dzieńRoboczy.Liczba_wykonanych_godzin < dzieńRoboczy.Liczba_przydzielonych_godzin)
                        {
                            pracownik.Oblicz_ilość_mniej_godzin_i_ile_razy_mniej(dzieńRoboczy);
                        }

                        if (dzieńRoboczy.Liczba_wykonanych_godzin > dzieńRoboczy.Liczba_przydzielonych_godzin)
                        {
                            pracownik.Oblicz_ilość_więcej_godzin_i_ile_razy_więcej(dzieńRoboczy);
                        }
                    }
                }
            }

            foreach (Pracownik pracownik in Pracownik.Lista_pracowników)
            {
                if (pracownik.ile_razy_mniej_godzin > 0)
                {
                    msg1 += "Pracownik: " + pracownik.Imię + " " + pracownik.Nazwisko + " " + pracownik.ile_razy_mniej_godzin.ToString() + " razy wykonał/a za mało godzin niż powinien. Ilość nieprzepracowanych godzin wynosi " + pracownik.ilość_mniej_godzin.ToString() + "h. \n";
                }
                if (pracownik.ile_razy_więcej_godzin > 0)
                {
                    msg2 += "Pracownik: " + pracownik.Imię + " " + pracownik.Nazwisko + " " + pracownik.ile_razy_więcej_godzin.ToString() + " razy wykonał/a więcej godzin niż powinien. Ilość nadgodzin wynosi " + pracownik.ilość_więcej_godzin.ToString() + "h.\n";
                }
            }

            if (msg1 == "MNIEJSZA PRZEPRACOWANA ILOŚĆ GODZIN NIŻ PRZYDZIELONA\n")
            {
                msg1 += "Brak przepracowanych mniej godzin.\n\n";
            }
            if (msg2 == "WIĘKSZA PRZEPRACOWANA ILOŚĆ GODZIN NIŻ PRZYDZIELONA\n")
            {
                msg2 += "Brak przepracowanych więcej godzin.\n";
            }
            
            string msg3 = msg1 + "\n" + msg2;
            MessageBox.Show(msg3, "PRZEPRACOWANA ILOŚĆ GODZIN", MessageBoxButtons.OK);
        }

        private void button_raport_przepracowane_faktycznie_godziny_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;

            foreach (Pracownik pracownik in Pracownik.Lista_pracowników)
            {
                pracownik.godziny = 0;
                pracownik.ilość_mniej_godzin = 0;
                pracownik.ile_razy_mniej_godzin = 0;
                pracownik.ilość_więcej_godzin = 0;
                pracownik.ile_razy_więcej_godzin = 0;
            }
            
            foreach (Pracownik pracownik in Pracownik.Lista_pracowników)
            {
                foreach (DzieńRoboczy dzieńRoboczy1 in DzieńRoboczy.Lista_dni_roboczych)
                {
                    if (dzieńRoboczy1.Pracownik.ToString() == pracownik.ToString())
                    {
                        pracownik.Obliczanie_wszystkich_godzin(dzieńRoboczy1);
                    }
                }
            }

            foreach (DzieńRoboczy dzieńRoboczy in DzieńRoboczy.Lista_dni_roboczych)
            {
                foreach (Pracownik pracownik in Pracownik.Lista_pracowników)
                {
                    if (dzieńRoboczy.Pracownik.ToString() == pracownik.ToString())
                    {
                        if (dzieńRoboczy.Liczba_wykonanych_godzin < dzieńRoboczy.Liczba_przydzielonych_godzin)
                        {
                            pracownik.Oblicz_ilość_mniej_godzin_i_ile_razy_mniej(dzieńRoboczy);
                        }

                        if (dzieńRoboczy.Liczba_wykonanych_godzin > dzieńRoboczy.Liczba_przydzielonych_godzin)
                        {
                            pracownik.Oblicz_ilość_więcej_godzin_i_ile_razy_więcej(dzieńRoboczy);
                        }
                    }
                }
            }
            
            foreach (Pracownik pracownik in Pracownik.Lista_pracowników)
            {
                decimal należność_cała = pracownik.Obliczanie_należności_równej + pracownik.Obliczanie_należności_za_więcej_godzin - pracownik.Obliczanie_należności_za_mniej_godzin;

                msg += "Pracownik: " + pracownik.Imię + " " + pracownik.Nazwisko + " wykonał/a " + pracownik.godziny + "h w tym " + pracownik.ilość_więcej_godzin + "h nadgodzin i " + pracownik.ilość_mniej_godzin
                    + "h mniej niż przydzielono godzin." + " Stawka jest równa: " + pracownik.Stawka_godzinowa + "zł/h, należność jest równa " + należność_cała + "zł, w tym " + pracownik.Obliczanie_należności_za_więcej_godzin
                    + "zł za więcej godzin pracy i odjęte " + pracownik.Obliczanie_należności_za_mniej_godzin + "zł za mniej godzin pracy.\n\n";
            }

            MessageBox.Show(msg, "RAPORT PRACOWNICZY", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormRaport_Load(object sender, EventArgs e)
        {
            comboBox1_mniej_lub_więcej.Items.Clear();
            comboBox2_raport.Items.Clear();

            foreach (Pracownik pracownik in Pracownik.Lista_pracowników)
            {
                comboBox1_mniej_lub_więcej.Items[comboBox1_mniej_lub_więcej.Items.Add(pracownik)] = pracownik;
                comboBox2_raport.Items[comboBox2_raport.Items.Add(pracownik)] = pracownik;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1_mniej_lub_więcej.SelectedItem == null)
            {
                MessageBox.Show("Wybierz pracownika.");
                return;
            }

            string msg1 = "MNIEJSZA PRZEPRACOWANA ILOŚĆ GODZIN NIŻ PRZYDZIELONA\n\n";
            string msg2 = "\nWIĘKSZA PRZEPRACOWANA ILOŚĆ GODZIN NIŻ PRZYDZIELONA\n\n";

            foreach (Pracownik pracownik in Pracownik.Lista_pracowników)
            {
                pracownik.ilość_mniej_godzin = 0;
                pracownik.ile_razy_mniej_godzin = 0;
                pracownik.ilość_więcej_godzin = 0;
                pracownik.ile_razy_więcej_godzin = 0;
            }

            foreach (DzieńRoboczy dzieńRoboczy in DzieńRoboczy.Lista_dni_roboczych)
            {
                foreach (Pracownik pracownik in Pracownik.Lista_pracowników)
                {
                    if (dzieńRoboczy.Pracownik.ToString() == pracownik.ToString() && dzieńRoboczy.Pracownik.ToString() == comboBox1_mniej_lub_więcej.SelectedItem.ToString())
                    {
                        if (dzieńRoboczy.Liczba_wykonanych_godzin < dzieńRoboczy.Liczba_przydzielonych_godzin)
                        {
                            pracownik.Oblicz_ilość_mniej_godzin_i_ile_razy_mniej(dzieńRoboczy);
                        }
                        if (dzieńRoboczy.Liczba_wykonanych_godzin > dzieńRoboczy.Liczba_przydzielonych_godzin)
                        {
                            pracownik.Oblicz_ilość_więcej_godzin_i_ile_razy_więcej(dzieńRoboczy);
                        }
                    }
                }
            }

            foreach (Pracownik pracownik in Pracownik.Lista_pracowników)
            {
                if (pracownik.ToString() == comboBox1_mniej_lub_więcej.SelectedItem.ToString())
                {
                    if (pracownik.ile_razy_mniej_godzin > 0)
                    {
                        msg1 += "Pracownik: " + comboBox1_mniej_lub_więcej.SelectedItem.ToString() + " " + pracownik.ile_razy_mniej_godzin.ToString() + " razy wykonał/a za mało godzin niż powinien. Ilość nieprzepracowanych godzin wynosi " + pracownik.ilość_mniej_godzin.ToString() + "h. \n";
                    }
                    if (pracownik.ile_razy_więcej_godzin > 0)
                    {
                        msg2 += "Pracownik: " + comboBox1_mniej_lub_więcej.SelectedItem.ToString() + " " + pracownik.ile_razy_więcej_godzin.ToString() + " razy wykonał/a więcej godzin niż powinien. Ilość nadgodzin wynosi " + pracownik.ilość_więcej_godzin.ToString() + "h.\n";
                    }
                }
            }

            if (msg1 == "MNIEJSZA PRZEPRACOWANA ILOŚĆ GODZIN NIŻ PRZYDZIELONA\n\n")
            {
                msg1 = "Brak przepracowanych mniej godzin.\n\n";
            }
            if (msg2 == "\nWIĘKSZA PRZEPRACOWANA ILOŚĆ GODZIN NIŻ PRZYDZIELONA\n\n")
            {
                msg2 = "Brak przepracowanych więcej godzin.\n";
            }

            string msg3 = msg1 + "\n" + msg2;
            MessageBox.Show(msg3, "PRZEPRACOWANA ILOŚĆ GODZIN", MessageBoxButtons.OK);
        }

        private void button_raport_dla_wybranego_pracownika_Click(object sender, EventArgs e)
        {
            if (comboBox2_raport.SelectedItem == null)
            {
                MessageBox.Show("Wybierz pracownika.");
                return;
            }
            string msg = string.Empty;

            foreach (Pracownik pracownik in Pracownik.Lista_pracowników)
            {
                pracownik.godziny = 0;
                pracownik.ilość_mniej_godzin = 0;
                pracownik.ile_razy_mniej_godzin = 0;
                pracownik.ilość_więcej_godzin = 0;
                pracownik.ile_razy_więcej_godzin = 0;
            }

            foreach (Pracownik pracownik in Pracownik.Lista_pracowników)
            {
                foreach (DzieńRoboczy dzieńRoboczy1 in DzieńRoboczy.Lista_dni_roboczych)
                {
                    if (dzieńRoboczy1.Pracownik.ToString() == pracownik.ToString() && dzieńRoboczy1.Pracownik.ToString() == comboBox2_raport.SelectedItem.ToString())
                    {
                        pracownik.Obliczanie_wszystkich_godzin(dzieńRoboczy1);
                    }
                }
            }

            foreach (DzieńRoboczy dzieńRoboczy in DzieńRoboczy.Lista_dni_roboczych)
            {
                foreach (Pracownik pracownik in Pracownik.Lista_pracowników)
                {
                    if (dzieńRoboczy.Pracownik.ToString() == pracownik.ToString() && dzieńRoboczy.Pracownik.ToString() == comboBox2_raport.SelectedItem.ToString())
                    {
                        if (dzieńRoboczy.Liczba_wykonanych_godzin < dzieńRoboczy.Liczba_przydzielonych_godzin)
                        {
                            pracownik.Oblicz_ilość_mniej_godzin_i_ile_razy_mniej(dzieńRoboczy);
                        }

                        if (dzieńRoboczy.Liczba_wykonanych_godzin > dzieńRoboczy.Liczba_przydzielonych_godzin)
                        {
                            pracownik.Oblicz_ilość_więcej_godzin_i_ile_razy_więcej(dzieńRoboczy);
                        }
                    }
                }
            }

            foreach (Pracownik pracownik in Pracownik.Lista_pracowników)
            {
                if (pracownik.ToString() == comboBox2_raport.SelectedItem.ToString())
                {
                    decimal należność_cała = pracownik.Obliczanie_należności_równej + pracownik.Obliczanie_należności_za_więcej_godzin - pracownik.Obliczanie_należności_za_mniej_godzin;

                    msg = "Pracownik: " + comboBox2_raport.SelectedItem.ToString() + " wykonał/a " + pracownik.godziny + "h w tym " + pracownik.ilość_więcej_godzin + "h nadgodzin i " 
                        + pracownik.ilość_mniej_godzin + "h mniej niż przydzielono godzin." + " Stawka jest równa: " + pracownik.Stawka_godzinowa 
                        + "zł/h, należność jest równa " + należność_cała + "zł, w tym " + pracownik.Obliczanie_należności_za_więcej_godzin + "zł za więcej godzin pracy i odjęte " 
                        + pracownik.Obliczanie_należności_za_mniej_godzin + "zł za mniej godzin pracy.\n\n";
                }
            }
            
            MessageBox.Show(msg, "RAPORT PRACOWNICZY", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
