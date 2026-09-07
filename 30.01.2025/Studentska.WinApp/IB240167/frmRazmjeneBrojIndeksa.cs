using DocumentFormat.OpenXml.Bibliography;
using Studentska.Data.Entiteti;
using Studentska.Data.Modeli.IB240167;
using Studentska.Servis.Servisi;
using Studentska.Servis.Servisi.IB240167;
using Studentska.WinApp.Izvjestaji;
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
    public partial class frmRazmjeneBrojIndeksa : Form
    {
        private Student odabraniStudent;
        public frmRazmjeneBrojIndeksa(Student? odabraniStudent)
        {
            InitializeComponent();
            this.odabraniStudent = odabraniStudent;
            dgvRazmjene.AutoGenerateColumns = false;
            UcitajPodatke();
            UcitajCMB();
        }

        private void UcitajCMB()
        {
            var drzavaServis = new DrzavaServis();
            var sveDrzave = drzavaServis.GetAll();
            cmbDrzava.DataSource = sveDrzave.ToList();

            var faksServis = new UniverzitetiBrojIndeksaServis();
            var sviFakulteti = faksServis.GetAll();
            cmbFaks.DataSource = sviFakulteti.ToList();
        }

        private void UcitajPodatke()
        {
            var razmjenaServis = new RazmjeneBrojIndeksaServis();
            var sveRazmjene = razmjenaServis.GetAll();

            var podaci = sveRazmjene.Where(x => x.StudentID == odabraniStudent.Id).ToList();
            if (podaci.Count != 0)
            {
                dgvRazmjene.DataSource = null;
                dgvRazmjene.DataSource = podaci;
                this.Text = $"Razmjena studenta {odabraniStudent.ImePrezime}";
            }
            else
            {
                dgvRazmjene.DataSource = null;
            }

        
        
        }

        
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var razmjenaServis = new RazmjeneBrojIndeksaServis();
            var sveRazmjene = razmjenaServis.GetAll();

            if (validiraj())
            {

                var univerzitet = (UniverzitetiBrojIndeksa)cmbUniverzitet.SelectedItem;
                var drzava = (Drzava)cmbDrzava.SelectedItem;
                var ects = int.Parse(txtBrojKredita.Text);
                var pocetak = dtpPocetak.Value;
                var kraj = dtpKraj.Value;

                if(sveRazmjene.Exists(x=>(pocetak>=x.PocetakRazmjene && pocetak<=x.KrajRazmjene)||
                (kraj>=x.PocetakRazmjene && kraj<=x.KrajRazmjene)
                || (pocetak>=x.PocetakRazmjene && kraj <= x.KrajRazmjene)))
                {
                    MessageBox.Show("Ne mozete dodati");
                    return;
                }else if (kraj < pocetak)
                {
                    MessageBox.Show("Ne mozete dodati");
                    return;
                }
                else
                {
                    var nova = new RazmjeneBrojIndeksa()
                    {
                        StudentID = odabraniStudent.Id,
                        UniverzitetID = univerzitet.UniverzitetBrojIndeksaID,
                        ECTS = ects,
                        PocetakRazmjene = pocetak,
                        KrajRazmjene = kraj,
                        Okoncana = false
                    };
                    razmjenaServis.Add(nova);
                    razmjenaServis.SaveChanges();
                    UcitajPodatke();
                }
            }
        }

        private bool validiraj()
        {
            return Helpers.Validator.ValidanUnos(txtBrojKredita, errorProvider1, "Morate") &&
                Helpers.Validator.ValidanUnos(dtpKraj, errorProvider1, "Morate") &&
                Helpers.Validator.ValidanUnos(dtpPocetak, errorProvider1, "Morate");
        }
        private void btnPotvrda_Click(object sender, EventArgs e)
        {
            var razmjenaServis = new RazmjeneBrojIndeksaServis();
            var sveRazmjene = razmjenaServis.GetAll();
            var noveRazmjene = sveRazmjene.Where(x => x.StudentID == odabraniStudent.Id).ToList();

            var nova = new frmIzvjestaji(noveRazmjene);
            nova.ShowDialog();
        
        }

        private void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            var univerzitetServis= new UniverzitetiBrojIndeksaServis();
            var sviUniverziteti = univerzitetServis.GetAll();

            var drzava = (Drzava)cmbDrzava.SelectedItem;
            if (drzava != null)
            {
                cmbUniverzitet.DataSource = sviUniverziteti.Where(x => x.DrzavaID == drzava.Id).ToList();
            }


        }

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            var faks = (UniverzitetiBrojIndeksa)cmbFaks.SelectedItem;
            var brojRazmjena = int.Parse(txtBrojRazm.Text);
            Thread t1 = new Thread(() => GenerisiRazmjene(faks, brojRazmjena));
            t1.Start();
        
        
        }

        private void GenerisiRazmjene(UniverzitetiBrojIndeksa? faks, int brojRazmjena)
        {
            var razmjenaServis = new RazmjeneBrojIndeksaServis();

            var pocetak = new DateTime(2026, 01, 01);
            var ects = int.Parse(txtBrojKredita.Text);

            for (int i = 0; i < brojRazmjena; i++)
            {
                var kraj = pocetak.AddDays(ects + (i + 1));
                var nova = new RazmjeneBrojIndeksa()
                {
                    StudentID = odabraniStudent.Id,
                    UniverzitetID = faks.UniverzitetBrojIndeksaID,
                    PocetakRazmjene = pocetak,
                    KrajRazmjene = kraj,
                    ECTS = ects,
                    Okoncana = kraj > DateTime.Now ? false : true
                };
                razmjenaServis.Add(nova);
                razmjenaServis.SaveChanges();
                Action ac = () =>
                {
                    txtInfo.Text += $"{i + 1}. razmjena za {odabraniStudent.ImePrezime} na {faks} u ({pocetak}-{kraj})" + Environment.NewLine;
                    txtInfo.SelectionStart = txtInfo.Text.Length;
                    txtInfo.ScrollToCaret();
                };
                BeginInvoke(ac);
                Thread.Sleep(300);
            }

            BeginInvoke(UcitajPodatke);
            MessageBox.Show("Uspjesno ste odradili thread");
        }

        private void dgvRazmjene_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var razmjena = (RazmjeneBrojIndeksa)dgvRazmjene.Rows[e.RowIndex].DataBoundItem;
            var razmjenaServis = new RazmjeneBrojIndeksaServis();

            if (razmjena != null)
            {
                if (e.ColumnIndex == btnObrisi.Index)
                {
                    var poruka = MessageBox.Show("Da li ste sigurni da zelite obrisati?", "Upit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (poruka == DialogResult.Yes)
                    {
                        razmjenaServis.Remove(razmjena);
                        razmjenaServis.SaveChanges();
                        UcitajPodatke();
                    }

                }
            }

        }
    }
}
