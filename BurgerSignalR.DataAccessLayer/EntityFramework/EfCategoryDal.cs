using BurgerSignalR.DataAccessLayer.Abstract;
using BurgerSignalR.DataAccessLayer.Repositories;
using BurgerSignalR.EntityLayer.Entities;

namespace BurgerSignalR.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        private readonly BurgerContext _context;
        public EfCategoryDal(BurgerContext context) : base(context)
        {
            _context = context;
        }

        public int ActiveCategoryCount()
        {
            return _context.Categories.Where(x=>x.Status==true).Count();    
        }

        public int CategoryCount()
        {
            return _context.Categories.Count();
        }

        public int PassiveCategoryCount()
        {
            return _context.Categories.Where(x => x.Status == false).Count();
        }
    }
}
