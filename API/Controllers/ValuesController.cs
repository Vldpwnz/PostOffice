using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    [Route("api/parcels")]
    [ApiController]
    public class ParcelsController : ControllerBase
    {
        private readonly DataContext _context;

        public ParcelsController(DataContext context)
        {
            this._context = context;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Parcel>>> Get()
        {
            var parcels = await _context.Parcels.ToListAsync();
            return Ok(parcels);
        }

        // GET api/values/5
        [HttpGet("parcel/{number}")]
        public async Task<ActionResult<Parcel>> Get(string number)
        {
            var parcel = await _context.Parcels.FindAsync(number);
            return Ok(parcel);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}