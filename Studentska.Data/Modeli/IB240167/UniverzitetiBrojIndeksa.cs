using Studentska.Data.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Studentska.Data.Modeli.IB240167
{
    public class UniverzitetiBrojIndeksa
    {
   [Key] public int UniverzitetBrojIndeksaID {get;set;}
	public string Naziv                    {get;set;}
	public int DrzavaID { get; set; }
        public Drzava Drzava { get; set; }
        public override string ToString()
        {
            return Naziv.ToString();
        }
    }
}
