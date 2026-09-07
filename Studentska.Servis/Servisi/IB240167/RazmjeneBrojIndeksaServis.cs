using Microsoft.EntityFrameworkCore;
using Studentska.Data.Modeli.IB240167;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Servis.Servisi.IB240167
{
    public class RazmjeneBrojIndeksaServis:BaseServis<RazmjeneBrojIndeksa>
    {
        public List<RazmjeneBrojIndeksa> GetAll()
        {
            return _dbContext.RazmjeneBrojIndeksa
                .Include(x => x.Univerzitet)
                 .Include(x => x.Student)
                .ThenInclude(x => x.Grad)
                .ThenInclude(x => x.Drzava).ToList();
        }
    }
}
