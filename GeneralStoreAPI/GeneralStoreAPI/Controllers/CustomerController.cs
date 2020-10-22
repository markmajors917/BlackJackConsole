using GeneralStoreAPI.Models;
using GeneralStoreAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace GeneralStoreAPI.Controllers
{
    [RoutePrefix("api/customer")]
    public class CustomerController : ApiController
    {
        private readonly ApplicationDbContext _ctx = new ApplicationDbContext();
        // POST api/product
        [HttpPost]
        public async Task<IHttpActionResult> Create([FromBody] Customer customerToCreate)
        {
            Customer createdCustomer = _ctx.Customers.Add(customerToCreate);

            await _ctx.SaveChangesAsync();

            return Ok(createdCustomer);
        }
        // GET api/product
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            List<Customer> customers = await _ctx.Customers.ToListAsync();

            return Ok(customers);
        }
        // GET api/product/:id
        [HttpGet]
        [Route("{id}")]
        public async Task<IHttpActionResult> GetSingle(int id)
        {
            //Product product = _ctx.Products.Where(prod => prod.Name == name).FirstOrDefault();

            Customer requestedCustomer = await _ctx.Customers.FindAsync(id);

            if (requestedCustomer == null)
            {
                return NotFound();
            }
            return Ok(requestedCustomer);
        }
        // PUT api/product/:id
        [HttpPut]
        [Route("{id}")]
        public async Task<IHttpActionResult> Update([FromUri] int id, [FromBody] Customer updatedCustomer)
        {
            Customer requestedCustomer = await _ctx.Customers.FindAsync(id);

            if (requestedCustomer == null)
            {
                return NotFound();
            }
            if (updatedCustomer.Name != null)
            {
                requestedCustomer.Name = updatedCustomer.Name;
            }
            try
            {
                await _ctx.SaveChangesAsync();
                return Ok(requestedCustomer);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        // DELETE api/product/:id
        [HttpDelete]
        [Route("{id}")]
        public async Task<IHttpActionResult> Delete([FromUri] int id)
        {
            Customer requestedCustomer = await _ctx.Customers.FindAsync(id);

            if (requestedCustomer == null)
            {
                return NotFound();
            }
            try
            {
                _ctx.Customers.Remove(requestedCustomer);
                await _ctx.SaveChangesAsync();

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
