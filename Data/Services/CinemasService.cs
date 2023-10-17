using Cinemava.Data.Base;
using Cinemava.Models;

namespace Cinemava.Data.Services
{
    public class CinemasService : EntityBaseRespository<Cinema>, ICinemasService
    {
        private readonly AppDbContext _context;

        public CinemasService(AppDbContext context) : base(context){ }
    }
}
