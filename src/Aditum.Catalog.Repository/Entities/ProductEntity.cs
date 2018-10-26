using Aditum.Catalog.Model;
using MongoDbGenericRepository.Attributes;
using MongoDbGenericRepository.Models;
using System;

namespace Aditum.Catalog.Repository.Entities
{
    /// <summary>
    /// Represents a <see cref="Product"/> in the database.
    /// </summary>
    [CollectionName("Product")]
    public class ProductEntity : Document
    {
        public Nullable<DateTime> LastUpdateDate { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Amount { get; set; }

        public Nullable<decimal> Weight { get; set; }

        public Nullable<decimal> Hight { get; set; }

        public Nullable<decimal> Width { get; set; }

        public ProductEntity()
        {
            this.Version = 1;
        }
    }
}
