using Microsoft.EntityFrameworkCore;
using Studentska.Data.Entiteti;

namespace Studentska.Servis.Servisi
{
    public class StudentServis : BaseServis<Student>
    {

        public int GetBrojStudenata()
        {
            return _dbContext.Studenti.Count();
        }

        public List<Student> GetAll()
        {
            return _dbContext.Studenti
                .Include(x => x.Grad)
                .ThenInclude(x => x.Drzava)
                .Include(x => x.Spol)
                .ToList();
        }

    }
}
