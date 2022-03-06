namespace ManagementSystem.Forms
{
    partial class NotenNeuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_entfernen = new System.Windows.Forms.Button();
            this.button_uebernehmen = new System.Windows.Forms.Button();
            this.textBox_noteAendern = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_fachAuswahl = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_note = new System.Windows.Forms.DateTimePicker();
            this.textBox_note = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_noteVergeben = new System.Windows.Forms.Button();
            this.button_eingabeZuruecksetzen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_nachname = new System.Windows.Forms.Label();
            this.textBox_schuelerID = new System.Windows.Forms.TextBox();
            this.label_vorname = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DataGridView_schueler = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DataGridView_noten = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_schueler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_noten)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 70);
            this.panel1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Noten vergeben";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_entfernen);
            this.panel2.Controls.Add(this.button_uebernehmen);
            this.panel2.Controls.Add(this.textBox_noteAendern);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBox_fachAuswahl);
            this.panel2.Controls.Add(this.dateTimePicker_note);
            this.panel2.Controls.Add(this.textBox_note);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button_noteVergeben);
            this.panel2.Controls.Add(this.button_eingabeZuruecksetzen);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label_nachname);
            this.panel2.Controls.Add(this.textBox_schuelerID);
            this.panel2.Controls.Add(this.label_vorname);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 284);
            this.panel2.TabIndex = 22;
            // 
            // button_entfernen
            // 
            this.button_entfernen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_entfernen.BackColor = System.Drawing.Color.Red;
            this.button_entfernen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_entfernen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_entfernen.ForeColor = System.Drawing.Color.White;
            this.button_entfernen.Location = new System.Drawing.Point(600, 242);
            this.button_entfernen.Name = "button_entfernen";
            this.button_entfernen.Size = new System.Drawing.Size(125, 30);
            this.button_entfernen.TabIndex = 67;
            this.button_entfernen.Text = "Entfernen";
            this.button_entfernen.UseVisualStyleBackColor = false;
            this.button_entfernen.Click += new System.EventHandler(this.button_entfernen_Click);
            // 
            // button_uebernehmen
            // 
            this.button_uebernehmen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_uebernehmen.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_uebernehmen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_uebernehmen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_uebernehmen.ForeColor = System.Drawing.Color.White;
            this.button_uebernehmen.Location = new System.Drawing.Point(757, 242);
            this.button_uebernehmen.Name = "button_uebernehmen";
            this.button_uebernehmen.Size = new System.Drawing.Size(125, 30);
            this.button_uebernehmen.TabIndex = 66;
            this.button_uebernehmen.Text = "Uebernehmen";
            this.button_uebernehmen.UseVisualStyleBackColor = false;
            this.button_uebernehmen.Click += new System.EventHandler(this.button_uebernehmen_Click);
            // 
            // textBox_noteAendern
            // 
            this.textBox_noteAendern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_noteAendern.Location = new System.Drawing.Point(699, 33);
            this.textBox_noteAendern.Name = "textBox_noteAendern";
            this.textBox_noteAendern.Size = new System.Drawing.Size(183, 27);
            this.textBox_noteAendern.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(585, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Note aendern:";
            // 
            // comboBox_fachAuswahl
            // 
            this.comboBox_fachAuswahl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_fachAuswahl.FormattingEnabled = true;
            this.comboBox_fachAuswahl.Location = new System.Drawing.Point(108, 82);
            this.comboBox_fachAuswahl.Name = "comboBox_fachAuswahl";
            this.comboBox_fachAuswahl.Size = new System.Drawing.Size(183, 27);
            this.comboBox_fachAuswahl.TabIndex = 42;
            // 
            // dateTimePicker_note
            // 
            this.dateTimePicker_note.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker_note.Location = new System.Drawing.Point(108, 188);
            this.dateTimePicker_note.Name = "dateTimePicker_note";
            this.dateTimePicker_note.Size = new System.Drawing.Size(251, 27);
            this.dateTimePicker_note.TabIndex = 41;
            // 
            // textBox_note
            // 
            this.textBox_note.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_note.Location = new System.Drawing.Point(108, 134);
            this.textBox_note.Name = "textBox_note";
            this.textBox_note.Size = new System.Drawing.Size(183, 27);
            this.textBox_note.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(55, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Note:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Location = new System.Drawing.Point(-10, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(934, 10);
            this.panel3.TabIndex = 38;
            // 
            // button_noteVergeben
            // 
            this.button_noteVergeben.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_noteVergeben.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_noteVergeben.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_noteVergeben.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_noteVergeben.ForeColor = System.Drawing.Color.White;
            this.button_noteVergeben.Location = new System.Drawing.Point(36, 242);
            this.button_noteVergeben.Name = "button_noteVergeben";
            this.button_noteVergeben.Size = new System.Drawing.Size(125, 30);
            this.button_noteVergeben.TabIndex = 37;
            this.button_noteVergeben.Text = "Benoten";
            this.button_noteVergeben.UseVisualStyleBackColor = false;
            this.button_noteVergeben.Click += new System.EventHandler(this.button_noteVergeben_Click);
            // 
            // button_eingabeZuruecksetzen
            // 
            this.button_eingabeZuruecksetzen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_eingabeZuruecksetzen.BackColor = System.Drawing.Color.Orange;
            this.button_eingabeZuruecksetzen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eingabeZuruecksetzen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eingabeZuruecksetzen.ForeColor = System.Drawing.Color.White;
            this.button_eingabeZuruecksetzen.Location = new System.Drawing.Point(191, 242);
            this.button_eingabeZuruecksetzen.Name = "button_eingabeZuruecksetzen";
            this.button_eingabeZuruecksetzen.Size = new System.Drawing.Size(125, 30);
            this.button_eingabeZuruecksetzen.TabIndex = 36;
            this.button_eingabeZuruecksetzen.Text = "Zuruecksetzen";
            this.button_eingabeZuruecksetzen.UseVisualStyleBackColor = false;
            this.button_eingabeZuruecksetzen.Click += new System.EventHandler(this.button_eingabeZuruecksetzen_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(43, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Datum:";
            // 
            // label_nachname
            // 
            this.label_nachname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_nachname.AutoSize = true;
            this.label_nachname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nachname.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_nachname.Location = new System.Drawing.Point(58, 85);
            this.label_nachname.Name = "label_nachname";
            this.label_nachname.Size = new System.Drawing.Size(44, 19);
            this.label_nachname.TabIndex = 23;
            this.label_nachname.Text = "Fach:";
            // 
            // textBox_schuelerID
            // 
            this.textBox_schuelerID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_schuelerID.Location = new System.Drawing.Point(108, 30);
            this.textBox_schuelerID.Name = "textBox_schuelerID";
            this.textBox_schuelerID.Size = new System.Drawing.Size(183, 27);
            this.textBox_schuelerID.TabIndex = 22;
            // 
            // label_vorname
            // 
            this.label_vorname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_vorname.AutoSize = true;
            this.label_vorname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vorname.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_vorname.Location = new System.Drawing.Point(12, 33);
            this.label_vorname.Name = "label_vorname";
            this.label_vorname.Size = new System.Drawing.Size(90, 19);
            this.label_vorname.TabIndex = 21;
            this.label_vorname.Text = "Schueler ID:";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Location = new System.Drawing.Point(452, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 278);
            this.panel4.TabIndex = 43;
            // 
            // DataGridView_schueler
            // 
            this.DataGridView_schueler.AllowUserToAddRows = false;
            this.DataGridView_schueler.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_schueler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_schueler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataGridView_schueler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_schueler.BackgroundColor = System.Drawing.Color.LightGray;
            this.DataGridView_schueler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_schueler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_schueler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_schueler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_schueler.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_schueler.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_schueler.EnableHeadersVisualStyles = false;
            this.DataGridView_schueler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_schueler.Location = new System.Drawing.Point(4, 76);
            this.DataGridView_schueler.Name = "DataGridView_schueler";
            this.DataGridView_schueler.RowHeadersVisible = false;
            this.DataGridView_schueler.RowTemplate.Height = 80;
            this.DataGridView_schueler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_schueler.Size = new System.Drawing.Size(442, 245);
            this.DataGridView_schueler.TabIndex = 46;
            this.DataGridView_schueler.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_schueler.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_schueler.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_schueler.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_schueler.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_schueler.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.DataGridView_schueler.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_schueler.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_schueler.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_schueler.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_schueler.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_schueler.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_schueler.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_schueler.ThemeStyle.ReadOnly = false;
            this.DataGridView_schueler.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_schueler.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_schueler.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_schueler.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_schueler.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_schueler.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_schueler.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_schueler.Click += new System.EventHandler(this.DataGridView_schueler_Click);
            // 
            // DataGridView_noten
            // 
            this.DataGridView_noten.AllowUserToAddRows = false;
            this.DataGridView_noten.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridView_noten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView_noten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_noten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_noten.BackgroundColor = System.Drawing.Color.LightGray;
            this.DataGridView_noten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_noten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_noten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_noten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView_noten.ColumnHeadersHeight = 24;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_noten.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView_noten.EnableHeadersVisualStyles = false;
            this.DataGridView_noten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_noten.Location = new System.Drawing.Point(468, 76);
            this.DataGridView_noten.Name = "DataGridView_noten";
            this.DataGridView_noten.RowHeadersVisible = false;
            this.DataGridView_noten.RowTemplate.Height = 80;
            this.DataGridView_noten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_noten.Size = new System.Drawing.Size(434, 245);
            this.DataGridView_noten.TabIndex = 47;
            this.DataGridView_noten.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_noten.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_noten.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_noten.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_noten.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_noten.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.DataGridView_noten.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_noten.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_noten.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_noten.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_noten.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_noten.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_noten.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_noten.ThemeStyle.ReadOnly = false;
            this.DataGridView_noten.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_noten.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_noten.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_noten.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_noten.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_noten.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_noten.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_noten.Click += new System.EventHandler(this.DataGridView_noten_Click);
            // 
            // NotenNeuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 611);
            this.Controls.Add(this.DataGridView_noten);
            this.Controls.Add(this.DataGridView_schueler);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NotenNeuForm";
            this.Text = "NotenNeuForm";
            this.Load += new System.EventHandler(this.NotenNeuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_schueler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_noten)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_note;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_noteVergeben;
        private System.Windows.Forms.Button button_eingabeZuruecksetzen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_nachname;
        private System.Windows.Forms.TextBox textBox_schuelerID;
        private System.Windows.Forms.Label label_vorname;
        private System.Windows.Forms.ComboBox comboBox_fachAuswahl;
        private System.Windows.Forms.DateTimePicker dateTimePicker_note;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_schueler;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_noten;
        private System.Windows.Forms.TextBox textBox_noteAendern;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_entfernen;
        private System.Windows.Forms.Button button_uebernehmen;
    }
}