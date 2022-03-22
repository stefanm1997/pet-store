using Domain.Entities;
using System;
using System.Collections.Generic;

namespace WebAPI.Services
{
    public interface IOrderService
    {
        Order GetById(Guid id);
        IEnumerable<Order> GetAll();
        Order Add(Order entity);
        Order Remove(Guid id);
        Order Update(Guid id, Order entity);
    }
}
