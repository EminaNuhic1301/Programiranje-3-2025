namespace Studentska.WinApp.IB240167
{
    partial class frmPretragaBrojIndeksa
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
            lblGodina = new Label();
            lblStipendija = new Label();
            cmbGodina = new ComboBox();
            cmbStipendija = new ComboBox();
            btnStipendijaPoGodinama = new Button();
            btnDodaj = new Button();
            dgvPretraga = new DataGridView();
            ImePrezime = new DataGridViewTextBoxColumn();
            Godina = new DataGridViewTextBoxColumn();
            Stipendija = new DataGridViewTextBoxColumn();
            Iznos = new DataGridViewTextBoxColumn();
            Ukupno = new DataGridViewTextBoxColumn();
            btnUkloni = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).BeginInit();
            SuspendLayout();
            // 
            // lblGodina
            // 
            lblGodina.AutoSize = true;
            lblGodina.Location = new Point(12, 19);
            lblGodina.Name = "lblGodina";
            lblGodina.Size = new Size(60, 20);
            lblGodina.TabIndex = 0;
            lblGodina.Text = "Godina:";
            // 
            // lblStipendija
            // 
            lblStipendija.AutoSize = true;
            lblStipendija.Location = new Point(223, 19);
            lblStipendija.Name = "lblStipendija";
            lblStipendija.Size = new Size(79, 20);
            lblStipendija.TabIndex = 1;
            lblStipendija.Text = "Stipendija:";
            // 
            // cmbGodina
            // 
            cmbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGodina.FormattingEnabled = true;
            cmbGodina.Location = new Point(12, 42);
            cmbGodina.Name = "cmbGodina";
            cmbGodina.Size = new Size(203, 28);
            cmbGodina.TabIndex = 2;
            cmbGodina.SelectedIndexChanged += cmbGodina_SelectedIndexChanged;
            // 
            // cmbStipendija
            // 
            cmbStipendija.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStipendija.FormattingEnabled = true;
            cmbStipendija.Items.AddRange(new object[] { "Umjetnička", "Istraživačka", "Sportska", "Poduzetnička" });
            cmbStipendija.Location = new Point(223, 42);
            cmbStipendija.Name = "cmbStipendija";
            cmbStipendija.Size = new Size(209, 28);
            cmbStipendija.TabIndex = 3;
            cmbStipendija.SelectedIndexChanged += cmbStipendija_SelectedIndexChanged;
            // 
            // btnStipendijaPoGodinama
            // 
            btnStipendijaPoGodinama.Location = new Point(724, 42);
            btnStipendijaPoGodinama.Name = "btnStipendijaPoGodinama";
            btnStipendijaPoGodinama.Size = new Size(182, 29);
            btnStipendijaPoGodinama.TabIndex = 4;
            btnStipendijaPoGodinama.Text = "Stipendija po godinama";
            btnStipendijaPoGodinama.UseVisualStyleBackColor = true;
            btnStipendijaPoGodinama.Click += btnStipendijaPoGodinama_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(570, 41);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(148, 29);
            btnDodaj.TabIndex = 5;
            btnDodaj.Text = "Dodaj stipendiju";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvPretraga
            // 
            dgvPretraga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPretraga.Columns.AddRange(new DataGridViewColumn[] { ImePrezime, Godina, Stipendija, Iznos, Ukupno, btnUkloni });
            dgvPretraga.Location = new Point(12, 76);
            dgvPretraga.Name = "dgvPretraga";
            dgvPretraga.RowHeadersWidth = 51;
            dgvPretraga.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPretraga.Size = new Size(894, 364);
            dgvPretraga.TabIndex = 6;
            dgvPretraga.CellContentClick += dgvPretraga_CellContentClick;
            dgvPretraga.CellDoubleClick += dgvPretraga_CellDoubleClick;
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePrezime.DataPropertyName = "ImePrezime";
            ImePrezime.HeaderText = "(Indeks) Ime i prezime";
            ImePrezime.MinimumWidth = 6;
            ImePrezime.Name = "ImePrezime";
            // 
            // Godina
            // 
            Godina.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Godina.DataPropertyName = "Godina";
            Godina.HeaderText = "Godina";
            Godina.MinimumWidth = 6;
            Godina.Name = "Godina";
            // 
            // Stipendija
            // 
            Stipendija.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Stipendija.DataPropertyName = "Stipendija";
            Stipendija.HeaderText = "Stipendija";
            Stipendija.MinimumWidth = 6;
            Stipendija.Name = "Stipendija";
            // 
            // Iznos
            // 
            Iznos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Iznos.DataPropertyName = "Iznos";
            Iznos.HeaderText = "Mjesecni iznos";
            Iznos.MinimumWidth = 6;
            Iznos.Name = "Iznos";
            // 
            // Ukupno
            // 
            Ukupno.DataPropertyName = "Ukupno";
            Ukupno.HeaderText = "Ukupno";
            Ukupno.MinimumWidth = 6;
            Ukupno.Name = "Ukupno";
            Ukupno.Width = 125;
            // 
            // btnUkloni
            // 
            btnUkloni.DataPropertyName = "btnUkloni";
            btnUkloni.HeaderText = "";
            btnUkloni.MinimumWidth = 6;
            btnUkloni.Name = "btnUkloni";
            btnUkloni.Text = "Ukloni";
            btnUkloni.UseColumnTextForButtonValue = true;
            btnUkloni.Width = 125;
            // 
            // frmPretragaBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 457);
            Controls.Add(dgvPretraga);
            Controls.Add(btnDodaj);
            Controls.Add(btnStipendijaPoGodinama);
            Controls.Add(cmbStipendija);
            Controls.Add(cmbGodina);
            Controls.Add(lblStipendija);
            Controls.Add(lblGodina);
            Name = "frmPretragaBrojIndeksa";
            Text = "frmPretragaBrojIndeksa";
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGodina;
        private Label lblStipendija;
        private ComboBox cmbGodina;
        private ComboBox cmbStipendija;
        private Button btnStipendijaPoGodinama;
        private Button btnDodaj;
        private DataGridView dgvPretraga;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn Godina;
        private DataGridViewTextBoxColumn Stipendija;
        private DataGridViewTextBoxColumn Iznos;
        private DataGridViewTextBoxColumn Ukupno;
        private DataGridViewButtonColumn btnUkloni;
    }
}