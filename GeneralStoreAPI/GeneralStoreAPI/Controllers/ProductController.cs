
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
    [RoutePrefix("api/product")]
    public class ProductController : ApiController
    {
        private readonly ApplicationDbContext _ctx = new ApplicationDbContext();
        // POST api/product
        [HttpPost]
        public async Task<IHttpActionResult> Create([FromBody] Product productToCreate)
        {
            Product createdProduct = _ctx.Products.Add(productToCreate);

            await _ctx.SaveChangesAsync();

            return Ok(createdProduct);
        }
        // GET api/product
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            List<Product> products = await _ctx.Products.ToListAsync();

            return Ok(products);
        }
        // GET api/product/:id
        [HttpGet]
        [Route("{id}")]
        public async Task<IHttpActionResult> GetSingle(int id)
        {
            //Product product = _ctx.Products.Where(prod => prod.Name == name).FirstOrDefault();

            Product requestedProduct = await _ctx.Products.FindAsync(id);

            if (requestedProduct == null)
            {
                return NotFound();
            }
            return Ok(requestedProduct);
        }
        // PUT api/product/:id
        [HttpPut]
        [Route("{id}")]
        public async Task<IHttpActionResult> Update([FromUri] int id, [FromBody] Product updatedProduct)
        {
            Product requestedProduct = await _ctx.Products.FindAsync(id);

            if (requestedProduct == null)
            {
                return NotFound();
            }
            if (updatedProduct.Name != null)
            {
                requestedProduct.Name = updatedProduct.Name;
            }
            if (updatedProduct.Price != default(decimal))
            {
                requestedProduct.Price = updatedProduct.Price;
            }

            try
            {
                await _ctx.SaveChangesAsync();
                return Ok(requestedProduct);
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
            Product requestedProduct = await _ctx.Products.FindAsync(id);

            if (requestedProduct == null)
            {
                return NotFound();
            }
            try
            {
                _ctx.Products.Remove(requestedProduct);
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