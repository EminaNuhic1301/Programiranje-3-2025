using Studentska.Data.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Data.Modeli.IB240167
{
    public class StudentiStipendijeBrojIndeksa
    {
    public int ID { get; set; }
	public int StudentID          {get;set;}
        public Student Student { get; set; }
	public int StipendijaGodinaID {get;set;}
        public StipendijeGodineBrojIndeksa StipendijaGodina { get; set; }


        public string ImePrezime => $"({Student.Indeks})-{Student.Ime} {Student.Prezime}";

        public string Stipendija => StipendijaGodina.Stipendija.Naziv;
        public int Godina => StipendijaGodina.Godina;
        public int Iznos => StipendijaGodina.Iznos;
        public int Ukupno => StipendijaGodina.Godina == DateTime.Now.Year ? StipendijaGodina.Iznos * DateTime.Now.Month : StipendijaGodina.Iznos * 12;
    }
}
