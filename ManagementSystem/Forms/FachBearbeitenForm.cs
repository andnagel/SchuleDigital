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
    public partial class FachBearbeitenForm : Form
    {
        // Eigenschaften
        Fach fach = new Fach();
        Lehrer lehrer = new Lehrer();

        
        // Konstruktor
        public FachBearbeitenForm()
        {
            InitializeComponent();
        }

        // Methoden um im aktuellen Fenster mit den Daten umzugehen
        private bool Validierung()
        {
            if ((textBox_bezeichnung.Text == "") || (textBox_stufe.Text == "") ||
                (textBox_beschreibung.Text == "")) // || (textBox_lehrerID.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        private void ZeigeAlleFaecher()
        {
            DataGridView_faecher.DataSource = fach.GetAllFaecher();
        }

        private void ReseteDaten()
        {
            textBox_bezeichnung.Clear();
            textBox_stufe.Clear();
            textBox_lehrerID.Clear();
            textBox_beschreibung.Clear();
            textBox_fachID.Clear();
            textBox_fachSuchen.Clear();
        }


        // Methoden der Bearbeitung der Faecher
        private void FachBearbeitenForm_Load(object sender, EventArgs e)
        {
            ZeigeAlleFaecher();
        }

        private void button_eingabeUebernehmen_Click(object sender, EventArgs e)
        {
            if (Validierung())
            {             
                string bezeichnung = textBox_bezeichnung.Text;
                string stufe = textBox_stufe.Text;
                string beschreibung = textBox_beschreibung.Text;
                int? lehrerID = lehrer.GetLehrerID(textBox_lehrerID.Text);
                int id = Convert.ToInt32(textBox_fachID.Text);

                try
                {
                    if (fach.UpdateFach(id, bezeichnung, stufe, beschreibung, lehrerID))
                    {
                        MessageBox.Show("Aenderungen wurden gespeichert", "Fach bearbeiten", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ZeigeAlleFaecher();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Angabe/n fehlen", "Fach bearbeiten", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_eingabeZuruecksetzen_Click(object sender, EventArgs e)
        {
            ReseteDaten();
        }

        private void button_entferneFach_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Wollen Sie wirklich dieses Fach entfernen?", "Fach entfernen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                fach.DeleteFach(textBox_fachID.Text);
                ReseteDaten();
                ZeigeAlleFaecher();
            }
        }

        private void button_fachSuchen_Click(object sender, EventArgs e)
        {
            DataGridView_faecher.DataSource = fach.GetOneFach(textBox_fachSuchen.Text);
            ReseteDaten();
        }

        private void DataGridView_faecher_Click(object sender, EventArgs e)
        {
            textBox_fachID.Text = DataGridView_faecher.CurrentRow.Cells[0].Value.ToString();
            textBox_bezeichnung.Text = DataGridView_faecher.CurrentRow.Cells[1].Value.ToString();
            textBox_stufe.Text = DataGridView_faecher.CurrentRow.Cells[2].Value.ToString();
            textBox_beschreibung.Text = DataGridView_faecher.CurrentRow.Cells[3].Value.ToString();
            textBox_lehrerID.Text = lehrer.GetLehrerName(DataGridView_faecher.CurrentRow.Cells[4].Value.ToString());
        }
    }
}
