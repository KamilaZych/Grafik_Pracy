using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprzątanieGrafikPracy
{
    [Serializable]
    class Pracownik
    {
        private string imię;
        private string nazwisko;       
        private DateTime data_urodzenia = DateTime.Now.Date;
        private string adres_zamieszkania;
        private string urząd_skarbowy;
        private DateTime data_rozpoczęcia_współpracy = DateTime.Now.Date;
        private decimal stawka_godzinowa;
        private string numer_telefonu;
        private static List<Pracownik> lista_pracowników = new List<Pracownik>();
        
        internal object[] Values => new object[] { imię, nazwisko, data_urodzenia.ToShortDateString(), adres_zamieszkania, urząd_skarbowy,
                                                   data_rozpoczęcia_współpracy.ToShortDateString(), stawka_godzinowa, numer_telefonu };
        
        public override string ToString()
        {
            return imię + " " + nazwisko + " (" + stawka_godzinowa + "zł/h)";
        }


        internal int ile_razy_mniej_godzin;
        internal int ilość_mniej_godzin;
        internal void Oblicz_ilość_mniej_godzin_i_ile_razy_mniej(DzieńRoboczy dzieńRoboczy)
        {
            ilość_mniej_godzin = ilość_mniej_godzin + (dzieńRoboczy.Liczba_przydzielonych_godzin - dzieńRoboczy.Liczba_wykonanych_godzin);
            ile_razy_mniej_godzin += 1;
        }
        
        internal int ile_razy_więcej_godzin;
        internal int ilość_więcej_godzin;
        internal void Oblicz_ilość_więcej_godzin_i_ile_razy_więcej(DzieńRoboczy dzieńRoboczy)
        {
            ilość_więcej_godzin = ilość_więcej_godzin + (dzieńRoboczy.Liczba_wykonanych_godzin - dzieńRoboczy.Liczba_przydzielonych_godzin);
            ile_razy_więcej_godzin += 1;
        }
        internal int godziny;
        internal void Obliczanie_wszystkich_godzin(DzieńRoboczy dzieńRoboczy)
        {
            godziny = godziny + dzieńRoboczy.Liczba_wykonanych_godzin;
        }
        internal decimal Obliczanie_należności_równej
        {
            get
            {
                decimal należność_równa = (godziny - ilość_mniej_godzin - ilość_więcej_godzin) * Stawka_godzinowa;
                return należność_równa;
            }
        }
        internal decimal Obliczanie_należności_za_więcej_godzin
        {
            get
            {
                decimal należność_więcej_godzin = ilość_więcej_godzin * Stawka_godzinowa * 3m;
                return należność_więcej_godzin;
            }
        }

        internal decimal Obliczanie_należności_za_mniej_godzin
        {
            get
            {
                decimal należność_mniej_godzin = ilość_mniej_godzin * Stawka_godzinowa * 3m;
                return należność_mniej_godzin;
            }
        }

        internal string Imię { get => imię; set => imię = value; }
        internal string Nazwisko { get => nazwisko; set => nazwisko = value; }
        internal DateTime Data_urodzenia { get => data_urodzenia; set => data_urodzenia = value; }
        internal string Adres_zamieszkania { get => adres_zamieszkania; set => adres_zamieszkania = value; }
        internal string Urząd_skarbowy { get => urząd_skarbowy; set => urząd_skarbowy = value; }
        internal DateTime Data_rozpoczęcia_współpracy { get => data_rozpoczęcia_współpracy; set => data_rozpoczęcia_współpracy = value; }
        internal decimal Stawka_godzinowa { get => stawka_godzinowa; set => stawka_godzinowa = value; }
        internal string Numer_telefonu { get => numer_telefonu; set => numer_telefonu = value; }
        internal static List<Pracownik> Lista_pracowników { get => lista_pracowników; set => lista_pracowników = value; }

        /*public static bool operator ==(Pracownik lewy, Pracownik prawy)
        {
            if (lewy.numer_telefonu == prawy.numer_telefonu)
                return true;
            else
                return false;
        }
        public static bool operator !=(Pracownik lewy, Pracownik prawy)
        {
            return !(lewy == prawy);
        }*/
    }
}

