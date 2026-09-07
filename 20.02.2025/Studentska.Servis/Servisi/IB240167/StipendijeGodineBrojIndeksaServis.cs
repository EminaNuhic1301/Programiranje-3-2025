using Microsoft.EntityFrameworkCore;
using Studentska.Data.Modeli.IB240167;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Servis.Servisi.IB240167
{
    public class StipendijeGodineBrojIndeksaServis:BaseServis<StipendijeGodineBrojIndeksa>
    {
        public List<StipendijeGodineBrojIndeksa> GetAll()
        {
            return _dbContext.StipendijeGodineBrojIndeksa.Include(x => x.Stipendija).ToList();
        }
    }
}
