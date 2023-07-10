using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprzątanieGrafikPracy
{
    [Serializable]
    class DzieńRoboczy
    {
        private DateTime data_dnia_roboczego = DateTime.Now.Date;
        private string zleceniodawca;
        private Pracownik pracownik;
        private int liczba_przydzielonych_godzin;
        private int liczba_wykonanych_godzin;
        private static List<DzieńRoboczy> lista_dni_roboczych = new List<DzieńRoboczy>();
        
        internal object[] Values => new object[] { data_dnia_roboczego.ToShortDateString(), zleceniodawca, pracownik, 
                                                   liczba_przydzielonych_godzin, liczba_wykonanych_godzin };

        internal DateTime Data_dnia_roboczego { get => data_dnia_roboczego; set => data_dnia_roboczego = value; }
        internal string Zleceniodawca { get => zleceniodawca; set => zleceniodawca = value; }
        internal Pracownik Pracownik { get => pracownik; set => pracownik = value; }
        internal int Liczba_przydzielonych_godzin { get => liczba_przydzielonych_godzin; set => liczba_przydzielonych_godzin = value; }
        internal int Liczba_wykonanych_godzin { get => liczba_wykonanych_godzin; set => liczba_wykonanych_godzin = value; }
        internal static List<DzieńRoboczy> Lista_dni_roboczych { get => lista_dni_roboczych; set => lista_dni_roboczych = value; }
    }
}
