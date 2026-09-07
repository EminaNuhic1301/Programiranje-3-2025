using Studentska.Data.Modeli.IB240167;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Servis.Servisi.IB240167
{
    public class StipendijeBrojIndeksaServis:BaseServis<StipendijeBrojIndeksa>
    {
        public List<StipendijeBrojIndeksa> GetAll()
        {
            return _dbContext.StipendijeBrojIndeksa.ToList();
        }
    }
}
