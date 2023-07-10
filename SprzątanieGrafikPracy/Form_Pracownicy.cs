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
    public partial class Form_Pracownicy : Form
    {
        
        public Form_Pracownicy()
        {
            InitializeComponent();
        }

        private void Form_Pracownicy_Load(object sender, EventArgs e)
        {
            odśwież();
        }

        private void button_dodaj_pracownika_Click(object sender, EventArgs e)
        {
            Pracownik nowy_pracownik = new Pracownik();
            FormPracownik formPracownik = new FormPracownik(nowy_pracownik);
            if (formPracownik.ShowDialog() == DialogResult.OK)
                Pracownik.Lista_pracowników.Add(nowy_pracownik);
            odśwież();
        }
        void odśwież()
        {
            dataGridView1.Rows.Clear();
            foreach (Pracownik pracownik in Pracownik.Lista_pracowników)
            {
                int index = dataGridView1.Rows.Add(pracownik.Values);
                dataGridView1.Rows[index].Tag = pracownik;
            }
        }

        private void button_edytuj_pracownika_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Brak pracowników.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Pracownik pracownik = (Pracownik)dataGridView1.SelectedRows[0].Tag;
            FormPracownik form = new FormPracownik(pracownik);
            form.ShowDialog();
            odśwież();
        }

        private void button_usuń_pracownika_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Brak pracowników.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult msg = MessageBox.Show("Po wykonaniu tego polecenia nie będzie możliwe przywrócenie usuniętego pracownika. " +
                        "Czy na pewno chcesz usunąć tego pracownika?", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (msg == DialogResult.Yes)
            {
                Pracownik pracownik = (Pracownik)dataGridView1.SelectedRows[0].Tag;
                Pracownik.Lista_pracowników.Remove(pracownik);
                odśwież();
            }
        }
    }
}
