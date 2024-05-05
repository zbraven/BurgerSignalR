using BurgerSignalR.EntityLayer.Entities;

namespace BurgerSignalR.DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Product> GetProductsWithCategories();
        public int ProductCount();

    }
}
