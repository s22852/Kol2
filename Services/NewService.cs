using System.Threading.Tasks;
using Kol2_ko_s22852.Models;

namespace Kol2_ko_s22852.Services
{
    public class NewService : INewService
    {
        private readonly NewDBContext _context;

        public NewService(NewDBContext context)
        {
            _context = context;
        }
        public async Task SaveDatabase()
        {
            await _context.SaveChangesAsync();
        }
    }
}