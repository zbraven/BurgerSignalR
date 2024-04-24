﻿using BurgerSignalR.DataAccessLayer.Abstract;
using BurgerSignalR.DataAccessLayer.Repositories;
using BurgerSignalR.EntityLayer.Entities;

namespace BurgerSignalR.DataAccessLayer.EntityFramework
{
    public class EfDiscountDal : GenericRepository<Discount>, IDiscountDal
    {
        public EfDiscountDal(BurgerContext context) : base(context)
        {
        }

		
	}
}