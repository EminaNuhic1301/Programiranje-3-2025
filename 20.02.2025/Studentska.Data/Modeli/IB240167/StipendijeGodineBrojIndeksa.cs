using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Data.Modeli.IB240167
{
    public class StipendijeGodineBrojIndeksa
    {
    public int ID          {get;set;}
	public int StipendijaID{get;set;}
        public StipendijeBrojIndeksa Stipendija { get; set; }
	public int Godina      {get;set;}
	public int Iznos       {get;set;}
	public bool Aktivna { get; set; }

        public int Ukupno => Godina == DateTime.Now.Year ? Iznos * DateTime.Now.Month : Iznos * 12;
    }
}
