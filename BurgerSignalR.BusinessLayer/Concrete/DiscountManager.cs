﻿using BurgerSignalR.BusinessLayer.Abstract;
using BurgerSignalR.DataAccessLayer.Abstract;
using BurgerSignalR.EntityLayer.Entities;

namespace BurgerSignalR.BusinessLayer.Concrete
{
    public class DiscountManager : IDiscountService
    {
        private readonly IDiscountDal _discountDal;

        public DiscountManager(IDiscountDal discountDal)
        {
            _discountDal = discountDal;
        }

        public void TAdd(Discount entity)
        {
           _discountDal.Add(entity);
        }


		public void TDelete(Discount entity)
        {
           _discountDal.Delete(entity);
        }

        public Discount TGetByID(int id)
        {
           return _discountDal.GetByID(id);
        }

        public List<Discount> TGetListAll()
        {
           return _discountDal.GetListAll();
        }

	

		public void TUpdate(Discount entity)
        {
            _discountDal.Update(entity);
        }
    }
}
