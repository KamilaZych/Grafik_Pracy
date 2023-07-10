using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SprzątanieGrafikPracy
{
    public partial class Form1 : Form
    {
        const string filter = "Pliki naszej aplikacji|*.pna";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = filter;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                FileStream fileStream = new FileStream(openFileDialog.FileName,
                    FileMode.Open, FileAccess.Read);

                List<Pracownik> pracownicy = (List<Pracownik>)binaryFormatter.Deserialize(fileStream);
                List<DzieńZaplanowany> dniZaplanowane = (List<DzieńZaplanowany>)binaryFormatter.Deserialize(fileStream);
                List<DzieńRoboczy> dniRobocze = (List<DzieńRoboczy>)binaryFormatter.Deserialize(fileStream);

                foreach (Pracownik pracownik in pracownicy)
                    Pracownik.Lista_pracowników.Add(pracownik);

                foreach (DzieńZaplanowany dzieńZaplanowany in dniZaplanowane)
                    DzieńZaplanowany.Lista_dni_zaplanowanych.Add(dzieńZaplanowany);

                foreach (DzieńRoboczy dzieńRoboczy in dniRobocze)
                    DzieńRoboczy.Lista_dni_roboczych.Add(dzieńRoboczy);

                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się odczytać danych.\n" + ex.Message);

            }
        }

        private void button_dodaj_pracownika_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Pracownicy form_Pracownicy = new Form_Pracownicy();
            form_Pracownicy.ShowDialog();
            form_Pracownicy = null;
            this.Show(); 
        }

        private void button_dodawanie_dni_planowych_Click(object sender, EventArgs e)
        {
            if (Pracownik.Lista_pracowników.Count == 0)
            {
                MessageBox.Show("Brak pracowników.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();
            Form_Dni_Zaplanowane form_Dni_Zaplanowane = new Form_Dni_Zaplanowane();
            form_Dni_Zaplanowane.ShowDialog();
            form_Dni_Zaplanowane = null;
            this.Show();
        }

        private void button_przydzielanie_dni_Click(object sender, EventArgs e)
        {
            if (Pracownik.Lista_pracowników.Count == 0)
            {
                MessageBox.Show("Brak pracowników.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (DzieńZaplanowany.Lista_dni_zaplanowanych.Count == 0)
            {
                MessageBox.Show("Brak zaplanowanyvh dni.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();
            Form_Dni_Przydzielone form_Dni_Przydzielone = new Form_Dni_Przydzielone();
            form_Dni_Przydzielone.ShowDialog();
            form_Dni_Przydzielone = null;
            this.Show();
        }

        private void button_przepracowane_godziny_Click(object sender, EventArgs e)
        {
            if (Pracownik.Lista_pracowników.Count == 0)
            {
                MessageBox.Show("Brak pracowników.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (DzieńZaplanowany.Lista_dni_zaplanowanych.Count == 0)
            {
                MessageBox.Show("Brak zaplanowanyvh dni.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (DzieńRoboczy.Lista_dni_roboczych.Count == 0)
            {
                MessageBox.Show("Brak przydzielonych dni do pracownika.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();
            Form_Przepracowane_godziny form_Przepracowane_Godziny = new Form_Przepracowane_godziny();
            form_Przepracowane_Godziny.ShowDialog();
            form_Przepracowane_Godziny = null;
            this.Show();
        }

        private void button_raporty_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRaport formRaport = new FormRaport();
            formRaport.ShowDialog();
            formRaport = null;
            this.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz zapisać dane?", "Zamykanie aplikacji",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
            if (dialogResult == DialogResult.No)
                return;

            try
            {
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = filter;
                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    e.Cancel = true;
                    return;
                }
                FileStream fileStream = new FileStream(saveFileDialog.FileName,
                    FileMode.Create, FileAccess.Write);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                
                List<Pracownik> pracownicy = new List<Pracownik>();
                List<DzieńZaplanowany> dniZaplanowane = new List<DzieńZaplanowany>(); ;
                List<DzieńRoboczy> dniRobocze = new List<DzieńRoboczy>();


                foreach (Pracownik pracownik in Pracownik.Lista_pracowników)
                    pracownicy.Add(pracownik);
                
               foreach (DzieńZaplanowany dzieńZaplanowany in DzieńZaplanowany.Lista_dni_zaplanowanych)
                    dniZaplanowane.Add(dzieńZaplanowany);

               foreach (DzieńRoboczy dzieńRoboczy in DzieńRoboczy.Lista_dni_roboczych)
                    dniRobocze.Add(dzieńRoboczy);

                binaryFormatter.Serialize(fileStream, pracownicy);
                binaryFormatter.Serialize(fileStream, dniZaplanowane);
                binaryFormatter.Serialize(fileStream, dniRobocze);
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się zapisać danych.\n" + ex.Message);
            }      
        }
    }
}
