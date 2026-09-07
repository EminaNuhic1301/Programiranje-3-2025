namespace Studentska.WinApp.IB240167
{
    partial class frmStudentEditBrojIndeksa
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
            lblDrzava = new Label();
            lblGrad = new Label();
            lblImePrezime = new Label();
            lblBrojIndeksa = new Label();
            btnUcitaj = new Button();
            btnSacuvaj = new Button();
            pbSlika = new PictureBox();
            cmbDrzava = new ComboBox();
            cmbGrad = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblDrzava
            // 
            lblDrzava.AutoSize = true;
            lblDrzava.Location = new Point(222, 151);
            lblDrzava.Name = "lblDrzava";
            lblDrzava.Size = new Size(58, 20);
            lblDrzava.TabIndex = 0;
            lblDrzava.Text = "Drzava:";
            // 
            // lblGrad
            // 
            lblGrad.AutoSize = true;
            lblGrad.Location = new Point(228, 206);
            lblGrad.Name = "lblGrad";
            lblGrad.Size = new Size(44, 20);
            lblGrad.TabIndex = 1;
            lblGrad.Text = "Grad:";
            // 
            // lblImePrezime
            // 
            lblImePrezime.AutoSize = true;
            lblImePrezime.Font = new Font("Segoe UI", 12F);
            lblImePrezime.Location = new Point(278, 29);
            lblImePrezime.Name = "lblImePrezime";
            lblImePrezime.Size = new Size(118, 28);
            lblImePrezime.TabIndex = 2;
            lblImePrezime.Text = "Dzana Sabic";
            // 
            // lblBrojIndeksa
            // 
            lblBrojIndeksa.AutoSize = true;
            lblBrojIndeksa.Font = new Font("Segoe UI", 12F);
            lblBrojIndeksa.Location = new Point(278, 79);
            lblBrojIndeksa.Name = "lblBrojIndeksa";
            lblBrojIndeksa.Size = new Size(116, 28);
            lblBrojIndeksa.TabIndex = 3;
            lblBrojIndeksa.Text = "IB24000012";
            // 
            // btnUcitaj
            // 
            btnUcitaj.Location = new Point(12, 283);
            btnUcitaj.Name = "btnUcitaj";
            btnUcitaj.Size = new Size(191, 29);
            btnUcitaj.TabIndex = 4;
            btnUcitaj.Text = "Ucitaj sliku";
            btnUcitaj.UseVisualStyleBackColor = true;
            btnUcitaj.Click += btnUcitaj_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(341, 283);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(155, 29);
            btnSacuvaj.TabIndex = 5;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(12, 29);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(191, 248);
            pbSlika.TabIndex = 6;
            pbSlika.TabStop = false;
            // 
            // cmbDrzava
            // 
            cmbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrzava.FormattingEnabled = true;
            cmbDrzava.Location = new Point(278, 148);
            cmbDrzava.Name = "cmbDrzava";
            cmbDrzava.Size = new Size(218, 28);
            cmbDrzava.TabIndex = 7;
            cmbDrzava.SelectedIndexChanged += cmbDrzava_SelectedIndexChanged;
            // 
            // cmbGrad
            // 
            cmbGrad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrad.FormattingEnabled = true;
            cmbGrad.Location = new Point(278, 206);
            cmbGrad.Name = "cmbGrad";
            cmbGrad.Size = new Size(218, 28);
            cmbGrad.TabIndex = 8;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmStudentEditBrojIndeksa
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(537, 340);
            Controls.Add(cmbGrad);
            Controls.Add(cmbDrzava);
            Controls.Add(pbSlika);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnUcitaj);
            Controls.Add(lblBrojIndeksa);
            Controls.Add(lblImePrezime);
            Controls.Add(lblGrad);
            Controls.Add(lblDrzava);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "frmStudentEditBrojIndeksa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Podaci o studentu";
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDrzava;
        private Label lblGrad;
        private Label lblImePrezime;
        private Label lblBrojIndeksa;
        private Button btnUcitaj;
        private Button btnSacuvaj;
        private PictureBox pbSlika;
        private ComboBox cmbDrzava;
        private ComboBox cmbGrad;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}