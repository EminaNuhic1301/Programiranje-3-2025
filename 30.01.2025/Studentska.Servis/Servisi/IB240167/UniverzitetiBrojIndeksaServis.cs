using Microsoft.EntityFrameworkCore;
using Studentska.Data.Modeli.IB240167;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Servis.Servisi.IB240167
{
    public class UniverzitetiBrojIndeksaServis: BaseServis<UniverzitetiBrojIndeksa>
    {
        public List<UniverzitetiBrojIndeksa> GetAll()
        {
            return _dbContext.UniverzitetiBrojIndeksa
                .Include(x=>x.Drzava)
                .ToList();
        }
    }
}
