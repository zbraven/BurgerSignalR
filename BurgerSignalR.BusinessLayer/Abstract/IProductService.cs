using BurgerSignalR.DtoLayer.ProductDto;
using BurgerSignalR.EntityLayer.Entities;

namespace BurgerSignalR.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TGetProductsWithCategories();
        int TProductCount();

        int TProductCountByCategoryNameDrink();
        int TProductCountByCategoryNameHamburger();
        decimal TProductPricaAvg();
        string TProductNameByMinPrice();
        string TProductNameByMaxPrice();
    }
}
