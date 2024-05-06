using BurgerSignalR.DataAccessLayer.Abstract;
using BurgerSignalR.DataAccessLayer.Repositories;
using BurgerSignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerSignalR.DataAccessLayer.EntityFramework
{
    public class EfOrderDal: GenericRepository<Order>, IOrderDal
    {
        private readonly BurgerContext _context;
        public EfOrderDal(BurgerContext context) : base(context)
        {
            _context = context;
        }
    }
}
