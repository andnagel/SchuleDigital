using ManagementSystem.Forms;
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

namespace ManagementSystem
{
    public partial class MainForm : Form
    {
        // Eigenschaften
        Schueler schuler = new Schueler();
        Lehrer lehrer = new Lehrer();

        private Form activeForm = null;

        // Konstruktor
        public MainForm()
        {
            InitializeComponent();
            SetMenuVisibility();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label_schuelerGesamt.Text = "Schueler gesamt: " + schuler.CountSchueler();
            label_lehrerGesamt.Text = "Lehrer gesamt: " + lehrer.CountLehrer();
        }

        // Methode um Unterfenster im Hauptfenster anzuzeigen
        private void ShowChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            
            childForm.BringToFront();
            childForm.Show();
        }

        #region UnterMenus Anzeige

        private void SetMenuVisibility()
        {
            panel_schuelerMenu.Visible = false;
            panel_lehrerMenu.Visible = false;
            panel_faecherMenu.Visible = false;
            panel_notenMenu.Visible = false;
        }

        private void HideMenus()
        {
            if (panel_schuelerMenu.Visible == true)
                panel_schuelerMenu.Visible = false;
            if (panel_lehrerMenu.Visible == true)
                panel_lehrerMenu.Visible = false;
            if (panel_faecherMenu.Visible == true)
                panel_faecherMenu.Visible = false;
            if (panel_notenMenu.Visible == true)
                panel_notenMenu.Visible = false;
        }

        private void ShowMenus(Panel menu)
        {
            if (menu.Visible == false)
            {
                HideMenus();
                menu.Visible = true;
            }
            else
                menu.Visible = false;
        }

        #endregion

        #region SchuelerMenu

        private void button_schueler_Click(object sender, EventArgs e)
        {
            ShowMenus(panel_schuelerMenu);
        }
        private void button_schuelerNeu_Click(object sender, EventArgs e)
        {
            ShowChildForm(new SchuelerNeuForm());
            HideMenus();
        }
        private void button_schuelerBearbeiten_Click(object sender, EventArgs e)
        {
            ShowChildForm(new SchuelerBearbeitenForm());
            HideMenus();
        }

        #endregion

        #region LehrerMenu

        private void button_lehrer_Click(object sender, EventArgs e)
        {
            ShowMenus(panel_lehrerMenu);
        }
        private void button_lehrerNeu_Click(object sender, EventArgs e)
        {
            ShowChildForm(new LehrerNeuForm());
            HideMenus();
        }
        private void button_lehrerBearbeiten_Click(object sender, EventArgs e)
        {
            ShowChildForm(new LehrerBearbeitenForm());
            HideMenus();
        }

        #endregion

        #region FaecherMenu

        private void button_faecher_Click(object sender, EventArgs e)
        {
            ShowMenus(panel_faecherMenu);
        }
        private void button_fachNeu_Click(object sender, EventArgs e)
        {
            ShowChildForm(new FachNeuForm());
            HideMenus();
        }
        private void button_fachBearbeiten_Click(object sender, EventArgs e)
        {
            ShowChildForm(new FachBearbeitenForm());
            HideMenus();
        }

        #endregion

        #region NotenMenu

        private void button_noten_Click(object sender, EventArgs e)
        {
            ShowMenus(panel_notenMenu);
        }
        private void button_notenNeu_Click(object sender, EventArgs e)
        {
            ShowChildForm(new NotenNeuForm());
            HideMenus();
        }
        
        #endregion

        // Rückkehr zum Hauptfenster durch anklicken des Logos
        private void panel_logo_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            panel_main.Controls.Add(panel_cover);
            label_schuelerGesamt.Text = "Schueler gesamt: " + schuler.CountSchueler();
            label_lehrerGesamt.Text = "Lehrer gesamt: " + lehrer.CountLehrer();
        }
        private void pictureBox_logo_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            panel_main.Controls.Add(panel_cover);
            label_schuelerGesamt.Text = "Schueler gesamt: " + schuler.CountSchueler();
            label_lehrerGesamt.Text = "Lehrer gesamt: " + lehrer.CountLehrer();
        }

        // Zurück zum Anmeldebildschirm
        private void button_beenden_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();

            login.Show();
        }

        
    }
}
