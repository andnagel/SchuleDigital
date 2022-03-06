using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagementSystem.Models;
using System.IO;

namespace ManagementSystem.Forms
{
    public partial class LehrerBearbeitenForm : Form
    {
        // Eigenschaften
        Lehrer lehrer = new Lehrer();


        // Konstruktor
        public LehrerBearbeitenForm()
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

        public void ShowAllLehrer()
        {
            DataGridView_lehrer.DataSource = lehrer.GetAllLehrer();

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_lehrer.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        public void ReseteDaten()
        {
            textBox_persID.Clear();
            textBox_vorname.Clear();
            textBox_nachname.Clear();
            textBox_telNummer.Clear();
            textBox_adresse.Clear();
            radioButton_weiblich.Checked = true;
            dateTimePicker_geburtsdatum.Value = DateTime.Now;
            textBox_lehrerSuchen.Clear();
            pictureBox_lehrerBild.Load("../../Resources/female-student.png");
        }


        // Methoden der Bearbeitung der Lehrer
        private void LehrerBearbeitenForm_Load(object sender, EventArgs e)
        {
            ShowAllLehrer();
        }

        private void button_bildHochladen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Wähle ein Bild aus(*.jpg;*png;*.gif) | *.jpg;*png;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
                pictureBox_lehrerBild.Image = Image.FromFile(ofd.FileName);
        }

        private void button_eingabeUebernehmen_Click(object sender, EventArgs e)
        {
            if (Validierung())
            {
                int id = Convert.ToInt32(textBox_persID.Text);
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

                    if (lehrer.UpdateLehrer(id, vorname, nachname, geburtsdatum, geschlecht, telefonNr, adresse, bild))
                    {
                        ShowAllLehrer();
                        MessageBox.Show("Aenderungen wurden gespeichert", "Lehrer bearbeiten", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Angabe/n fehlen", "Lehrer bearbeiten", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button_eingabeZuruecksetzen_Click(object sender, EventArgs e)
        {
            ReseteDaten();
        }

        private void button_entferneLehrer_Click(object sender, EventArgs e)
        {
            if (Validierung())
            {
                var result = MessageBox.Show("Wollen Sie wirklich diesen Lehrer entfernen?", "Lehrer entfernen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        lehrer.DeleteLehrer(textBox_persID.Text);
                        ReseteDaten();
                        ShowAllLehrer();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lehrer muss ausgewaehlt sein", "Lehrer entfernen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_lehrerSuchen_Click(object sender, EventArgs e)
        {
            DataGridView_lehrer.DataSource = lehrer.GetOneLehrer(textBox_lehrerSuchen.Text);

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_lehrer.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            ReseteDaten();
        }

        private void DataGridView_lehrer_Click(object sender, EventArgs e)
        {
            textBox_persID.Text = DataGridView_lehrer.CurrentRow.Cells[0].Value.ToString();
            textBox_vorname.Text = DataGridView_lehrer.CurrentRow.Cells[1].Value.ToString();
            textBox_nachname.Text = DataGridView_lehrer.CurrentRow.Cells[2].Value.ToString();

            dateTimePicker_geburtsdatum.Value = (DateTime)DataGridView_lehrer.CurrentRow.Cells[3].Value;

            if (DataGridView_lehrer.CurrentRow.Cells[4].Value.ToString() == "maennlich")
            {
                radioButton_maennlich.Checked = true;
            }

            textBox_adresse.Text = DataGridView_lehrer.CurrentRow.Cells[5].Value.ToString();
            textBox_telNummer.Text = DataGridView_lehrer.CurrentRow.Cells[6].Value.ToString();

            byte[] bild = (byte[])DataGridView_lehrer.CurrentRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(bild);
            pictureBox_lehrerBild.Image = Image.FromStream(ms);
        }
    }
}
