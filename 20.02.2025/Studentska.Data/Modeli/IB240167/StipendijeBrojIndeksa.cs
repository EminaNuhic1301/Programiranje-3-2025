using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Studentska.Data.Modeli.IB240167
{
    public class StipendijeBrojIndeksa
    {
    public int ID { get; set; }
	public string Naziv {get;set;}
        public override string ToString()
        {
            return Naziv.ToString();
        }
    }
}
