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
    public class RazmjeneBrojIndeksa
    {
  [Key]  public int RazmjeneBrojIndeksaID {get;set;}
	public int StudentID			 {get;set;}
		public Student Student { get; set; }
	public int UniverzitetID		 {get;set;}
		public UniverzitetiBrojIndeksa Univerzitet { get; set; }
	public DateTime PocetakRazmjene		 {get;set;}
	public DateTime KrajRazmjene			 {get;set;}
	public int ECTS					 {get;set;}
	public bool Okoncana { get; set; }

		public string Naziv => $"{Univerzitet.Naziv}";
		public string ImePrezime => $"({Student.Indeks})-{Student.Ime} {Student.Prezime}";
    }
}
