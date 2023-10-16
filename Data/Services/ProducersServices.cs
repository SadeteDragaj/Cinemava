using Cinemava.Data.Base;
using Cinemava.Models;

namespace Cinemava.Data.Services
{
    public class ProducersServices : EntityBaseRespository<Producer>, IProducersServices
    {
        public ProducersServices(AppDbContext context) : base(context)
        {
            
        }
    }
}
