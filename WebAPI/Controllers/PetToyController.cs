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
    public class PetToyController : ControllerBase
    {
        private readonly PetToyService _petToyService;
        public PetToyController(PetToyService petToyService)
        {
            _petToyService = petToyService;
        }

        /// <summary>
        /// Create pet toy
        /// </summary>
        /// <returns>Return created toy</returns>
        /// <response code="200">Successful created toy</response>
        /// <response code="400">Bad request</response>
        [HttpPost]
        [Authorize]
        public IActionResult Create([FromBody] PetToy toy)
        {
            try
            {
                return Ok(new { Toy = _petToyService.Add(toy) });
            }
            catch (Exception)
            {
                return BadRequest();
            } 
        }

        /// <summary>
        /// Get pet toy by id
        /// </summary>
        /// <returns>Return one toy</returns>
        /// <response code="200">Successful returned toy</response>
        /// <response code="404">Toy not found</response>
        [HttpGet("{id}")]
        [Authorize]
        public IActionResult GetByID(Guid id)
        {
            try
            {
                return Ok(new { Toy = _petToyService.GetById(id) });
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Get all pet toys
        /// </summary>
        /// <returns>Return all toys</returns>
        /// <response code="200">Successful returned toys</response>
        /// <response code="404">Toys not found</response>
        [HttpGet]
        [Authorize]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(new { Toys = _petToyService.GetAll() });
            }
            catch (Exception)
            {
                return NotFound();
            }           
        }

        /// <summary>
        /// Filter pet toy by name
        /// </summary>
        /// <returns>Return one toy</returns>
        /// <response code="200">Successful returned toy</response>
        /// <response code="404">Toy not found</response>
        [HttpGet("filterByName")]
        public IActionResult FilterByName([FromQuery]string searchName)
        {
            try
            {
                return Ok(new { Toy = _petToyService.FilterByName(searchName) });
            }
            catch (Exception)
            {
                return NotFound();
            }
            
        }

        /// <summary>
        /// Filter pet toy by description
        /// </summary>
        /// <returns>Return one toy</returns>
        /// <response code="200">Successful returned toy</response>
        /// <response code="404">Toy not found</response>
        [HttpGet("filterByDescription")]
        public IActionResult FilterByDescription([FromQuery] string searchDescription)
        {
            try
            {
                return Ok(new { Toy = _petToyService.FilterByDescription(searchDescription) });
            }
            catch (Exception)
            {
                return NotFound();
            }
            
        }

        /// <summary>
        /// Update pet toy
        /// </summary>
        /// <returns>Return updated toy</returns>
        /// <response code="200">Successful updated toy</response>
        /// <response code="400">Bad request</response>
        [HttpPut("{id}")]
        [Authorize]
        public IActionResult Update(Guid id, [FromBody] PetToy toy)
        {
            try
            {
                return Ok(new { Toy = _petToyService.Update(id, toy) });
            }
            catch (Exception)
            {
                return BadRequest();    
            }

        }

        /// <summary>
        /// Delete pet toy
        /// </summary>
        /// <returns>Return deleted toy</returns>
        /// <response code="200">Successful deleted toy</response>
        /// <response code="404">Toy not found</response>
        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult DeleteById(Guid id)
        {
            try
            {
                return Ok(new { Toys = _petToyService.Remove(id) });
            }
            catch (Exception)
            {
                return NotFound();
            }            
        }

        /// <summary>
        /// Order pet toy
        /// </summary>
        /// <returns>Return list of ordered toy</returns>
        /// <response code="200">Successful order toy</response>
        [HttpPost("order")]
        public IActionResult OrderToy([FromQuery] string searchName)
        {
            return Ok(new { Ordered_Toys = _petToyService.AddToyToList(searchName)});
        }
    }
}
