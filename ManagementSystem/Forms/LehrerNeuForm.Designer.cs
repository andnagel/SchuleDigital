namespace ManagementSystem.Forms
{
    partial class LehrerNeuForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_anlegen = new System.Windows.Forms.Button();
            this.button_eingabeZuruecksetzen = new System.Windows.Forms.Button();
            this.textBox_telNummer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_bildHochladen = new System.Windows.Forms.Button();
            this.pictureBox_lehrerBild = new System.Windows.Forms.PictureBox();
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
            this.DataGridView_lehrer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lehrerBild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_lehrer)).BeginInit();
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
            this.panel1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Neuer Lehrer";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button_anlegen);
            this.panel2.Controls.Add(this.button_eingabeZuruecksetzen);
            this.panel2.Controls.Add(this.textBox_telNummer);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button_bildHochladen);
            this.panel2.Controls.Add(this.pictureBox_lehrerBild);
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
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Location = new System.Drawing.Point(-10, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(934, 10);
            this.panel3.TabIndex = 38;
            // 
            // button_anlegen
            // 
            this.button_anlegen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_anlegen.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_anlegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_anlegen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_anlegen.ForeColor = System.Drawing.Color.White;
            this.button_anlegen.Location = new System.Drawing.Point(757, 252);
            this.button_anlegen.Name = "button_anlegen";
            this.button_anlegen.Size = new System.Drawing.Size(125, 30);
            this.button_anlegen.TabIndex = 37;
            this.button_anlegen.Text = "Anlegen";
            this.button_anlegen.UseVisualStyleBackColor = false;
            this.button_anlegen.Click += new System.EventHandler(this.button_anlegen_Click);
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
            this.button_eingabeZuruecksetzen.TabIndex = 36;
            this.button_eingabeZuruecksetzen.Text = "Zuruecksetzen";
            this.button_eingabeZuruecksetzen.UseVisualStyleBackColor = false;
            this.button_eingabeZuruecksetzen.Click += new System.EventHandler(this.button_eingabeZuruecksetzen_Click);
            // 
            // textBox_telNummer
            // 
            this.textBox_telNummer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_telNummer.Location = new System.Drawing.Point(526, 152);
            this.textBox_telNummer.Name = "textBox_telNummer";
            this.textBox_telNummer.Size = new System.Drawing.Size(183, 27);
            this.textBox_telNummer.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(457, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 34;
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
            this.button_bildHochladen.TabIndex = 33;
            this.button_bildHochladen.Text = "Bild hochladen";
            this.button_bildHochladen.UseVisualStyleBackColor = false;
            this.button_bildHochladen.Click += new System.EventHandler(this.button_bildHochladen_Click);
            // 
            // pictureBox_lehrerBild
            // 
            this.pictureBox_lehrerBild.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_lehrerBild.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox_lehrerBild.Image = global::ManagementSystem.Properties.Resources.female_student;
            this.pictureBox_lehrerBild.Location = new System.Drawing.Point(757, 62);
            this.pictureBox_lehrerBild.Name = "pictureBox_lehrerBild";
            this.pictureBox_lehrerBild.Size = new System.Drawing.Size(125, 112);
            this.pictureBox_lehrerBild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_lehrerBild.TabIndex = 32;
            this.pictureBox_lehrerBild.TabStop = false;
            // 
            // textBox_adresse
            // 
            this.textBox_adresse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_adresse.Location = new System.Drawing.Point(153, 149);
            this.textBox_adresse.Multiline = true;
            this.textBox_adresse.Name = "textBox_adresse";
            this.textBox_adresse.Size = new System.Drawing.Size(252, 66);
            this.textBox_adresse.TabIndex = 31;
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
            this.label1.TabIndex = 30;
            this.label1.Text = "Adresse:";
            // 
            // radioButton_weiblich
            // 
            this.radioButton_weiblich.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_weiblich.AutoSize = true;
            this.radioButton_weiblich.Checked = true;
            this.radioButton_weiblich.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_weiblich.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.radioButton_weiblich.Location = new System.Drawing.Point(630, 109);
            this.radioButton_weiblich.Name = "radioButton_weiblich";
            this.radioButton_weiblich.Size = new System.Drawing.Size(81, 23);
            this.radioButton_weiblich.TabIndex = 29;
            this.radioButton_weiblich.TabStop = true;
            this.radioButton_weiblich.Text = "weiblich";
            this.radioButton_weiblich.UseVisualStyleBackColor = true;
            // 
            // radioButton_maennlich
            // 
            this.radioButton_maennlich.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_maennlich.AutoSize = true;
            this.radioButton_maennlich.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_maennlich.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.radioButton_maennlich.Location = new System.Drawing.Point(530, 109);
            this.radioButton_maennlich.Name = "radioButton_maennlich";
            this.radioButton_maennlich.Size = new System.Drawing.Size(94, 23);
            this.radioButton_maennlich.TabIndex = 28;
            this.radioButton_maennlich.Text = "maennlich";
            this.radioButton_maennlich.UseVisualStyleBackColor = true;
            // 
            // label_geschlecht
            // 
            this.label_geschlecht.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_geschlecht.AutoSize = true;
            this.label_geschlecht.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_geschlecht.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_geschlecht.Location = new System.Drawing.Point(437, 111);
            this.label_geschlecht.Name = "label_geschlecht";
            this.label_geschlecht.Size = new System.Drawing.Size(87, 19);
            this.label_geschlecht.TabIndex = 27;
            this.label_geschlecht.Text = "Geschlecht:";
            // 
            // dateTimePicker_geburtsdatum
            // 
            this.dateTimePicker_geburtsdatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_geburtsdatum.Location = new System.Drawing.Point(153, 111);
            this.dateTimePicker_geburtsdatum.Name = "dateTimePicker_geburtsdatum";
            this.dateTimePicker_geburtsdatum.Size = new System.Drawing.Size(252, 27);
            this.dateTimePicker_geburtsdatum.TabIndex = 26;
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
            this.label_geburtsdatum.TabIndex = 25;
            this.label_geburtsdatum.Text = "Geburtsdatum:";
            // 
            // textBox_nachname
            // 
            this.textBox_nachname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_nachname.Location = new System.Drawing.Point(526, 67);
            this.textBox_nachname.Name = "textBox_nachname";
            this.textBox_nachname.Size = new System.Drawing.Size(183, 27);
            this.textBox_nachname.TabIndex = 24;
            // 
            // label_nachname
            // 
            this.label_nachname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_nachname.AutoSize = true;
            this.label_nachname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nachname.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_nachname.Location = new System.Drawing.Point(434, 70);
            this.label_nachname.Name = "label_nachname";
            this.label_nachname.Size = new System.Drawing.Size(86, 19);
            this.label_nachname.TabIndex = 23;
            this.label_nachname.Text = "Nachname:";
            // 
            // textBox_vorname
            // 
            this.textBox_vorname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_vorname.Location = new System.Drawing.Point(153, 67);
            this.textBox_vorname.Name = "textBox_vorname";
            this.textBox_vorname.Size = new System.Drawing.Size(183, 27);
            this.textBox_vorname.TabIndex = 22;
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
            this.label_vorname.TabIndex = 21;
            this.label_vorname.Text = "Vorname:";
            // 
            // DataGridView_lehrer
            // 
            this.DataGridView_lehrer.AllowUserToAddRows = false;
            this.DataGridView_lehrer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_lehrer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_lehrer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_lehrer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_lehrer.BackgroundColor = System.Drawing.Color.LightGray;
            this.DataGridView_lehrer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_lehrer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_lehrer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_lehrer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_lehrer.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_lehrer.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_lehrer.EnableHeadersVisualStyles = false;
            this.DataGridView_lehrer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_lehrer.Location = new System.Drawing.Point(12, 76);
            this.DataGridView_lehrer.Name = "DataGridView_lehrer";
            this.DataGridView_lehrer.RowHeadersVisible = false;
            this.DataGridView_lehrer.RowTemplate.Height = 80;
            this.DataGridView_lehrer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_lehrer.Size = new System.Drawing.Size(880, 245);
            this.DataGridView_lehrer.TabIndex = 22;
            this.DataGridView_lehrer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_lehrer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_lehrer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_lehrer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_lehrer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_lehrer.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.DataGridView_lehrer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_lehrer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_lehrer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_lehrer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_lehrer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_lehrer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_lehrer.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_lehrer.ThemeStyle.ReadOnly = false;
            this.DataGridView_lehrer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_lehrer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_lehrer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_lehrer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_lehrer.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_lehrer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_lehrer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // LehrerNeuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 611);
            this.Controls.Add(this.DataGridView_lehrer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LehrerNeuForm";
            this.Text = "LehrerNeuForm";
            this.Load += new System.EventHandler(this.LehrerNeuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lehrerBild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_lehrer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_anlegen;
        private System.Windows.Forms.Button button_eingabeZuruecksetzen;
        private System.Windows.Forms.TextBox textBox_telNummer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_bildHochladen;
        private System.Windows.Forms.PictureBox pictureBox_lehrerBild;
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
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_lehrer;
    }
}