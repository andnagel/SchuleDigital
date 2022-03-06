using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSystem.Data;
using ManagementSystem.Models;

namespace ManagementSystem.Forms
{
    public partial class LehrerNeuForm : Form
    {
        // Eigenschaften
        Lehrer lehrer = new Lehrer();


        // Konstruktor
        public LehrerNeuForm()
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
            radioButton_weiblich.Checked = true;
            dateTimePicker_geburtsdatum.Value = DateTime.Now;
            pictureBox_lehrerBild.Load("../../Resources/female-student.png");
        }

        public void ShowAllLehrer()
        {
            DataGridView_lehrer.DataSource = lehrer.GetAllLehrer();

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_lehrer.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }


        // Methoden der Bearbeitung der Lehrer
        private void LehrerNeuForm_Load(object sender, EventArgs e)
        {
            ShowAllLehrer();
        }

        private void button_anlegen_Click(object sender, EventArgs e)
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
                    pictureBox_lehrerBild.Image.Save(ms, pictureBox_lehrerBild.Image.RawFormat);
                    byte[] bild = ms.ToArray();

                    if (lehrer.InsertLehrer(vorname, nachname, geburtsdatum, geschlecht, telefonNr, adresse, bild))
                    {
                        ReseteDaten();
                        MessageBox.Show("Lehrer wurde hinzugefuegt", "Neuer Lehrer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowAllLehrer();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Angabe/n fehlen", "Neuer Lehrer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                pictureBox_lehrerBild.Image = Image.FromFile(ofd.FileName);
        }

    }
}
