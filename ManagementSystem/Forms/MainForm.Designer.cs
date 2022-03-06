namespace ManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_slide = new System.Windows.Forms.Panel();
            this.button_beenden = new System.Windows.Forms.Button();
            this.panel_notenMenu = new System.Windows.Forms.Panel();
            this.button_notenNeu = new System.Windows.Forms.Button();
            this.button_noten = new System.Windows.Forms.Button();
            this.panel_faecherMenu = new System.Windows.Forms.Panel();
            this.button_fachBearbeiten = new System.Windows.Forms.Button();
            this.button_fachNeu = new System.Windows.Forms.Button();
            this.button_faecher = new System.Windows.Forms.Button();
            this.panel_lehrerMenu = new System.Windows.Forms.Panel();
            this.button_lehrerBearbeiten = new System.Windows.Forms.Button();
            this.button_lehrerNeu = new System.Windows.Forms.Button();
            this.button_lehrer = new System.Windows.Forms.Button();
            this.panel_schuelerMenu = new System.Windows.Forms.Panel();
            this.button_schuelerBearbeiten = new System.Windows.Forms.Button();
            this.button_schuelerNeu = new System.Windows.Forms.Button();
            this.button_schueler = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_cover = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_lehrerGesamt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_schuelerGesamt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_role = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.panel_slide.SuspendLayout();
            this.panel_notenMenu.SuspendLayout();
            this.panel_faecherMenu.SuspendLayout();
            this.panel_lehrerMenu.SuspendLayout();
            this.panel_schuelerMenu.SuspendLayout();
            this.panel_logo.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.panel_cover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_slide
            // 
            this.panel_slide.AutoScroll = true;
            this.panel_slide.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel_slide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_slide.Controls.Add(this.button_beenden);
            this.panel_slide.Controls.Add(this.panel_notenMenu);
            this.panel_slide.Controls.Add(this.button_noten);
            this.panel_slide.Controls.Add(this.panel_faecherMenu);
            this.panel_slide.Controls.Add(this.button_faecher);
            this.panel_slide.Controls.Add(this.panel_lehrerMenu);
            this.panel_slide.Controls.Add(this.button_lehrer);
            this.panel_slide.Controls.Add(this.panel_schuelerMenu);
            this.panel_slide.Controls.Add(this.button_schueler);
            this.panel_slide.Controls.Add(this.panel_logo);
            this.panel_slide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_slide.Location = new System.Drawing.Point(0, 0);
            this.panel_slide.Margin = new System.Windows.Forms.Padding(4);
            this.panel_slide.Name = "panel_slide";
            this.panel_slide.Size = new System.Drawing.Size(230, 611);
            this.panel_slide.TabIndex = 0;
            // 
            // button_beenden
            // 
            this.button_beenden.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_beenden.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_beenden.FlatAppearance.BorderSize = 0;
            this.button_beenden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_beenden.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_beenden.ForeColor = System.Drawing.Color.White;
            this.button_beenden.Location = new System.Drawing.Point(0, 704);
            this.button_beenden.Margin = new System.Windows.Forms.Padding(4);
            this.button_beenden.Name = "button_beenden";
            this.button_beenden.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.button_beenden.Size = new System.Drawing.Size(211, 55);
            this.button_beenden.TabIndex = 9;
            this.button_beenden.Text = "Programm beenden";
            this.button_beenden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_beenden.UseVisualStyleBackColor = false;
            this.button_beenden.Click += new System.EventHandler(this.button_beenden_Click);
            // 
            // panel_notenMenu
            // 
            this.panel_notenMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_notenMenu.Controls.Add(this.button_notenNeu);
            this.panel_notenMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_notenMenu.Location = new System.Drawing.Point(0, 653);
            this.panel_notenMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panel_notenMenu.Name = "panel_notenMenu";
            this.panel_notenMenu.Size = new System.Drawing.Size(211, 51);
            this.panel_notenMenu.TabIndex = 8;
            // 
            // button_notenNeu
            // 
            this.button_notenNeu.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_notenNeu.FlatAppearance.BorderSize = 0;
            this.button_notenNeu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_notenNeu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_notenNeu.ForeColor = System.Drawing.Color.White;
            this.button_notenNeu.Location = new System.Drawing.Point(0, 0);
            this.button_notenNeu.Margin = new System.Windows.Forms.Padding(4);
            this.button_notenNeu.Name = "button_notenNeu";
            this.button_notenNeu.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.button_notenNeu.Size = new System.Drawing.Size(211, 50);
            this.button_notenNeu.TabIndex = 0;
            this.button_notenNeu.Text = "Noten vergeben";
            this.button_notenNeu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_notenNeu.UseVisualStyleBackColor = true;
            this.button_notenNeu.Click += new System.EventHandler(this.button_notenNeu_Click);
            // 
            // button_noten
            // 
            this.button_noten.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_noten.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_noten.FlatAppearance.BorderSize = 0;
            this.button_noten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_noten.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_noten.ForeColor = System.Drawing.Color.White;
            this.button_noten.Location = new System.Drawing.Point(0, 598);
            this.button_noten.Margin = new System.Windows.Forms.Padding(4);
            this.button_noten.Name = "button_noten";
            this.button_noten.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.button_noten.Size = new System.Drawing.Size(211, 55);
            this.button_noten.TabIndex = 7;
            this.button_noten.Text = "Noten";
            this.button_noten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_noten.UseVisualStyleBackColor = false;
            this.button_noten.Click += new System.EventHandler(this.button_noten_Click);
            // 
            // panel_faecherMenu
            // 
            this.panel_faecherMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_faecherMenu.Controls.Add(this.button_fachBearbeiten);
            this.panel_faecherMenu.Controls.Add(this.button_fachNeu);
            this.panel_faecherMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_faecherMenu.Location = new System.Drawing.Point(0, 501);
            this.panel_faecherMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panel_faecherMenu.Name = "panel_faecherMenu";
            this.panel_faecherMenu.Size = new System.Drawing.Size(211, 97);
            this.panel_faecherMenu.TabIndex = 6;
            // 
            // button_fachBearbeiten
            // 
            this.button_fachBearbeiten.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_fachBearbeiten.FlatAppearance.BorderSize = 0;
            this.button_fachBearbeiten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fachBearbeiten.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_fachBearbeiten.ForeColor = System.Drawing.Color.White;
            this.button_fachBearbeiten.Location = new System.Drawing.Point(0, 50);
            this.button_fachBearbeiten.Margin = new System.Windows.Forms.Padding(4);
            this.button_fachBearbeiten.Name = "button_fachBearbeiten";
            this.button_fachBearbeiten.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.button_fachBearbeiten.Size = new System.Drawing.Size(211, 47);
            this.button_fachBearbeiten.TabIndex = 1;
            this.button_fachBearbeiten.Text = "Fach bearbeiten";
            this.button_fachBearbeiten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_fachBearbeiten.UseVisualStyleBackColor = true;
            this.button_fachBearbeiten.Click += new System.EventHandler(this.button_fachBearbeiten_Click);
            // 
            // button_fachNeu
            // 
            this.button_fachNeu.BackColor = System.Drawing.Color.SteelBlue;
            this.button_fachNeu.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_fachNeu.FlatAppearance.BorderSize = 0;
            this.button_fachNeu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fachNeu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_fachNeu.ForeColor = System.Drawing.Color.White;
            this.button_fachNeu.Location = new System.Drawing.Point(0, 0);
            this.button_fachNeu.Margin = new System.Windows.Forms.Padding(4);
            this.button_fachNeu.Name = "button_fachNeu";
            this.button_fachNeu.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.button_fachNeu.Size = new System.Drawing.Size(211, 50);
            this.button_fachNeu.TabIndex = 0;
            this.button_fachNeu.Text = "Neues Fach";
            this.button_fachNeu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_fachNeu.UseVisualStyleBackColor = false;
            this.button_fachNeu.Click += new System.EventHandler(this.button_fachNeu_Click);
            // 
            // button_faecher
            // 
            this.button_faecher.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_faecher.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_faecher.FlatAppearance.BorderSize = 0;
            this.button_faecher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_faecher.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_faecher.ForeColor = System.Drawing.Color.White;
            this.button_faecher.Location = new System.Drawing.Point(0, 454);
            this.button_faecher.Margin = new System.Windows.Forms.Padding(4);
            this.button_faecher.Name = "button_faecher";
            this.button_faecher.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.button_faecher.Size = new System.Drawing.Size(211, 47);
            this.button_faecher.TabIndex = 5;
            this.button_faecher.Text = "Faecher";
            this.button_faecher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_faecher.UseVisualStyleBackColor = false;
            this.button_faecher.Click += new System.EventHandler(this.button_faecher_Click);
            // 
            // panel_lehrerMenu
            // 
            this.panel_lehrerMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_lehrerMenu.Controls.Add(this.button_lehrerBearbeiten);
            this.panel_lehrerMenu.Controls.Add(this.button_lehrerNeu);
            this.panel_lehrerMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_lehrerMenu.Location = new System.Drawing.Point(0, 349);
            this.panel_lehrerMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panel_lehrerMenu.Name = "panel_lehrerMenu";
            this.panel_lehrerMenu.Size = new System.Drawing.Size(211, 105);
            this.panel_lehrerMenu.TabIndex = 4;
            // 
            // button_lehrerBearbeiten
            // 
            this.button_lehrerBearbeiten.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_lehrerBearbeiten.FlatAppearance.BorderSize = 0;
            this.button_lehrerBearbeiten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_lehrerBearbeiten.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_lehrerBearbeiten.ForeColor = System.Drawing.Color.White;
            this.button_lehrerBearbeiten.Location = new System.Drawing.Point(0, 50);
            this.button_lehrerBearbeiten.Margin = new System.Windows.Forms.Padding(4);
            this.button_lehrerBearbeiten.Name = "button_lehrerBearbeiten";
            this.button_lehrerBearbeiten.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.button_lehrerBearbeiten.Size = new System.Drawing.Size(211, 50);
            this.button_lehrerBearbeiten.TabIndex = 1;
            this.button_lehrerBearbeiten.Text = "Lehrer bearbeiten";
            this.button_lehrerBearbeiten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_lehrerBearbeiten.UseVisualStyleBackColor = true;
            this.button_lehrerBearbeiten.Click += new System.EventHandler(this.button_lehrerBearbeiten_Click);
            // 
            // button_lehrerNeu
            // 
            this.button_lehrerNeu.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_lehrerNeu.FlatAppearance.BorderSize = 0;
            this.button_lehrerNeu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_lehrerNeu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_lehrerNeu.ForeColor = System.Drawing.Color.White;
            this.button_lehrerNeu.Location = new System.Drawing.Point(0, 0);
            this.button_lehrerNeu.Margin = new System.Windows.Forms.Padding(4);
            this.button_lehrerNeu.Name = "button_lehrerNeu";
            this.button_lehrerNeu.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.button_lehrerNeu.Size = new System.Drawing.Size(211, 50);
            this.button_lehrerNeu.TabIndex = 0;
            this.button_lehrerNeu.Text = "Neuer Lehrer";
            this.button_lehrerNeu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_lehrerNeu.UseVisualStyleBackColor = true;
            this.button_lehrerNeu.Click += new System.EventHandler(this.button_lehrerNeu_Click);
            // 
            // button_lehrer
            // 
            this.button_lehrer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_lehrer.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_lehrer.FlatAppearance.BorderSize = 0;
            this.button_lehrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_lehrer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_lehrer.ForeColor = System.Drawing.Color.White;
            this.button_lehrer.Location = new System.Drawing.Point(0, 294);
            this.button_lehrer.Margin = new System.Windows.Forms.Padding(4);
            this.button_lehrer.Name = "button_lehrer";
            this.button_lehrer.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.button_lehrer.Size = new System.Drawing.Size(211, 55);
            this.button_lehrer.TabIndex = 3;
            this.button_lehrer.Text = "Lehrer";
            this.button_lehrer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_lehrer.UseVisualStyleBackColor = false;
            this.button_lehrer.Click += new System.EventHandler(this.button_lehrer_Click);
            // 
            // panel_schuelerMenu
            // 
            this.panel_schuelerMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_schuelerMenu.Controls.Add(this.button_schuelerBearbeiten);
            this.panel_schuelerMenu.Controls.Add(this.button_schuelerNeu);
            this.panel_schuelerMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_schuelerMenu.Location = new System.Drawing.Point(0, 195);
            this.panel_schuelerMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panel_schuelerMenu.Name = "panel_schuelerMenu";
            this.panel_schuelerMenu.Size = new System.Drawing.Size(211, 99);
            this.panel_schuelerMenu.TabIndex = 2;
            // 
            // button_schuelerBearbeiten
            // 
            this.button_schuelerBearbeiten.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_schuelerBearbeiten.FlatAppearance.BorderSize = 0;
            this.button_schuelerBearbeiten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_schuelerBearbeiten.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_schuelerBearbeiten.ForeColor = System.Drawing.Color.White;
            this.button_schuelerBearbeiten.Location = new System.Drawing.Point(0, 50);
            this.button_schuelerBearbeiten.Margin = new System.Windows.Forms.Padding(4);
            this.button_schuelerBearbeiten.Name = "button_schuelerBearbeiten";
            this.button_schuelerBearbeiten.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.button_schuelerBearbeiten.Size = new System.Drawing.Size(211, 49);
            this.button_schuelerBearbeiten.TabIndex = 1;
            this.button_schuelerBearbeiten.Text = "Schueler bearbeiten";
            this.button_schuelerBearbeiten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_schuelerBearbeiten.UseVisualStyleBackColor = true;
            this.button_schuelerBearbeiten.Click += new System.EventHandler(this.button_schuelerBearbeiten_Click);
            // 
            // button_schuelerNeu
            // 
            this.button_schuelerNeu.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_schuelerNeu.FlatAppearance.BorderSize = 0;
            this.button_schuelerNeu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_schuelerNeu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_schuelerNeu.ForeColor = System.Drawing.Color.White;
            this.button_schuelerNeu.Location = new System.Drawing.Point(0, 0);
            this.button_schuelerNeu.Margin = new System.Windows.Forms.Padding(4);
            this.button_schuelerNeu.Name = "button_schuelerNeu";
            this.button_schuelerNeu.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.button_schuelerNeu.Size = new System.Drawing.Size(211, 50);
            this.button_schuelerNeu.TabIndex = 0;
            this.button_schuelerNeu.Text = "Neuer Schueler";
            this.button_schuelerNeu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_schuelerNeu.UseVisualStyleBackColor = true;
            this.button_schuelerNeu.Click += new System.EventHandler(this.button_schuelerNeu_Click);
            // 
            // button_schueler
            // 
            this.button_schueler.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_schueler.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_schueler.FlatAppearance.BorderSize = 0;
            this.button_schueler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_schueler.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_schueler.ForeColor = System.Drawing.Color.White;
            this.button_schueler.Location = new System.Drawing.Point(0, 140);
            this.button_schueler.Margin = new System.Windows.Forms.Padding(4);
            this.button_schueler.Name = "button_schueler";
            this.button_schueler.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.button_schueler.Size = new System.Drawing.Size(211, 55);
            this.button_schueler.TabIndex = 1;
            this.button_schueler.Text = "Schueler";
            this.button_schueler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_schueler.UseVisualStyleBackColor = false;
            this.button_schueler.Click += new System.EventHandler(this.button_schueler_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel_logo.Controls.Add(this.pictureBox_logo);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Margin = new System.Windows.Forms.Padding(4);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(211, 140);
            this.panel_logo.TabIndex = 0;
            this.panel_logo.Click += new System.EventHandler(this.panel_logo_Click);
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_cover);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(230, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(904, 611);
            this.panel_main.TabIndex = 2;
            // 
            // panel_cover
            // 
            this.panel_cover.Controls.Add(this.pictureBox2);
            this.panel_cover.Controls.Add(this.panel3);
            this.panel_cover.Controls.Add(this.panel2);
            this.panel_cover.Controls.Add(this.panel1);
            this.panel_cover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_cover.Location = new System.Drawing.Point(0, 0);
            this.panel_cover.Name = "panel_cover";
            this.panel_cover.Size = new System.Drawing.Size(904, 611);
            this.panel_cover.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(898, 348);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.label_lehrerGesamt);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label_schuelerGesamt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 500);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(904, 111);
            this.panel3.TabIndex = 2;
            // 
            // label_lehrerGesamt
            // 
            this.label_lehrerGesamt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_lehrerGesamt.AutoSize = true;
            this.label_lehrerGesamt.ForeColor = System.Drawing.Color.White;
            this.label_lehrerGesamt.Location = new System.Drawing.Point(209, 19);
            this.label_lehrerGesamt.Name = "label_lehrerGesamt";
            this.label_lehrerGesamt.Size = new System.Drawing.Size(106, 19);
            this.label_lehrerGesamt.TabIndex = 5;
            this.label_lehrerGesamt.Text = "Lehrer gesamt:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(745, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "74398 Schulort";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(754, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Schulstraße 5";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(754, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Große Schule";
            // 
            // label_schuelerGesamt
            // 
            this.label_schuelerGesamt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_schuelerGesamt.AutoSize = true;
            this.label_schuelerGesamt.ForeColor = System.Drawing.Color.White;
            this.label_schuelerGesamt.Location = new System.Drawing.Point(23, 19);
            this.label_schuelerGesamt.Name = "label_schuelerGesamt";
            this.label_schuelerGesamt.Size = new System.Drawing.Size(120, 19);
            this.label_schuelerGesamt.TabIndex = 1;
            this.label_schuelerGesamt.Text = "Schueler gesamt:";
            this.label_schuelerGesamt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label_role);
            this.panel2.Controls.Add(this.label_user);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 70);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = global::ManagementSystem.Properties.Resources.klassenzimmer;
            this.pictureBox1.Location = new System.Drawing.Point(801, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label_role
            // 
            this.label_role.AutoSize = true;
            this.label_role.ForeColor = System.Drawing.Color.White;
            this.label_role.Location = new System.Drawing.Point(120, 36);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(50, 19);
            this.label_role.TabIndex = 3;
            this.label_role.Text = "Admin";
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.ForeColor = System.Drawing.Color.White;
            this.label_user.Location = new System.Drawing.Point(120, 17);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(49, 19);
            this.label_user.TabIndex = 2;
            this.label_user.Text = "admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(82, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "als:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angemeldet:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 70);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(241, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(384, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Willkommen in der Großen Schule";
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::ManagementSystem.Properties.Resources.schule;
            this.pictureBox_logo.Location = new System.Drawing.Point(11, 11);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(181, 113);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            this.pictureBox_logo.Click += new System.EventHandler(this.pictureBox_logo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_slide);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1150, 650);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_slide.ResumeLayout(false);
            this.panel_notenMenu.ResumeLayout(false);
            this.panel_faecherMenu.ResumeLayout(false);
            this.panel_lehrerMenu.ResumeLayout(false);
            this.panel_schuelerMenu.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panel_main.ResumeLayout(false);
            this.panel_cover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_slide;
        private System.Windows.Forms.Panel panel_schuelerMenu;
        private System.Windows.Forms.Button button_schuelerBearbeiten;
        private System.Windows.Forms.Button button_schuelerNeu;
        private System.Windows.Forms.Button button_schueler;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Button button_beenden;
        private System.Windows.Forms.Panel panel_notenMenu;
        private System.Windows.Forms.Button button_notenNeu;
        private System.Windows.Forms.Button button_noten;
        private System.Windows.Forms.Panel panel_faecherMenu;
        private System.Windows.Forms.Button button_fachBearbeiten;
        private System.Windows.Forms.Button button_fachNeu;
        private System.Windows.Forms.Button button_faecher;
        private System.Windows.Forms.Panel panel_lehrerMenu;
        private System.Windows.Forms.Button button_lehrerBearbeiten;
        private System.Windows.Forms.Button button_lehrerNeu;
        private System.Windows.Forms.Button button_lehrer;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_cover;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_lehrerGesamt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_schuelerGesamt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_role;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox_logo;
    }
}

