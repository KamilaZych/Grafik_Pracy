using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprzątanieGrafikPracy
{
    [Serializable]
    class DzieńZaplanowany
    {
        private DateTime data_zaplanowanego_dnia = DateTime.Now.Date;
        private string zleceniodawca;
        private int liczba_zaplanowanych_godzin;
        private static List<DzieńZaplanowany> lista_dni_zaplanowanych = new List<DzieńZaplanowany>();

        internal object[] Values => new object[] { data_zaplanowanego_dnia.ToShortDateString(), zleceniodawca, liczba_zaplanowanych_godzin };

        internal DateTime Data_zaplanowanego_dnia { get => data_zaplanowanego_dnia; set => data_zaplanowanego_dnia = value; }
        internal string Zleceniodawca { get => zleceniodawca; set => zleceniodawca = value; }
        internal int Liczba_zaplanowanych_godzin { get => liczba_zaplanowanych_godzin; set => liczba_zaplanowanych_godzin = value; }
        internal static List<DzieńZaplanowany> Lista_dni_zaplanowanych { get => lista_dni_zaplanowanych; set => lista_dni_zaplanowanych = value; }
    }
}
