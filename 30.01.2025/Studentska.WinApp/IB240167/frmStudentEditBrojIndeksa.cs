using Studentska.Data.Entiteti;
using Studentska.Servis.Servisi;
using Studentska.WinApp.Helpers;
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
    public partial class frmStudentEditBrojIndeksa : Form
    {
        private Student odabraniStudent;
        public frmStudentEditBrojIndeksa(Student? odabraniStudent)
        {
            InitializeComponent();
            this.odabraniStudent = odabraniStudent;
            lblImePrezime.Text = $"{odabraniStudent.Ime} {odabraniStudent.Prezime}";
            lblBrojIndeksa.Text = $"{odabraniStudent.Indeks}";

            if (odabraniStudent != null)
            {
                pbSlika.Image = ImageHelper.ByteToImage(odabraniStudent.Slika);
            }
            UcitajCMB();
        }

        private void UcitajCMB()
        {
            var drzavaServis = new DrzavaServis();
            var sveDrzave = drzavaServis.GetAll();

            cmbDrzava.DataSource = sveDrzave;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var grad = (Grad)cmbGrad.SelectedItem;
            var drzava = (Drzava)cmbDrzava.SelectedItem;

            var studentServis = new StudentServis();
            if (validacija1())
            {
                odabraniStudent.Slika = ImageHelper.ImageToByte(pbSlika.Image);
                odabraniStudent.Grad = grad;

                studentServis.Update(odabraniStudent);
                studentServis.SaveChanges();
                Close();
            }
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            var drzava = (Drzava)cmbDrzava.SelectedItem;
            var gradServis = new GradServis();
            var sviGradovi = gradServis.GetAll();
            cmbGrad.DataSource = sviGradovi.Where(x => x.DrzavaId == drzava.Id).ToList();
        }

        private bool validacija1()
        {
            return Helpers.Validator.ValidanUnos(pbSlika, errorProvider1, "Morate");
        }
    }
}
