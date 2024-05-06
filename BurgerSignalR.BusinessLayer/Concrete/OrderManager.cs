﻿using BurgerSignalR.BusinessLayer.Abstract;
using BurgerSignalR.DataAccessLayer.Abstract;
using BurgerSignalR.DataAccessLayer.EntityFramework;
using BurgerSignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerSignalR.BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void TAdd(Order entity)
        {
            _orderDal.Add(entity);  
        }

        public void TDelete(Order entity)
        {
            _orderDal.Delete(entity);   
        }

        public Order TGetByID(int id)
        {
            return _orderDal.GetByID(id);
        }

        public List<Order> TGetListAll()
        {
            return _orderDal.GetListAll();
        }

        public void TUpdate(Order entity)
        {
            _orderDal.Update(entity);

        }
    }
}
