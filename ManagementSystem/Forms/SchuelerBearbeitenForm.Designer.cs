﻿namespace ManagementSystem.Forms
{
    partial class SchuelerBearbeitenForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridView_schueler = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_schuelerSuchen = new System.Windows.Forms.Button();
            this.textBox_schuelerSuchen = new System.Windows.Forms.TextBox();
            this.textBox_schuelerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_eingabeZuruecksetzen = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_eingabeUebernehmen = new System.Windows.Forms.Button();
            this.button_entferneSchueler = new System.Windows.Forms.Button();
            this.textBox_telNummer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_bildHochladen = new System.Windows.Forms.Button();
            this.pictureBox_schuelerBild = new System.Windows.Forms.PictureBox();
            this.textBox_adresse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_weiblich = new System.Windows.Forms.RadioButton();
            this.radioButton_maennlich = new System.Windows.Forms.RadioButton();
            this.label_geschlecht = new System.Windows.Forms.Label();
            this.dateTimePicker_geburtsdatum = new System.Windows.Forms.DateTimePicker();
            this.label_geburtsdatum = new System.Windows.Forms.Label();
            this.textBox_nachname = new System.Windows.Forms.TextBox();
            this.label_nachname = new System.Windows.Forms.Label();
            this.textBox_vorname = new System.Windows.Forms.TextBox();
            this.label_vorname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_schueler)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_schuelerBild)).BeginInit();
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
            this.panel1.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Schueler bearbeiten";
            // 
            // DataGridView_schueler
            // 
            this.DataGridView_schueler.AllowUserToAddRows = false;
            this.DataGridView_schueler.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_schueler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_schueler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.DataGridView_schueler.Location = new System.Drawing.Point(12, 76);
            this.DataGridView_schueler.Name = "DataGridView_schueler";
            this.DataGridView_schueler.RowHeadersVisible = false;
            this.DataGridView_schueler.RowTemplate.Height = 80;
            this.DataGridView_schueler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_schueler.Size = new System.Drawing.Size(880, 245);
            this.DataGridView_schueler.TabIndex = 23;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.button_schuelerSuchen);
            this.panel2.Controls.Add(this.textBox_schuelerSuchen);
            this.panel2.Controls.Add(this.textBox_schuelerID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button_eingabeZuruecksetzen);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button_eingabeUebernehmen);
            this.panel2.Controls.Add(this.button_entferneSchueler);
            this.panel2.Controls.Add(this.textBox_telNummer);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button_bildHochladen);
            this.panel2.Controls.Add(this.pictureBox_schuelerBild);
            this.panel2.Controls.Add(this.textBox_adresse);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.radioButton_weiblich);
            this.panel2.Controls.Add(this.radioButton_maennlich);
            this.panel2.Controls.Add(this.label_geschlecht);
            this.panel2.Controls.Add(this.dateTimePicker_geburtsdatum);
            this.panel2.Controls.Add(this.label_geburtsdatum);
            this.panel2.Controls.Add(this.textBox_nachname);
            this.panel2.Controls.Add(this.label_nachname);
            this.panel2.Controls.Add(this.textBox_vorname);
            this.panel2.Controls.Add(this.label_vorname);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 291);
            this.panel2.TabIndex = 40;
            // 
            // button_schuelerSuchen
            // 
            this.button_schuelerSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_schuelerSuchen.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_schuelerSuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_schuelerSuchen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_schuelerSuchen.ForeColor = System.Drawing.Color.White;
            this.button_schuelerSuchen.Location = new System.Drawing.Point(26, 252);
            this.button_schuelerSuchen.Name = "button_schuelerSuchen";
            this.button_schuelerSuchen.Size = new System.Drawing.Size(125, 30);
            this.button_schuelerSuchen.TabIndex = 64;
            this.button_schuelerSuchen.Text = "Suchen";
            this.button_schuelerSuchen.UseVisualStyleBackColor = false;
            this.button_schuelerSuchen.Click += new System.EventHandler(this.button_schuelerSuchen_Click);
            // 
            // textBox_schuelerSuchen
            // 
            this.textBox_schuelerSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_schuelerSuchen.Location = new System.Drawing.Point(157, 252);
            this.textBox_schuelerSuchen.Name = "textBox_schuelerSuchen";
            this.textBox_schuelerSuchen.Size = new System.Drawing.Size(248, 27);
            this.textBox_schuelerSuchen.TabIndex = 63;
            // 
            // textBox_schuelerID
            // 
            this.textBox_schuelerID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_schuelerID.Location = new System.Drawing.Point(153, 27);
            this.textBox_schuelerID.Name = "textBox_schuelerID";
            this.textBox_schuelerID.Size = new System.Drawing.Size(100, 27);
            this.textBox_schuelerID.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(61, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 61;
            this.label4.Text = "Schueler ID:";
            // 
            // button_eingabeZuruecksetzen
            // 
            this.button_eingabeZuruecksetzen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_eingabeZuruecksetzen.BackColor = System.Drawing.Color.Orange;
            this.button_eingabeZuruecksetzen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eingabeZuruecksetzen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eingabeZuruecksetzen.ForeColor = System.Drawing.Color.White;
            this.button_eingabeZuruecksetzen.Location = new System.Drawing.Point(602, 252);
            this.button_eingabeZuruecksetzen.Name = "button_eingabeZuruecksetzen";
            this.button_eingabeZuruecksetzen.Size = new System.Drawing.Size(125, 30);
            this.button_eingabeZuruecksetzen.TabIndex = 60;
            this.button_eingabeZuruecksetzen.Text = "Zuruecksetzen";
            this.button_eingabeZuruecksetzen.UseVisualStyleBackColor = false;
            this.button_eingabeZuruecksetzen.Click += new System.EventHandler(this.button_eingabeZuruecksetzen_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Location = new System.Drawing.Point(-10, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(934, 10);
            this.panel3.TabIndex = 59;
            // 
            // button_eingabeUebernehmen
            // 
            this.button_eingabeUebernehmen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_eingabeUebernehmen.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_eingabeUebernehmen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eingabeUebernehmen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eingabeUebernehmen.ForeColor = System.Drawing.Color.White;
            this.button_eingabeUebernehmen.Location = new System.Drawing.Point(757, 252);
            this.button_eingabeUebernehmen.Name = "button_eingabeUebernehmen";
            this.button_eingabeUebernehmen.Size = new System.Drawing.Size(125, 30);
            this.button_eingabeUebernehmen.TabIndex = 58;
            this.button_eingabeUebernehmen.Text = "Uebernehmen";
            this.button_eingabeUebernehmen.UseVisualStyleBackColor = false;
            this.button_eingabeUebernehmen.Click += new System.EventHandler(this.button_eingabeUebernehmen_Click);
            // 
            // button_entferneSchueler
            // 
            this.button_entferneSchueler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_entferneSchueler.BackColor = System.Drawing.Color.Red;
            this.button_entferneSchueler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_entferneSchueler.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_entferneSchueler.ForeColor = System.Drawing.Color.White;
            this.button_entferneSchueler.Location = new System.Drawing.Point(441, 252);
            this.button_entferneSchueler.Name = "button_entferneSchueler";
            this.button_entferneSchueler.Size = new System.Drawing.Size(125, 30);
            this.button_entferneSchueler.TabIndex = 57;
            this.button_entferneSchueler.Text = "Entfernen";
            this.button_entferneSchueler.UseVisualStyleBackColor = false;
            this.button_entferneSchueler.Click += new System.EventHandler(this.button_entferneSchueler_Click);
            // 
            // textBox_telNummer
            // 
            this.textBox_telNummer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_telNummer.Location = new System.Drawing.Point(526, 159);
            this.textBox_telNummer.Name = "textBox_telNummer";
            this.textBox_telNummer.Size = new System.Drawing.Size(183, 27);
            this.textBox_telNummer.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(448, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 55;
            this.label2.Text = "Telefon:";
            // 
            // button_bildHochladen
            // 
            this.button_bildHochladen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_bildHochladen.BackColor = System.Drawing.Color.Green;
            this.button_bildHochladen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bildHochladen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bildHochladen.ForeColor = System.Drawing.Color.White;
            this.button_bildHochladen.Location = new System.Drawing.Point(757, 180);
            this.button_bildHochladen.Name = "button_bildHochladen";
            this.button_bildHochladen.Size = new System.Drawing.Size(125, 30);
            this.button_bildHochladen.TabIndex = 54;
            this.button_bildHochladen.Text = "Bild hochladen";
            this.button_bildHochladen.UseVisualStyleBackColor = false;
            this.button_bildHochladen.Click += new System.EventHandler(this.button_bildHochladen_Click);
            // 
            // pictureBox_schuelerBild
            // 
            this.pictureBox_schuelerBild.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_schuelerBild.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox_schuelerBild.Image = global::ManagementSystem.Properties.Resources.student__1_;
            this.pictureBox_schuelerBild.Location = new System.Drawing.Point(757, 62);
            this.pictureBox_schuelerBild.Name = "pictureBox_schuelerBild";
            this.pictureBox_schuelerBild.Size = new System.Drawing.Size(125, 112);
            this.pictureBox_schuelerBild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_schuelerBild.TabIndex = 53;
            this.pictureBox_schuelerBild.TabStop = false;
            // 
            // textBox_adresse
            // 
            this.textBox_adresse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_adresse.Location = new System.Drawing.Point(153, 149);
            this.textBox_adresse.Multiline = true;
            this.textBox_adresse.Name = "textBox_adresse";
            this.textBox_adresse.Size = new System.Drawing.Size(252, 66);
            this.textBox_adresse.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(85, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 51;
            this.label1.Text = "Adresse:";
            // 
            // radioButton_weiblich
            // 
            this.radioButton_weiblich.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_weiblich.AutoSize = true;
            this.radioButton_weiblich.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_weiblich.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.radioButton_weiblich.Location = new System.Drawing.Point(617, 116);
            this.radioButton_weiblich.Name = "radioButton_weiblich";
            this.radioButton_weiblich.Size = new System.Drawing.Size(81, 23);
            this.radioButton_weiblich.TabIndex = 50;
            this.radioButton_weiblich.Text = "weiblich";
            this.radioButton_weiblich.UseVisualStyleBackColor = true;
            // 
            // radioButton_maennlich
            // 
            this.radioButton_maennlich.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_maennlich.AutoSize = true;
            this.radioButton_maennlich.Checked = true;
            this.radioButton_maennlich.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_maennlich.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.radioButton_maennlich.Location = new System.Drawing.Point(517, 116);
            this.radioButton_maennlich.Name = "radioButton_maennlich";
            this.radioButton_maennlich.Size = new System.Drawing.Size(94, 23);
            this.radioButton_maennlich.TabIndex = 49;
            this.radioButton_maennlich.TabStop = true;
            this.radioButton_maennlich.Text = "maennlich";
            this.radioButton_maennlich.UseVisualStyleBackColor = true;
            // 
            // label_geschlecht
            // 
            this.label_geschlecht.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_geschlecht.AutoSize = true;
            this.label_geschlecht.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_geschlecht.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_geschlecht.Location = new System.Drawing.Point(424, 118);
            this.label_geschlecht.Name = "label_geschlecht";
            this.label_geschlecht.Size = new System.Drawing.Size(87, 19);
            this.label_geschlecht.TabIndex = 48;
            this.label_geschlecht.Text = "Geschlecht:";
            // 
            // dateTimePicker_geburtsdatum
            // 
            this.dateTimePicker_geburtsdatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_geburtsdatum.Location = new System.Drawing.Point(153, 111);
            this.dateTimePicker_geburtsdatum.Name = "dateTimePicker_geburtsdatum";
            this.dateTimePicker_geburtsdatum.Size = new System.Drawing.Size(252, 27);
            this.dateTimePicker_geburtsdatum.TabIndex = 47;
            // 
            // label_geburtsdatum
            // 
            this.label_geburtsdatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_geburtsdatum.AutoSize = true;
            this.label_geburtsdatum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_geburtsdatum.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_geburtsdatum.Location = new System.Drawing.Point(39, 111);
            this.label_geburtsdatum.Name = "label_geburtsdatum";
            this.label_geburtsdatum.Size = new System.Drawing.Size(112, 19);
            this.label_geburtsdatum.TabIndex = 46;
            this.label_geburtsdatum.Text = "Geburtsdatum:";
            // 
            // textBox_nachname
            // 
            this.textBox_nachname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_nachname.Location = new System.Drawing.Point(526, 67);
            this.textBox_nachname.Name = "textBox_nachname";
            this.textBox_nachname.Size = new System.Drawing.Size(183, 27);
            this.textBox_nachname.TabIndex = 45;
            // 
            // label_nachname
            // 
            this.label_nachname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_nachname.AutoSize = true;
            this.label_nachname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nachname.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_nachname.Location = new System.Drawing.Point(425, 70);
            this.label_nachname.Name = "label_nachname";
            this.label_nachname.Size = new System.Drawing.Size(86, 19);
            this.label_nachname.TabIndex = 44;
            this.label_nachname.Text = "Nachname:";
            // 
            // textBox_vorname
            // 
            this.textBox_vorname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_vorname.Location = new System.Drawing.Point(153, 67);
            this.textBox_vorname.Name = "textBox_vorname";
            this.textBox_vorname.Size = new System.Drawing.Size(183, 27);
            this.textBox_vorname.TabIndex = 43;
            // 
            // label_vorname
            // 
            this.label_vorname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_vorname.AutoSize = true;
            this.label_vorname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vorname.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_vorname.Location = new System.Drawing.Point(77, 70);
            this.label_vorname.Name = "label_vorname";
            this.label_vorname.Size = new System.Drawing.Size(74, 19);
            this.label_vorname.TabIndex = 42;
            this.label_vorname.Text = "Vorname:";
            // 
            // SchuelerBearbeitenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGridView_schueler);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SchuelerBearbeitenForm";
            this.Text = "SchuelerBearbeitenForm";
            this.Load += new System.EventHandler(this.SchuelerBearbeitenForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_schueler)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_schuelerBild)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_schueler;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_eingabeZuruecksetzen;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_eingabeUebernehmen;
        private System.Windows.Forms.Button button_entferneSchueler;
        private System.Windows.Forms.TextBox textBox_telNummer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_bildHochladen;
        private System.Windows.Forms.PictureBox pictureBox_schuelerBild;
        private System.Windows.Forms.TextBox textBox_adresse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_weiblich;
        private System.Windows.Forms.RadioButton radioButton_maennlich;
        private System.Windows.Forms.Label label_geschlecht;
        private System.Windows.Forms.DateTimePicker dateTimePicker_geburtsdatum;
        private System.Windows.Forms.Label label_geburtsdatum;
        private System.Windows.Forms.TextBox textBox_nachname;
        private System.Windows.Forms.Label label_nachname;
        private System.Windows.Forms.TextBox textBox_vorname;
        private System.Windows.Forms.Label label_vorname;
        private System.Windows.Forms.Button button_schuelerSuchen;
        private System.Windows.Forms.TextBox textBox_schuelerSuchen;
        private System.Windows.Forms.TextBox textBox_schuelerID;
        private System.Windows.Forms.Label label4;
    }
}