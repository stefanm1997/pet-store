using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly OrderService _orderService;
        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        /// <summary>
        /// Create order
        /// </summary>
        /// <returns>Return created order</returns>
        /// <response code="200">Successful created order</response>
        /// <response code="400">Bad request</response>
        [HttpPost("buy")]
        public IActionResult Create([FromBody] Order order)
        {
            try
            {
                return Ok(new { Order = _orderService.Add(order), Message = "Your order is successful created!" });
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        /// <summary>
        /// Get order by id
        /// </summary>
        /// <returns>Return one order</returns>
        /// <response code="200">Successful returned order</response>
        /// <response code="404">Order not found</response>
        [HttpGet("{id}")]
        [Authorize]
        public IActionResult GetByID(Guid id)
        {
            try
            {
                return Ok(new { Order = _orderService.GetById(id) });
            }
            catch (Exception)
            {
                return NotFound();  
            }
        }

        /// <summary>
        /// Get all orders
        /// </summary>
        /// <returns>Return all orders</returns>
        /// <response code="200">Successful returned orders</response>
        /// <response code="404">orders not found</response>
        [HttpGet]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(new { Orders = _orderService.GetAll() });
            }
            catch (Exception)
            {
                return NotFound();
            }           
        }

        /// <summary>
        /// Update order
        /// </summary>
        /// <returns>Return updated order</returns>
        /// <response code="200">Successful updated order</response>
        /// <response code="400">Bad request</response>
        [HttpPut("{id}")]
        [Authorize]
        public IActionResult Update(Guid id, [FromBody] Order order)
        {
            try
            {
                return Ok(new { Order = _orderService.Update(id, order) });
            }
            catch (Exception)
            {
                return BadRequest();
            }          
        }

        /// <summary>
        /// Delete order
        /// </summary>
        /// <returns>Return deleted order</returns>
        /// <response code="200">Successful deleted order</response>
        /// <response code="404">Order not found</response>
        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult DeleteById(Guid id)
        {
            try
            {
                return Ok(new { Orders = _orderService.Remove(id) });
            }
            catch (Exception)
            {
                return NotFound();
            }
            
        }
    }
}
