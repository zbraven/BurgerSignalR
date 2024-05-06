using BurgerSignalR.EntityLayer.Entities;

namespace BurgerSignalR.DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Product> GetProductsWithCategories();
       int ProductCount();
       int ProductCountByCategoryNameHamburger();
       int ProductCountByCategoryNameDrink();
       decimal ProductPriceAvg(); 
       string ProductNameByMinPrice();
       string ProductNameByMaxPrice();

    }
}
