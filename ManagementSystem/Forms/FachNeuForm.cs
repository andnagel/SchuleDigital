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

namespace ManagementSystem.Forms
{
    public partial class FachNeuForm : Form
    {
        //Eigenschaften
        Fach fach = new Fach();
        Lehrer lehrer = new Lehrer();


        // Konstruktor
        public FachNeuForm()
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
        
        private void ShowAllFaecher()
        {
            DataGridView_faecher.DataSource = fach.GetAllFaecher();
        }

        private void ReseteDaten()
        {
            textBox_bezeichnung.Clear();
            textBox_stufe.Clear();
            textBox_lehrerID.Clear();
            textBox_beschreibung.Clear();
        }
        

        // Methoden der Bearbeitung der Faecher
        private void button_fachAnlegen_Click(object sender, EventArgs e)
        {
            if (Validierung())
            {
                string bezeichnung = textBox_bezeichnung.Text;
                string stufe = textBox_stufe.Text;
                string beschreibung = textBox_beschreibung.Text;
                int? lehrerID = lehrer.GetLehrerID(textBox_lehrerID.Text);

                try
                {
                    fach.InsertFach(bezeichnung, stufe, beschreibung, lehrerID);
                    MessageBox.Show("Neues Fach wurde angelegt", "Neues Fach", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReseteDaten();
                    ShowAllFaecher();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Angabe/n fehlen", "Neues Fach", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_eingabeZuruecksetzen_Click(object sender, EventArgs e)
        {
            ReseteDaten();
        }

        private void FachNeuForm_Load(object sender, EventArgs e)
        {
            ShowAllFaecher();
        }

    }
}


