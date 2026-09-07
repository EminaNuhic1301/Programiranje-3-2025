using Studentska.Data.Modeli.IB240167;
using Studentska.Servis.Servisi.IB240167;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentska.WinApp.IB240167
{
    public partial class frmPretragaBrojIndeksa : Form
    {
        public frmPretragaBrojIndeksa()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
            UcitajCMB();
            UcitajPodatke();
        }

        private void UcitajCMB()
        {
            var stipendijaGodinaServis = new StipendijeGodineBrojIndeksaServis();
            var sveStipendijaGodine = stipendijaGodinaServis.GetAll();

            cmbGodina.DataSource = sveStipendijaGodine.Select(x => x.Godina).ToList();
        }

        private void UcitajPodatke()
        {
            var studentiStipendijeServis = new StudentiStipendijeBrojIndeksaServis();
            var sviStudentiStipendije = studentiStipendijeServis.GetAll();

            var stipendija = cmbStipendija.SelectedItem as StipendijeBrojIndeksa;
            var godina = cmbGodina.SelectedItem;

            var podaci = sviStudentiStipendije.Where(x => x.StipendijaGodina.StipendijaID == stipendija.ID).ToList();

            if (podaci.Count() != 0)
            {
                dgvPretraga.DataSource = null;
                dgvPretraga.DataSource = podaci;
                this.Text = $"Broj prikazanih studenata: {podaci.Count()}";
            }
            else
            {
                dgvPretraga.DataSource = null;
                MessageBox.Show($"U bazi nisu evidentirani studenti kojima je u {godina} godini dodijeljena {stipendija.Naziv}.");
            }

        }

        private void cmbStipendija_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var nova = new frmStipendijaAddEditBrojIndeksa();
            nova.ShowDialog();
            UcitajPodatke();
        }

        private void btnStipendijaPoGodinama_Click(object sender, EventArgs e)
        {
            var nova = new frmStipendijeBrojIndeksa();
            nova.ShowDialog();
            UcitajPodatke();
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            var studentStipendijaServis = new StudentiStipendijeBrojIndeksaServis();
            var sviStudentiStipendije = studentStipendijaServis.GetAll();

            var red = (StudentiStipendijeBrojIndeksa)dgvPretraga.Rows[e.RowIndex].DataBoundItem;

            if (red != null)
            {
                if (e.ColumnIndex == btnUkloni.Index)
                {
                    var poruka = MessageBox.Show("Da li zelite obrisati?", "Upit",
                        MessageBoxButtons.OKCancel);
                    if (poruka == DialogResult.OK)
                    {
                        var praviPodaci = studentStipendijaServis.GetById(red.ID);
                        if (praviPodaci != null)
                        {
                            studentStipendijaServis.Remove(praviPodaci);
                            studentStipendijaServis.SaveChanges();

                            UcitajPodatke();
                        }
                    }
                }
            }
        
        }

        private void dgvPretraga_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            var studentStipendijaServis = new StudentiStipendijeBrojIndeksaServis();
            var sviStudentiStipendije = studentStipendijaServis.GetAll();

            var red = (StudentiStipendijeBrojIndeksa)dgvPretraga.Rows[e.RowIndex].DataBoundItem;

            if (red != null)
            {
                var nova = new frmStipendijaAddEditBrojIndeksa();
                nova.ShowDialog();
                UcitajPodatke();
            }
        }

        private void cmbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stipendijaGodinaServis = new StipendijeGodineBrojIndeksaServis();
            var sveStipendijaGodine = stipendijaGodinaServis.GetAll();

            var godina = (int)cmbGodina.SelectedItem;
            if (godina != null)
            {
                cmbStipendija.DataSource = sveStipendijaGodine.Where(x => x.Godina == godina).Select(x => x.Stipendija).ToList();
                //var stipendijaServis = new StipendijeBrojIndeksaServis();
                //var sveStipendije = stipendijaServis.GetAll();

                //cmbStipendija.DataSource = sveStipendije;
                //cmbStipendija.DisplayMember = "Naziv";
                //cmbStipendija.ValueMember = "ID";
                UcitajPodatke();
            }
        }
    }
}
