namespace ManagementSystem.Forms
{
    partial class FachNeuForm
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
            this.textBox_lehrerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_fachAnlegen = new System.Windows.Forms.Button();
            this.button_eingabeZuruecksetzen = new System.Windows.Forms.Button();
            this.textBox_beschreibung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_stufe = new System.Windows.Forms.TextBox();
            this.label_nachname = new System.Windows.Forms.Label();
            this.textBox_bezeichnung = new System.Windows.Forms.TextBox();
            this.label_vorname = new System.Windows.Forms.Label();
            this.DataGridView_faecher = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_faecher)).BeginInit();
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
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Neues Fach";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_lehrerID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button_fachAnlegen);
            this.panel2.Controls.Add(this.button_eingabeZuruecksetzen);
            this.panel2.Controls.Add(this.textBox_beschreibung);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox_stufe);
            this.panel2.Controls.Add(this.label_nachname);
            this.panel2.Controls.Add(this.textBox_bezeichnung);
            this.panel2.Controls.Add(this.label_vorname);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 291);
            this.panel2.TabIndex = 21;
            // 
            // textBox_lehrerID
            // 
            this.textBox_lehrerID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_lehrerID.Location = new System.Drawing.Point(255, 126);
            this.textBox_lehrerID.Name = "textBox_lehrerID";
            this.textBox_lehrerID.Size = new System.Drawing.Size(183, 27);
            this.textBox_lehrerID.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(251, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Lehrer:";
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
            // button_fachAnlegen
            // 
            this.button_fachAnlegen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_fachAnlegen.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_fachAnlegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fachAnlegen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_fachAnlegen.ForeColor = System.Drawing.Color.White;
            this.button_fachAnlegen.Location = new System.Drawing.Point(757, 252);
            this.button_fachAnlegen.Name = "button_fachAnlegen";
            this.button_fachAnlegen.Size = new System.Drawing.Size(125, 30);
            this.button_fachAnlegen.TabIndex = 37;
            this.button_fachAnlegen.Text = "Anlegen";
            this.button_fachAnlegen.UseVisualStyleBackColor = false;
            this.button_fachAnlegen.Click += new System.EventHandler(this.button_fachAnlegen_Click);
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
            // textBox_beschreibung
            // 
            this.textBox_beschreibung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_beschreibung.Location = new System.Drawing.Point(16, 200);
            this.textBox_beschreibung.Multiline = true;
            this.textBox_beschreibung.Name = "textBox_beschreibung";
            this.textBox_beschreibung.Size = new System.Drawing.Size(422, 79);
            this.textBox_beschreibung.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(12, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Beschreibung:";
            // 
            // textBox_stufe
            // 
            this.textBox_stufe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_stufe.Location = new System.Drawing.Point(16, 126);
            this.textBox_stufe.Name = "textBox_stufe";
            this.textBox_stufe.Size = new System.Drawing.Size(183, 27);
            this.textBox_stufe.TabIndex = 24;
            // 
            // label_nachname
            // 
            this.label_nachname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_nachname.AutoSize = true;
            this.label_nachname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nachname.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_nachname.Location = new System.Drawing.Point(12, 104);
            this.label_nachname.Name = "label_nachname";
            this.label_nachname.Size = new System.Drawing.Size(49, 19);
            this.label_nachname.TabIndex = 23;
            this.label_nachname.Text = "Stufe:";
            // 
            // textBox_bezeichnung
            // 
            this.textBox_bezeichnung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_bezeichnung.Location = new System.Drawing.Point(16, 62);
            this.textBox_bezeichnung.Name = "textBox_bezeichnung";
            this.textBox_bezeichnung.Size = new System.Drawing.Size(183, 27);
            this.textBox_bezeichnung.TabIndex = 22;
            // 
            // label_vorname
            // 
            this.label_vorname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_vorname.AutoSize = true;
            this.label_vorname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vorname.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_vorname.Location = new System.Drawing.Point(12, 40);
            this.label_vorname.Name = "label_vorname";
            this.label_vorname.Size = new System.Drawing.Size(99, 19);
            this.label_vorname.TabIndex = 21;
            this.label_vorname.Text = "Bezeichnung:";
            // 
            // DataGridView_faecher
            // 
            this.DataGridView_faecher.AllowUserToAddRows = false;
            this.DataGridView_faecher.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_faecher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_faecher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_faecher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_faecher.BackgroundColor = System.Drawing.Color.LightGray;
            this.DataGridView_faecher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_faecher.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_faecher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_faecher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_faecher.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_faecher.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_faecher.EnableHeadersVisualStyles = false;
            this.DataGridView_faecher.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_faecher.Location = new System.Drawing.Point(12, 76);
            this.DataGridView_faecher.Name = "DataGridView_faecher";
            this.DataGridView_faecher.RowHeadersVisible = false;
            this.DataGridView_faecher.RowTemplate.Height = 80;
            this.DataGridView_faecher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_faecher.Size = new System.Drawing.Size(880, 245);
            this.DataGridView_faecher.TabIndex = 22;
            this.DataGridView_faecher.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_faecher.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_faecher.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_faecher.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_faecher.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_faecher.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.DataGridView_faecher.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_faecher.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_faecher.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_faecher.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_faecher.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_faecher.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_faecher.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_faecher.ThemeStyle.ReadOnly = false;
            this.DataGridView_faecher.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_faecher.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_faecher.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_faecher.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_faecher.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_faecher.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_faecher.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // FachNeuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 611);
            this.Controls.Add(this.DataGridView_faecher);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FachNeuForm";
            this.Text = "FachNeuForm";
            this.Load += new System.EventHandler(this.FachNeuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_faecher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_fachAnlegen;
        private System.Windows.Forms.Button button_eingabeZuruecksetzen;
        private System.Windows.Forms.TextBox textBox_beschreibung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_stufe;
        private System.Windows.Forms.Label label_nachname;
        private System.Windows.Forms.TextBox textBox_bezeichnung;
        private System.Windows.Forms.Label label_vorname;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_faecher;
        private System.Windows.Forms.TextBox textBox_lehrerID;
        private System.Windows.Forms.Label label2;
    }
}