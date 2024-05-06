using BurgerSignalR.BusinessLayer.Abstract;
using BurgerSignalR.DataAccessLayer.Abstract;
using BurgerSignalR.EntityLayer.Entities;

namespace BurgerSignalR.BusinessLayer.Concrete
{
    public class OrderDetailManager : IOrderDetailService
    {
        private readonly IOrderDetailDal _orderDetailDal;

        public OrderDetailManager(IOrderDetailDal orderDetailDal)
        {
            _orderDetailDal = orderDetailDal;
        }

        public void TAdd(OrderDetail entity)
        {
            _orderDetailDal.Add(entity);    
        }

        public void TDelete(OrderDetail entity)
        {
            _orderDetailDal.Delete(entity);
        }

        public OrderDetail TGetByID(int id)
        {
           return _orderDetailDal.GetByID(id);
        }

        public List<OrderDetail> TGetListAll()
        {
            return _orderDetailDal.GetListAll();
        }

        public void TUpdate(OrderDetail entity)
        {
            _orderDetailDal.Update(entity);
        }
    }
}
