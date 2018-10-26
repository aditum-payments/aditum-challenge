using System;

namespace Aditum.Catalog.Model
{
    /// <summary>
    /// Catalog product model.
    /// </summary>
    public class Product
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Amount { get; set; }

        public Nullable<decimal> Weight { get; set; }

        public Nullable<decimal> Hight { get; set; }

        public Nullable<decimal> Width { get; set; }
    }
}
