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
    public partial class Form_Dni_Zaplanowane : Form
    {
        public Form_Dni_Zaplanowane()
        {
            InitializeComponent();
        }

        private void button_dodaj_zaplanowany_dzień_Click(object sender, EventArgs e)
        {
            DzieńZaplanowany nowy_dzieńZaplanowany = new DzieńZaplanowany();
            FormDzieńZaplanowany formDzieńZaplanowany = new FormDzieńZaplanowany(nowy_dzieńZaplanowany);
            if (formDzieńZaplanowany.ShowDialog() == DialogResult.OK)
                DzieńZaplanowany.Lista_dni_zaplanowanych.Add(nowy_dzieńZaplanowany);
            odśwież();
        }

        private void Form_Dni_zaplanowane_Load(object sender, EventArgs e)
        {
            odśwież();
        }

        void odśwież()
        {
            dataGridView1.Rows.Clear();
            foreach (DzieńZaplanowany dzieńZaplanowany in DzieńZaplanowany.Lista_dni_zaplanowanych)
            {
                int index = dataGridView1.Rows.Add(dzieńZaplanowany.Values);
                dataGridView1.Rows[index].Tag = dzieńZaplanowany;
            }
        }

        private void button_edytuj_zaplanowany_dzień_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Brak zaplanowanych dni.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DzieńZaplanowany dzieńZaplanowany = (DzieńZaplanowany)dataGridView1.SelectedRows[0].Tag;
            FormDzieńZaplanowany form = new FormDzieńZaplanowany(dzieńZaplanowany);
            form.ShowDialog();
            odśwież();
        }

        private void button_usuń_zaplanowany_dzień_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Brak zaplanowanych dni.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult msg = MessageBox.Show("Po wykonaniu tego polecenia nie będzie możliwe przywrócenie usuniętego zaplanowanego dnia. " +
                        "Czy na pewno chcesz usunąć ten zaplanwoany dzień?", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (msg == DialogResult.Yes)
            {
                DzieńZaplanowany dzieńZaplanowany = (DzieńZaplanowany)dataGridView1.SelectedRows[0].Tag;
                DzieńZaplanowany.Lista_dni_zaplanowanych.Remove(dzieńZaplanowany);
                odśwież();
            }
        }
    }
}
