using Cinemava.Data.Base;
using Cinemava.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinemava.Data.Services
{
    public class ActorsService : EntityBaseRespository<Actor>, IActorsService
    {

        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context) : base(context){ }

       
    }
}
