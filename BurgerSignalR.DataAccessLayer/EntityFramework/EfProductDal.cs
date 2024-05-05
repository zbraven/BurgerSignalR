using Microsoft.EntityFrameworkCore;
using BurgerSignalR.DataAccessLayer.Abstract;
using BurgerSignalR.DataAccessLayer.Repositories;
using BurgerSignalR.EntityLayer.Entities;

namespace BurgerSignalR.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        private readonly BurgerContext _context;
        public EfProductDal(BurgerContext context) : base(context)
        {
            _context = context;
        }

        public List<Product> GetProductsWithCategories()
        {
            return _context.Products.Include(p => p.Category).ToList();
        }

        public int ProductCount()
        {
           return _context.Products.Count();
        }
    }
}
