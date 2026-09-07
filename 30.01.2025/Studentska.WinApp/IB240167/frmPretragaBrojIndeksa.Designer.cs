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
            lblPretraga = new Label();
            lblDrzava = new Label();
            lblSpol = new Label();
            txtPretraga = new TextBox();
            cmbDrzava = new ComboBox();
            cmbSpol = new ComboBox();
            dgvPretrage = new DataGridView();
            ImePrezime = new DataGridViewTextBoxColumn();
            Drzava = new DataGridViewTextBoxColumn();
            Spol = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            btnRazmjene = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPretrage).BeginInit();
            SuspendLayout();
            // 
            // lblPretraga
            // 
            lblPretraga.AutoSize = true;
            lblPretraga.Location = new Point(12, 21);
            lblPretraga.Name = "lblPretraga";
            lblPretraga.Size = new Size(111, 20);
            lblPretraga.TabIndex = 0;
            lblPretraga.Text = "Ime ili prezime:";
            // 
            // lblDrzava
            // 
            lblDrzava.AutoSize = true;
            lblDrzava.Location = new Point(318, 21);
            lblDrzava.Name = "lblDrzava";
            lblDrzava.Size = new Size(58, 20);
            lblDrzava.TabIndex = 1;
            lblDrzava.Text = "Drzava:";
            // 
            // lblSpol
            // 
            lblSpol.AutoSize = true;
            lblSpol.Location = new Point(528, 21);
            lblSpol.Name = "lblSpol";
            lblSpol.Size = new Size(42, 20);
            lblSpol.TabIndex = 2;
            lblSpol.Text = "Spol:";
            // 
            // txtPretraga
            // 
            txtPretraga.Location = new Point(12, 44);
            txtPretraga.Name = "txtPretraga";
            txtPretraga.Size = new Size(302, 27);
            txtPretraga.TabIndex = 3;
            txtPretraga.TextChanged += txtPretraga_TextChanged;
            // 
            // cmbDrzava
            // 
            cmbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrzava.FormattingEnabled = true;
            cmbDrzava.Location = new Point(320, 44);
            cmbDrzava.Name = "cmbDrzava";
            cmbDrzava.Size = new Size(202, 28);
            cmbDrzava.TabIndex = 4;
            cmbDrzava.SelectedIndexChanged += cmbDrzava_SelectedIndexChanged;
            // 
            // cmbSpol
            // 
            cmbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpol.FormattingEnabled = true;
            cmbSpol.Location = new Point(528, 44);
            cmbSpol.Name = "cmbSpol";
            cmbSpol.Size = new Size(182, 28);
            cmbSpol.TabIndex = 5;
            cmbSpol.SelectedIndexChanged += cmbSpol_SelectedIndexChanged;
            // 
            // dgvPretrage
            // 
            dgvPretrage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPretrage.Columns.AddRange(new DataGridViewColumn[] { ImePrezime, Drzava, Spol, Aktivan, btnRazmjene });
            dgvPretrage.Location = new Point(12, 77);
            dgvPretrage.Name = "dgvPretrage";
            dgvPretrage.RowHeadersWidth = 51;
            dgvPretrage.Size = new Size(828, 383);
            dgvPretrage.TabIndex = 6;
            dgvPretrage.CellContentClick += dgvPretrage_CellContentClick;
            dgvPretrage.CellDoubleClick += dgvPretrage_CellDoubleClick;
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePrezime.DataPropertyName = "ImePrezime";
            ImePrezime.HeaderText = "(Indeks) Ime i prezime";
            ImePrezime.MinimumWidth = 6;
            ImePrezime.Name = "ImePrezime";
            // 
            // Drzava
            // 
            Drzava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Drzava.DataPropertyName = "Drzava";
            Drzava.HeaderText = "Drzava";
            Drzava.MinimumWidth = 6;
            Drzava.Name = "Drzava";
            // 
            // Spol
            // 
            Spol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Spol.DataPropertyName = "Spol";
            Spol.HeaderText = "Spol";
            Spol.MinimumWidth = 6;
            Spol.Name = "Spol";
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.Width = 125;
            // 
            // btnRazmjene
            // 
            btnRazmjene.DataPropertyName = "btnRazmjene";
            btnRazmjene.HeaderText = "";
            btnRazmjene.MinimumWidth = 6;
            btnRazmjene.Name = "btnRazmjene";
            btnRazmjene.Text = "Razmjene";
            btnRazmjene.UseColumnTextForButtonValue = true;
            btnRazmjene.Width = 125;
            // 
            // frmPretragaBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 472);
            Controls.Add(dgvPretrage);
            Controls.Add(cmbSpol);
            Controls.Add(cmbDrzava);
            Controls.Add(txtPretraga);
            Controls.Add(lblSpol);
            Controls.Add(lblDrzava);
            Controls.Add(lblPretraga);
            Name = "frmPretragaBrojIndeksa";
            Text = "frmPretragaBrojIndeksa";
            ((System.ComponentModel.ISupportInitialize)dgvPretrage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPretraga;
        private Label lblDrzava;
        private Label lblSpol;
        private TextBox txtPretraga;
        private ComboBox cmbDrzava;
        private ComboBox cmbSpol;
        private DataGridView dgvPretrage;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn Drzava;
        private DataGridViewTextBoxColumn Spol;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn btnRazmjene;
    }
}