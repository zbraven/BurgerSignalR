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

        public int ProductCountByCategoryNameDrink()
        {
            return _context.Products.Where(p => p.CategoryID == (_context.Products.Where(c => c.Category.CategoryName == "İçecek").Select(z => z.CategoryID).FirstOrDefault())).Count();
        }

        public int ProductCountByCategoryNameHamburger()
        {
            return _context.Products.Where(p => p.CategoryID == (_context.Products.Where(c => c.Category.CategoryName == "Hamburger").Select(z => z.CategoryID).FirstOrDefault())).Count();
        }

        public string ProductNameByMaxPrice()
        {
            return _context.Products.Where(x => x.Price == (_context.Products.Max(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
        }

        public string ProductNameByMinPrice()
        {
            return _context.Products.Where(x => x.Price == (_context.Products.Min(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
        }

        public decimal ProductPriceAvg()
        {
            return _context.Products.Average(p => p.Price);
        }
    }
}
