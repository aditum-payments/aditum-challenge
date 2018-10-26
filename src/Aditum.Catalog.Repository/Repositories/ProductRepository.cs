using Aditum.Catalog.Repository.Entities;
using MongoDbGenericRepository;
using System;

namespace Aditum.Catalog.Repository.Repositories
{
    /// <summary>
    /// Responsible for managing objects in the database.
    /// </summary>
    public class ProductRepository
    {
        private readonly IBaseMongoRepository mongoRepository;

        /// <summary>
        /// Inserts the product into the database.
        /// </summary>
        public ProductEntity Insert(ProductEntity newProduct)
        {
            this.mongoRepository.AddOne(newProduct);

            return newProduct;
        }

        /// <summary>
        /// Get's a product by it's ID.
        /// </summary>
        public ProductEntity GetById(Guid productId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates only filled properties of a product, by it's ID.
        /// </summary>
        public ProductEntity UpdateById(Guid productId, ProductEntity updatedProduct)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a product by it's ID.
        /// </summary>
        public void DeleteById(Guid productId)
        {
            throw new NotImplementedException();
        }

        public ProductRepository()
        {
            this.mongoRepository = new MongoRepository(
                "mongodb://localhost:27017",
                "ProductCatalog");
        }
    }
}
