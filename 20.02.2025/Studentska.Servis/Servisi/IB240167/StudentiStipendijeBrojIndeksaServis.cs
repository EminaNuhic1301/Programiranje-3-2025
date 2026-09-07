using Microsoft.EntityFrameworkCore;
using Studentska.Data.Modeli.IB240167;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Servis.Servisi.IB240167
{
    public class StudentiStipendijeBrojIndeksaServis:BaseServis<StudentiStipendijeBrojIndeksa>
    {
        public List<StudentiStipendijeBrojIndeksa> GetAll()
        {
            return _dbContext.StudentiStipendijeBrojIndeksa
              .Include(x => x.Student)
              .Include(x => x.StipendijaGodina)
              .ThenInclude(x => x.Stipendija).ToList();
        }
    }
}
