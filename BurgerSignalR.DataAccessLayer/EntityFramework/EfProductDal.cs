using Microsoft.EntityFrameworkCore;
using BurgerSignalR.DataAccessLayer.Abstract;
using BurgerSignalR.DataAccessLayer.Repositories;
using BurgerSignalR.EntityLayer.Entities;

namespace BurgerSignalR.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(BurgerContext context) : base(context)
        {
        }

        public List<Product> GetProductsWithCategories()
        {
            return _context.Products.Include(p => p.Category).ToList();
        }
    }
}
