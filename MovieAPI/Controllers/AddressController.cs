using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Data;
using MovieAPI.Data.DTOs;
using MovieAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : ControllerBase
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public AddressController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<Address> GetAddress()
        {
            return _context.Address;
        }

        [HttpGet("{id}")]
        public IActionResult FindAddressById(int id)
        {
            Address address = _context.Address.FirstOrDefault(address => address.Id == id);
            if (address != null)
            {
                ReadAddressDTO movieDTO = _mapper.Map<ReadAddressDTO>(address);

                return Ok(movieDTO);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult CreateAddress([FromBody] AddressDTO adressDTO)
        {
            Address address = _mapper.Map<Address>(adressDTO);
            _context.Address.Add(address);
            _context.SaveChanges();

            return CreatedAtAction(nameof(FindAddressById ), new { Id = address.Id }, address);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAddress([FromBody] AddressDTO updatedAddress, int id)
        {
            Address address = _context.Address.FirstOrDefault(address => address.Id == id);
            if (address != null)
            {
                _mapper.Map(updatedAddress, address);
                _context.SaveChanges();

                return NoContent();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAddress(int id)
        {
            Address address = _context.Address.FirstOrDefault(address => address.Id == id);
            if (address != null)
            {
                _context.Remove(address);
                _context.SaveChanges();

                return NoContent();
            }
            return NotFound();
        }
    }
}
