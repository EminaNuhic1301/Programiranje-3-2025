using Microsoft.Reporting.WinForms;
using Studentska.Data.Modeli.IB240167;

namespace Studentska.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<RazmjeneBrojIndeksa> razmjene;
        public frmIzvjestaji(List<RazmjeneBrojIndeksa>? razmjene)
        {
            InitializeComponent();
            this.razmjene = razmjene;
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "Studentska.WinApp.Izvjestaji.rptStudentiUplate.rdlc";
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
        }
    }
}
