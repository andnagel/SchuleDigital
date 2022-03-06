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
using ManagementSystem.Models;
using ManagementSystem.Data;

namespace ManagementSystem.Forms
{
    public partial class SchuelerNeuForm : Form
    {
        // Eigenschaften
        Schueler schueler = new Schueler();


        // Konstruktor
        public SchuelerNeuForm()
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
        
        private void ReseteDaten()
        {
            textBox_vorname.Clear();
            textBox_nachname.Clear();
            textBox_telNummer.Clear();
            textBox_adresse.Clear();
            radioButton_maennlich.Checked = true;
            dateTimePicker_geburtsdatum.Value = DateTime.Now;
            pictureBox_schuelerBild.Load("../../Resources/student (1).png");
        }

        public void ShowAllSchueler()
        {
            DataGridView_schueler.DataSource = schueler.GetAllSchueler();

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_schueler.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }


        // Methoden der Bearbeitung der Schueler
        private void SchuelerNeuForm_Load(object sender, EventArgs e)
        {
            ShowAllSchueler();
        }

        private void button_schuelerAnlegen_Click(object sender, EventArgs e)
        {
            if (Validierung())
            {
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

                    if (schueler.InsertSchueler(vorname, nachname, geburtsdatum, geschlecht, telefonNr, adresse, bild))
                    {
                        MessageBox.Show("Schueler wurde hinzugefuegt", "Neuer Schueler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowAllSchueler();
                        ReseteDaten();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Angabe/n fehlen", "Neuer Schueler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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
    }
}
