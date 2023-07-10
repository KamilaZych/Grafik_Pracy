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
    public partial class Form_Przepracowane_godziny : Form
    {
        public Form_Przepracowane_godziny()
        {
            InitializeComponent();
        }

        private void Form_Przepracowane_godziny_Load(object sender, EventArgs e)
        {
            odśwież();
        }

        private void button_dodaj_przydzielony_dzień_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Brak przydzielonych dni.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DzieńRoboczy dzieńRoboczy = (DzieńRoboczy)dataGridView1.SelectedRows[0].Tag;
            FormPrzepracowaneGodziny form = new FormPrzepracowaneGodziny(dzieńRoboczy);
            form.ShowDialog();
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

        private void button_edytuj_przydzielony_dzień_Click_1(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Brak przydzielonych dni.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DzieńRoboczy dzieńRoboczy = (DzieńRoboczy)dataGridView1.SelectedRows[0].Tag;
            FormPrzepracowaneGodziny form = new FormPrzepracowaneGodziny(dzieńRoboczy);
            form.ShowDialog();
            odśwież();
        }
    }
}
