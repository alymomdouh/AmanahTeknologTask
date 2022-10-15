using AmanahTeknologTask.Domains;
using AmanahTeknologTask.Domains.Models;

namespace AmanahTeknologTask.Repositories
{
    public class TaxRepository : BaseRepository<Tax>, ITaxRepository
    {
        public TaxRepository(DataContext _context) : base(_context)
        {
        }
    }
}
