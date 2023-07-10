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
    public partial class Form_Dni_Przydzielone : Form
    {
        public Form_Dni_Przydzielone()
        {
            InitializeComponent();
        }

        private void Form_Dni_Przydzielone_Load(object sender, EventArgs e)
        {
             odśwież();
        }

        void odśwież()
        {
            dataGridView1.Rows.Clear();
            foreach (DzieńRoboczy dzieńRoboczy in DzieńRoboczy.Lista_dni_roboczych)
            {
                int index = dataGridView1.Rows.Add(dzieńRoboczy.Values);
                dataGridView1.Rows[index].Tag = dzieńRoboczy;
            }
        }

        private void button_dodaj_przydzielony_dzień_Click(object sender, EventArgs e)
        { 
            if (DzieńZaplanowany.Lista_dni_zaplanowanych.Count<1)
            {   
                MessageBox.Show("Brak zaplanowanych dni.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            DzieńRoboczy nowy_dzieńRoboczy = new DzieńRoboczy();
            FormDniPrzydzielanie formDniPrzydzielanie = new FormDniPrzydzielanie(nowy_dzieńRoboczy);
            if (formDniPrzydzielanie.ShowDialog() == DialogResult.OK)
                DzieńRoboczy.Lista_dni_roboczych.Add(nowy_dzieńRoboczy);
            odśwież();
        }

        private void button_edytuj_przydzielony_dzień_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Brak przydzielonych dni.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            DzieńRoboczy dzieńRoboczy = (DzieńRoboczy)dataGridView1.SelectedRows[0].Tag;
            FormDniPrzydzielanie form = new FormDniPrzydzielanie(dzieńRoboczy);
            form.ShowDialog();
            odśwież();
        }

        private void button_usuń_przydzielony_dzień_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Brak przydzielonych dni.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult msg = MessageBox.Show("Po wykonaniu tego polecenia nie będzie możliwe przywrócenie usuniętego przydzielonego dnia. " +
                        "Czy na pewno chcesz usunąć ten przydzielony dzień?", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (msg == DialogResult.Yes)
            {
                DzieńRoboczy dzieńRoboczy = (DzieńRoboczy)dataGridView1.SelectedRows[0].Tag;
                DzieńRoboczy.Lista_dni_roboczych.Remove(dzieńRoboczy);
                odśwież();
            }
        }
    }
}
