using BurgerSignalR.DtoLayer.ProductDto;
using BurgerSignalR.EntityLayer.Entities;

namespace BurgerSignalR.BusinessLayer.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        List<Product> TGetProductsWithCategories();
    }
}
