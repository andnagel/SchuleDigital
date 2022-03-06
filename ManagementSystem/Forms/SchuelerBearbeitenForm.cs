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
using System.IO;

namespace ManagementSystem.Forms
{
    public partial class SchuelerBearbeitenForm : Form
    {
        // Eigenschaften
        Schueler schueler = new Schueler();


        // Konstruktor
        public SchuelerBearbeitenForm()
        {
            InitializeComponent();
        }


        // Methoden um im aktuellen Fenster mit den Daten umzugehen
        private bool Validierung()
        {
            if ((textBox_vorname.Text == "") || (textBox_nachname.Text == "") ||
                (textBox_telNummer.Text == "") || (textBox_adresse.Text == ""))
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
            DataGridView_schueler.DataSource = schueler.GetAllSchueler();

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_schueler.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        public void ReseteDaten()
        {
            textBox_schuelerID.Clear();
            textBox_vorname.Clear();
            textBox_nachname.Clear();
            textBox_telNummer.Clear();
            textBox_adresse.Clear();
            radioButton_maennlich.Checked = true;
            dateTimePicker_geburtsdatum.Value = DateTime.Now;
            textBox_schuelerSuchen.Clear();
            pictureBox_schuelerBild.Load("../../Resources/student (1).png");
        }


        // Methoden der Bearbeitung der Schueler
        private void SchuelerBearbeitenForm_Load(object sender, EventArgs e)
        {
            ShowAllSchueler();
        }

        private void DataGridView_schueler_Click(object sender, EventArgs e)
        {
            textBox_schuelerID.Text = DataGridView_schueler.CurrentRow.Cells[0].Value.ToString();
            textBox_vorname.Text = DataGridView_schueler.CurrentRow.Cells[1].Value.ToString();
            textBox_nachname.Text = DataGridView_schueler.CurrentRow.Cells[2].Value.ToString();

            dateTimePicker_geburtsdatum.Value = (DateTime)DataGridView_schueler.CurrentRow.Cells[3].Value;

            if (DataGridView_schueler.CurrentRow.Cells[4].Value.ToString() == "maennlich")
            {
                radioButton_maennlich.Checked = true;
            }

            textBox_adresse.Text = DataGridView_schueler.CurrentRow.Cells[5].Value.ToString();
            textBox_telNummer.Text = DataGridView_schueler.CurrentRow.Cells[6].Value.ToString();

            byte[] bild = (byte[])DataGridView_schueler.CurrentRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(bild);
            pictureBox_schuelerBild.Image = Image.FromStream(ms);
        }

        private void button_eingabeZuruecksetzen_Click(object sender, EventArgs e)
        {
            ReseteDaten();
        }

        private void button_bildHochladen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Wähle ein Bild aus(*.jpg;*png;*.gif) | *.jpg;*png;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
                pictureBox_schuelerBild.Image = Image.FromFile(ofd.FileName);
        }

        private void button_schuelerSuchen_Click(object sender, EventArgs e)
        {
            DataGridView_schueler.DataSource = schueler.GetOneSchueler(textBox_schuelerSuchen.Text);

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_schueler.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            ReseteDaten();
        }

        private void button_eingabeUebernehmen_Click(object sender, EventArgs e)
        {
            if (Validierung())
            {
                int id = Convert.ToInt32(textBox_schuelerID.Text);
                string vorname = textBox_vorname.Text;
                string nachname = textBox_nachname.Text;
                DateTime geburtsdatum = dateTimePicker_geburtsdatum.Value;
                string telefonNr = textBox_telNummer.Text;
                string adresse = textBox_adresse.Text;
                string geschlecht = radioButton_maennlich.Checked ? "maennlich" : "weiblich";

                try
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox_schuelerBild.Image.Save(ms, pictureBox_schuelerBild.Image.RawFormat);
                    byte[] bild = ms.ToArray();

                    if (schueler.UpdateSchueler(id, vorname, nachname, geburtsdatum, geschlecht, telefonNr, adresse, bild))
                    {
                        MessageBox.Show("Aenderungen wurden gespeichert", "Schueler bearbeiten", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowAllSchueler();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Angabe/n fehlen", "Schueler bearbeiten", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button_entferneSchueler_Click(object sender, EventArgs e)
        {
            if (Validierung())
            {
                var result = MessageBox.Show("Wollen Sie wirklich diesen Schueler entfernen?", "Schueler entfernen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    schueler.DeleteSchueler(textBox_schuelerID.Text);
                    ReseteDaten();
                    ShowAllSchueler();
                }
            }
            else
            {
                MessageBox.Show("Schueler muss ausgewaehlt werden", "Schueler entfernen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

