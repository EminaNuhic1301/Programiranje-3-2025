using Studentska.Data.Entiteti;
using Studentska.Servis.Servisi;
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
            dgvPretrage.AutoGenerateColumns = false;
            UcitajPodatke();
            UcitajCMB();
        }

        private void UcitajCMB()
        {
            var drzavaServis = new DrzavaServis();
            var sveDrzave = drzavaServis.GetAll();

            var spolServis = new SpolServis();
            var sviSpolovi = spolServis.GetAll();

            cmbDrzava.DataSource = sveDrzave.ToList();
            cmbSpol.DataSource = sviSpolovi.ToList();
        }

        private void UcitajPodatke()
        {
            var drzavaServis = new DrzavaServis();
            var sveDrzave = drzavaServis.GetAll();

            var spolServis = new SpolServis();
            var sviSpolovi = spolServis.GetAll();

            var studentServis = new StudentServis();
            var sviStudenti = studentServis.GetAll();

            var imeIliPrezime = txtPretraga.Text.Trim().ToLower();

            var drzava = cmbDrzava.SelectedItem == null ? sveDrzave.FirstOrDefault() : cmbDrzava.SelectedItem as Drzava;

            var spol = cmbSpol.SelectedItem == null ? sviSpolovi.FirstOrDefault() : cmbSpol.SelectedItem as Spol;



            var podaci = sviStudenti.Where(x => (
            x.Ime.ToLower().StartsWith(imeIliPrezime.ToLower()) ||
            x.Prezime.ToLower().StartsWith(imeIliPrezime.ToLower()) ||
            imeIliPrezime == ""
            )
            && x.Grad.DrzavaId == drzava.Id && x.SpolId == spol.Id
            ).ToList();

            if (podaci.Count != 0)
            {
                dgvPretrage.DataSource = null;
                dgvPretrage.DataSource = podaci;
                this.Text = $"Broj prikazanih studenata: {podaci.Count}";
            }
            else
            {
                dgvPretrage.DataSource = null;
            }
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }



        private void dgvPretrage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            var odabraniStudent = (Student)dgvPretrage.Rows[e.RowIndex].DataBoundItem;
            var studentServis = new StudentServis();

            if (odabraniStudent != null)
            {
                if (e.ColumnIndex != Aktivan.Index && e.ColumnIndex != btnRazmjene.Index)
                {
                    var forma = new frmStudentEditBrojIndeksa(odabraniStudent);
                    forma.ShowDialog();
                    UcitajPodatke();
                }
            }




        }

        private void dgvPretrage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            var odabraniStudent = (Student)dgvPretrage.Rows[e.RowIndex].DataBoundItem;
            var studentServis = new StudentServis();

            if (odabraniStudent != null)
            {
                if (e.ColumnIndex == Aktivan.Index)
                {
                    if (odabraniStudent.Aktivan == true)
                    {
                        odabraniStudent.Aktivan = false;
                    }
                    else
                    {
                        odabraniStudent.Aktivan = true;
                    }


                    studentServis.Update(odabraniStudent);
                    studentServis.SaveChanges();
                    UcitajPodatke();
                }
                else if (e.ColumnIndex == btnRazmjene.Index)
                {
                    var nova = new frmRazmjeneBrojIndeksa(odabraniStudent);
                    nova.ShowDialog();
                    UcitajPodatke();
                }
            }


        }
    }
}
