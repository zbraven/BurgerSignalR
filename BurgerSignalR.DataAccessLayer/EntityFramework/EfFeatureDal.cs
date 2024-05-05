using BurgerSignalR.DataAccessLayer.Abstract;
using BurgerSignalR.DataAccessLayer.Repositories;
using BurgerSignalR.EntityLayer.Entities;
namespace BurgerSignalR.DataAccessLayer.EntityFramework
{
    public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
        private readonly BurgerContext _context;
        public EfFeatureDal(BurgerContext context) : base(context)
        {
            _context = context;
        }
    }
}
