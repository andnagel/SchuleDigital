using ManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystem.Forms
{
    public partial class NotenNeuForm : Form
    {
        // Eigenschaften
        Note note = new Note();
        Fach fach = new Fach();
        Schueler schueler = new Schueler();


        // Konstruktor
        public NotenNeuForm()
        {
            InitializeComponent();
        }

        // Methoden um im aktuellen Fenster mit den Daten umzugehen
        private bool Validierung()
        {
            if ((textBox_schuelerID.Text == "") || (textBox_note.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ShowAllSchueler()
        {
            DataGridView_schueler.DataSource = schueler.GetSchuelerNames();
        }

        private void ReseteDaten()
        {
            textBox_schuelerID.Text = "";
            textBox_note.Text = "";
            dateTimePicker_note.Value = DateTime.Now;
            comboBox_fachAuswahl.SelectedIndex = 0;
            textBox_noteAendern.Text = "";
        }

        public void ShowAllNoten()
        {
            DataGridView_noten.DataSource = note.GetNotenBySchuelerID(textBox_schuelerID.Text);
        }


        // Methoden der Bearbeitung der Noten
        private void NotenNeuForm_Load(object sender, EventArgs e)
        {
            comboBox_fachAuswahl.DataSource = fach.GetAllFaecher();
            comboBox_fachAuswahl.DisplayMember = "Bezeichnung";
            comboBox_fachAuswahl.ValueMember = "Bezeichnung";

            ShowAllSchueler();
        }

        private void button_eingabeZuruecksetzen_Click(object sender, EventArgs e)
        {
            ReseteDaten();
        }

        private void button_noteVergeben_Click(object sender, EventArgs e)
        {
            if (Validierung())
            {
                int schuelerID = Convert.ToInt32(textBox_schuelerID.Text);
                int fachID = fach.GetFachID(comboBox_fachAuswahl.Text);
                string wert = textBox_note.Text;
                DateTime datum = dateTimePicker_note.Value;

                try
                {
                    note.InsertNote(schuelerID, fachID, wert, datum);
                    MessageBox.Show("Note wurde vergeben", "Neue Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_note.Text = "";
                    ShowAllNoten();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Angabe/n fehlen", "Neue Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DataGridView_schueler_Click(object sender, EventArgs e)
        {
            textBox_schuelerID.Text = DataGridView_schueler.CurrentRow.Cells[0].Value.ToString();
            ShowAllNoten();
            textBox_noteAendern.Text = "";
        }

        private void DataGridView_noten_Click(object sender, EventArgs e)
        {
            textBox_noteAendern.Text = DataGridView_noten.CurrentRow.Cells[2].Value.ToString();
        }

        private void button_uebernehmen_Click(object sender, EventArgs e)
        {
            if (textBox_noteAendern.Text == "")
            {
                MessageBox.Show("Angabe/n fehlen", "Note bearbeiten", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int schuelerID = (int)DataGridView_noten.CurrentRow.Cells[0].Value;
                int fachID = (int)DataGridView_noten.CurrentRow.Cells[1].Value;
                string wert = textBox_noteAendern.Text;
                DateTime datum = (DateTime)DataGridView_noten.CurrentRow.Cells[3].Value;

                try
                {
                    note.UpdateNote(schuelerID, fachID, wert, datum);
                    MessageBox.Show("Aenderung wurde uebernommen", "Note bearbeiten", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllNoten();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_entfernen_Click(object sender, EventArgs e)
        {
            if (textBox_noteAendern.Text != "")
            {
                var result = MessageBox.Show("Wollen Sie wirklich diese Note entfernen?", "Note entfernen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int schuelerID = (int)DataGridView_noten.CurrentRow.Cells[0].Value;
                    int fachID = (int)DataGridView_noten.CurrentRow.Cells[1].Value;
                    DateTime datum = (DateTime)DataGridView_noten.CurrentRow.Cells[3].Value;

                    note.DeleteNote(schuelerID, fachID, datum);
                    textBox_noteAendern.Text = "";
                    ShowAllNoten();
                }
            }
            else
            {
                MessageBox.Show("Note muss ausgewaehlt sein", "Note entfernen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
