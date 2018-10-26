using Aditum.Catalog.Model;
using Aditum.Catalog.Repository.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace Aditum.Catalog.WebApi.Controllers
{
    /// <summary>
    /// Responsible for handling Products.
    /// </summary>
    [Route("api/1/catalog")]
    public class CatalogController : Controller
    {
        ProductRepository productRepository = new ProductRepository();

        // Create new product
        [HttpPost]
        public IActionResult Post([FromBody] Product newProduct)
        {
            try
            {
                // Validate product data:
                if (newProduct == null)
                {
                    return this.BadRequest(new Error { Code = 1, Message = "Missing product data" });
                }
                else
                {
                    if (newProduct.Amount <= 0)
                    {
                        return this.BadRequest(new Error { Code = 2, Message = "Invalid product amount" });
                    }
                    if (string.IsNullOrEmpty(newProduct.Name) == true)
                    {
                        return this.BadRequest(new Error { Code = 2, Message = "Invalid product name" });
                    }
                }

                // Insert product into the database:
                var insertedProduct = this.productRepository.Insert(new Repository.Entities.ProductEntity
                {
                    Amount = newProduct.Amount,
                    Description = newProduct.Description,
                    Hight = newProduct.Hight,
                    Name = newProduct.Name,
                    Weight = newProduct.Weight,
                    Width = newProduct.Width
                });

                // Return the created product:
                return this.Ok(new
                {
                    Success = true,
                    insertedProduct.Id,
                    newProduct,
                });
            }
            catch (Exception)
            {
                // Returns 500 if an unexpected exception occurres:
                return base.StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }

        // Read product
        [HttpGet("{productId}")]
        public IActionResult Get(Guid productId)
        {
            throw new NotImplementedException();
        }

        // Update
        [HttpPut("{productId}")]
        public IActionResult Put(Guid productId, [FromBody] Product updatedProduct)
        {
            throw new NotImplementedException();
        }

        // Delete
        [HttpDelete("{productId}")]
        public IActionResult Delete(Guid productId)
        {
            throw new NotImplementedException();
        }
    }
}
