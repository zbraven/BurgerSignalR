using BurgerSignalR.DataAccessLayer.Abstract;
using BurgerSignalR.DataAccessLayer.Repositories;
using BurgerSignalR.EntityLayer.Entities;

namespace BurgerSignalR.DataAccessLayer.EntityFramework
{
    public class EfDiscountDal : GenericRepository<Discount>, IDiscountDal
    {
        private readonly BurgerContext _context;
        public EfDiscountDal(BurgerContext context) : base(context)
        {
            _context = context;
        }

		
	}
}
