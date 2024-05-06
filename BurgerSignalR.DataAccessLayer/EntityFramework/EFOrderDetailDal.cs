using BurgerSignalR.DataAccessLayer.Abstract;
using BurgerSignalR.DataAccessLayer.Repositories;
using BurgerSignalR.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerSignalR.DataAccessLayer.EntityFramework
{
    public class EFOrderDetailDal : GenericRepository<OrderDetail>, IOrderDetailDal
    {
        private readonly BurgerContext _context;
        public EFOrderDetailDal(BurgerContext context) : base(context)
        {
            _context = context;
        }
    }
}
