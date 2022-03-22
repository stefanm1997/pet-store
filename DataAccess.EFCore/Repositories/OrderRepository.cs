using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EFCore.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationContext context) : base(context)
        {
        }

        public new IEnumerable<Order> GetAll() 
        {
            return _context.Orders.Include(x => x.PetToys).ThenInclude(x => x.PetToys).ToList();
        }

        public new Order GetById(Guid id) 
        {
            return _context.Orders.Include(x => x.PetToys).ThenInclude(x => x.PetToys).Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
