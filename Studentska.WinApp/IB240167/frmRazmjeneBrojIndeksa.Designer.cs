namespace Studentska.WinApp.IB240167
{
    partial class frmRazmjeneBrojIndeksa
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
            components = new System.ComponentModel.Container();
            blDrzava = new Label();
            lblUniverzitet = new Label();
            lblBrojKredita = new Label();
            lblBrojRazm = new Label();
            lblECTS = new Label();
            lblInfo = new Label();
            lblPocetak = new Label();
            cmbDrzava = new ComboBox();
            cmbUniverzitet = new ComboBox();
            txtECTS = new TextBox();
            txtInfo = new TextBox();
            txtBrojKredita = new TextBox();
            cmbFaks = new ComboBox();
            btnSacuvaj = new Button();
            btnPotvrda = new Button();
            btnGenerisi = new Button();
            dgvRazmjene = new DataGridView();
            Univerzitet = new DataGridViewTextBoxColumn();
            PocetakRazmjene = new DataGridViewTextBoxColumn();
            KrajRazmjene = new DataGridViewTextBoxColumn();
            ECTS = new DataGridViewTextBoxColumn();
            Okoncana = new DataGridViewCheckBoxColumn();
            btnObrisi = new DataGridViewButtonColumn();
            txtBrojRazm = new TextBox();
            lblFaks = new Label();
            gbGenerator = new GroupBox();
            dtpPocetak = new DateTimePicker();
            dtpKraj = new DateTimePicker();
            lblKraj = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvRazmjene).BeginInit();
            gbGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // blDrzava
            // 
            blDrzava.AutoSize = true;
            blDrzava.Location = new Point(12, 20);
            blDrzava.Name = "blDrzava";
            blDrzava.Size = new Size(58, 20);
            blDrzava.TabIndex = 0;
            blDrzava.Text = "Drzava:";
            // 
            // lblUniverzitet
            // 
            lblUniverzitet.AutoSize = true;
            lblUniverzitet.Location = new Point(241, 20);
            lblUniverzitet.Name = "lblUniverzitet";
            lblUniverzitet.Size = new Size(83, 20);
            lblUniverzitet.TabIndex = 1;
            lblUniverzitet.Text = "Univerzitet:";
            // 
            // lblBrojKredita
            // 
            lblBrojKredita.AutoSize = true;
            lblBrojKredita.Location = new Point(121, 121);
            lblBrojKredita.Name = "lblBrojKredita";
            lblBrojKredita.Size = new Size(89, 20);
            lblBrojKredita.TabIndex = 2;
            lblBrojKredita.Text = "Broj kredita:";
            // 
            // lblBrojRazm
            // 
            lblBrojRazm.AutoSize = true;
            lblBrojRazm.Location = new Point(6, 121);
            lblBrojRazm.Name = "lblBrojRazm";
            lblBrojRazm.Size = new Size(104, 20);
            lblBrojRazm.TabIndex = 3;
            lblBrojRazm.Text = "Broj razmjena:";
            // 
            // lblECTS
            // 
            lblECTS.AutoSize = true;
            lblECTS.Location = new Point(468, 20);
            lblECTS.Name = "lblECTS";
            lblECTS.Size = new Size(89, 20);
            lblECTS.TabIndex = 4;
            lblECTS.Text = "Broj kredita:";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(268, 23);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(38, 20);
            lblInfo.TabIndex = 5;
            lblInfo.Text = "Info:";
            // 
            // lblPocetak
            // 
            lblPocetak.AutoSize = true;
            lblPocetak.Location = new Point(575, 20);
            lblPocetak.Name = "lblPocetak";
            lblPocetak.Size = new Size(128, 20);
            lblPocetak.TabIndex = 6;
            lblPocetak.Text = "Pocetak razmjene:";
            // 
            // cmbDrzava
            // 
            cmbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrzava.FormattingEnabled = true;
            cmbDrzava.Location = new Point(12, 43);
            cmbDrzava.Name = "cmbDrzava";
            cmbDrzava.Size = new Size(223, 28);
            cmbDrzava.TabIndex = 7;
            cmbDrzava.SelectedIndexChanged += cmbDrzava_SelectedIndexChanged;
            // 
            // cmbUniverzitet
            // 
            cmbUniverzitet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUniverzitet.FormattingEnabled = true;
            cmbUniverzitet.Location = new Point(241, 44);
            cmbUniverzitet.Name = "cmbUniverzitet";
            cmbUniverzitet.Size = new Size(221, 28);
            cmbUniverzitet.TabIndex = 8;
            // 
            // txtECTS
            // 
            txtECTS.Location = new Point(468, 45);
            txtECTS.Name = "txtECTS";
            txtECTS.Size = new Size(101, 27);
            txtECTS.TabIndex = 9;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(269, 46);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(832, 267);
            txtInfo.TabIndex = 10;
            // 
            // txtBrojKredita
            // 
            txtBrojKredita.Location = new Point(121, 144);
            txtBrojKredita.Name = "txtBrojKredita";
            txtBrojKredita.Size = new Size(116, 27);
            txtBrojKredita.TabIndex = 11;
            // 
            // cmbFaks
            // 
            cmbFaks.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFaks.FormattingEnabled = true;
            cmbFaks.Location = new Point(11, 72);
            cmbFaks.Name = "cmbFaks";
            cmbFaks.Size = new Size(225, 28);
            cmbFaks.TabIndex = 12;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(1030, 42);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(107, 29);
            btnSacuvaj.TabIndex = 13;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnPotvrda
            // 
            btnPotvrda.Location = new Point(962, 379);
            btnPotvrda.Name = "btnPotvrda";
            btnPotvrda.Size = new Size(175, 29);
            btnPotvrda.TabIndex = 14;
            btnPotvrda.Text = "Potvrda";
            btnPotvrda.UseVisualStyleBackColor = true;
            btnPotvrda.Click += btnPotvrda_Click;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(11, 190);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(225, 29);
            btnGenerisi.TabIndex = 15;
            btnGenerisi.Text = "Generisi razmjene>>>";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // dgvRazmjene
            // 
            dgvRazmjene.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRazmjene.Columns.AddRange(new DataGridViewColumn[] { Univerzitet, PocetakRazmjene, KrajRazmjene, ECTS, Okoncana, btnObrisi });
            dgvRazmjene.Location = new Point(12, 77);
            dgvRazmjene.Name = "dgvRazmjene";
            dgvRazmjene.RowHeadersWidth = 51;
            dgvRazmjene.Size = new Size(1125, 296);
            dgvRazmjene.TabIndex = 16;
            dgvRazmjene.CellContentClick += dgvRazmjene_CellContentClick;
            // 
            // Univerzitet
            // 
            Univerzitet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Univerzitet.DataPropertyName = "Univerzitet";
            Univerzitet.HeaderText = "Univerzitet";
            Univerzitet.MinimumWidth = 6;
            Univerzitet.Name = "Univerzitet";
            // 
            // PocetakRazmjene
            // 
            PocetakRazmjene.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PocetakRazmjene.DataPropertyName = "PocetakRazmjene";
            PocetakRazmjene.HeaderText = "Pocetak";
            PocetakRazmjene.MinimumWidth = 6;
            PocetakRazmjene.Name = "PocetakRazmjene";
            // 
            // KrajRazmjene
            // 
            KrajRazmjene.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            KrajRazmjene.DataPropertyName = "KrajRazmjene";
            KrajRazmjene.HeaderText = "Kraj";
            KrajRazmjene.MinimumWidth = 6;
            KrajRazmjene.Name = "KrajRazmjene";
            // 
            // ECTS
            // 
            ECTS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ECTS.DataPropertyName = "ECTS";
            ECTS.HeaderText = "ECTS";
            ECTS.MinimumWidth = 6;
            ECTS.Name = "ECTS";
            // 
            // Okoncana
            // 
            Okoncana.DataPropertyName = "Okoncana";
            Okoncana.HeaderText = "Okoncana";
            Okoncana.MinimumWidth = 6;
            Okoncana.Name = "Okoncana";
            Okoncana.Width = 125;
            // 
            // btnObrisi
            // 
            btnObrisi.DataPropertyName = "btnObrisi";
            btnObrisi.HeaderText = "";
            btnObrisi.MinimumWidth = 6;
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Width = 125;
            // 
            // txtBrojRazm
            // 
            txtBrojRazm.Location = new Point(11, 144);
            txtBrojRazm.Name = "txtBrojRazm";
            txtBrojRazm.Size = new Size(104, 27);
            txtBrojRazm.TabIndex = 17;
            // 
            // lblFaks
            // 
            lblFaks.AutoSize = true;
            lblFaks.Location = new Point(11, 46);
            lblFaks.Name = "lblFaks";
            lblFaks.Size = new Size(83, 20);
            lblFaks.TabIndex = 18;
            lblFaks.Text = "Univerzitet:";
            // 
            // gbGenerator
            // 
            gbGenerator.Controls.Add(txtInfo);
            gbGenerator.Controls.Add(txtBrojRazm);
            gbGenerator.Controls.Add(btnGenerisi);
            gbGenerator.Controls.Add(lblFaks);
            gbGenerator.Controls.Add(lblInfo);
            gbGenerator.Controls.Add(cmbFaks);
            gbGenerator.Controls.Add(txtBrojKredita);
            gbGenerator.Controls.Add(lblBrojRazm);
            gbGenerator.Controls.Add(lblBrojKredita);
            gbGenerator.Location = new Point(12, 414);
            gbGenerator.Name = "gbGenerator";
            gbGenerator.Size = new Size(1125, 331);
            gbGenerator.TabIndex = 19;
            gbGenerator.TabStop = false;
            gbGenerator.Text = "Generator razmjena";
            // 
            // dtpPocetak
            // 
            dtpPocetak.Location = new Point(575, 45);
            dtpPocetak.Name = "dtpPocetak";
            dtpPocetak.Size = new Size(213, 27);
            dtpPocetak.TabIndex = 20;
            // 
            // dtpKraj
            // 
            dtpKraj.Location = new Point(794, 45);
            dtpKraj.Name = "dtpKraj";
            dtpKraj.Size = new Size(230, 27);
            dtpKraj.TabIndex = 21;
            // 
            // lblKraj
            // 
            lblKraj.AutoSize = true;
            lblKraj.Location = new Point(795, 20);
            lblKraj.Name = "lblKraj";
            lblKraj.Size = new Size(103, 20);
            lblKraj.TabIndex = 22;
            lblKraj.Text = "Kraj razmjene:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmRazmjeneBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 757);
            Controls.Add(lblKraj);
            Controls.Add(dtpKraj);
            Controls.Add(dtpPocetak);
            Controls.Add(gbGenerator);
            Controls.Add(dgvRazmjene);
            Controls.Add(btnPotvrda);
            Controls.Add(btnSacuvaj);
            Controls.Add(txtECTS);
            Controls.Add(cmbUniverzitet);
            Controls.Add(cmbDrzava);
            Controls.Add(lblPocetak);
            Controls.Add(lblECTS);
            Controls.Add(lblUniverzitet);
            Controls.Add(blDrzava);
            Name = "frmRazmjeneBrojIndeksa";
            Text = "frmRazmjeneBrojIndeksa";
            ((System.ComponentModel.ISupportInitialize)dgvRazmjene).EndInit();
            gbGenerator.ResumeLayout(false);
            gbGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label blDrzava;
        private Label lblUniverzitet;
        private Label lblBrojKredita;
        private Label lblBrojRazm;
        private Label lblECTS;
        private Label lblInfo;
        private Label lblPocetak;
        private ComboBox cmbDrzava;
        private ComboBox cmbUniverzitet;
        private TextBox txtECTS;
        private TextBox txtInfo;
        private TextBox txtBrojKredita;
        private ComboBox cmbFaks;
        private Button btnSacuvaj;
        private Button btnPotvrda;
        private Button btnGenerisi;
        private DataGridView dgvRazmjene;
        private TextBox txtBrojRazm;
        private Label lblFaks;
        private GroupBox gbGenerator;
        private DateTimePicker dtpPocetak;
        private DateTimePicker dtpKraj;
        private Label lblKraj;
        private DataGridViewTextBoxColumn Univerzitet;
        private DataGridViewTextBoxColumn PocetakRazmjene;
        private DataGridViewTextBoxColumn KrajRazmjene;
        private DataGridViewTextBoxColumn ECTS;
        private DataGridViewCheckBoxColumn Okoncana;
        private DataGridViewButtonColumn btnObrisi;
        private ErrorProvider errorProvider1;
    }
}