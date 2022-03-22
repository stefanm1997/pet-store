using DataAccess.EFCore.Repositories;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace WebAPI.Services
{
    public class OrderService : IOrderService
    {
        private readonly OrderRepository _orderRepository;
        public OrderService(OrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public Order GetById(Guid id)
        {
            var order = _orderRepository.GetById(id);
            if (order != null)
            {
                return order;
            }
            else
            {
                throw new Exception();
            }   
        }
        public IEnumerable<Order> GetAll()
        {
            var allOrders = _orderRepository.GetAll();
            if (allOrders != null)
            {
                return allOrders;
            }
            else
            {
                throw new Exception();
            }   
        }
        public Order Add(Order entity)
        {
            if (string.IsNullOrWhiteSpace(entity.CustomerAddress) || string.IsNullOrWhiteSpace(entity.CustomerCreditCard) || 
                string.IsNullOrWhiteSpace(entity.CustomerLastname) || string.IsNullOrWhiteSpace(entity.CustomerFirstname) ||
                entity.PetToys == null || entity.PetToys.Count == 0)
            {
                throw new Exception();
            }
            else
            {
                entity.OrderDate = DateTime.Now;
                _orderRepository.Add(entity);
                return entity;
            }
        }
        public Order Remove(Guid id)
        {
            var order = GetById(id);
            if (order != null)
            {
                _orderRepository.Remove(order);
                return order;
            }
            else
            {
                throw new Exception();
            }
        }
        public Order Update(Guid id, Order entity)
        {
            if (!Guid.Equals(id, entity.Id))
            {
                throw new Exception();
            }
            if (id == Guid.Empty || entity.Id == Guid.Empty || string.IsNullOrWhiteSpace(entity.CustomerAddress) || 
                string.IsNullOrWhiteSpace(entity.CustomerCreditCard) || string.IsNullOrWhiteSpace(entity.CustomerLastname) ||
                string.IsNullOrWhiteSpace(entity.CustomerFirstname) || entity.OrderDate == DateTime.MinValue || entity.PetToys == null)
            {
                throw new Exception();
            }
            _orderRepository.Update(id, entity);
            return entity;
        }
    }
}
