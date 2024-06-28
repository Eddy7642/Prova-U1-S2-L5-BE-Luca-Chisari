using ScarpeCo.Models;
using System.Collections.Generic;
using System.Linq;

namespace ScarpeCo.Repositories
{
    public static class ProductRepository
    {
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Scarpa A", Price = 49.99m, Description = "Scarpa A dettagliata", CoverImage = "cover1.jpg", AdditionalImage1 = "add1.jpg", AdditionalImage2 = "add2.jpg" },
            new Product { Id = 2, Name = "Scarpa B", Price = 59.99m, Description = "Scarpa B dettagliata", CoverImage = "cover2.jpg", AdditionalImage1 = "add3.jpg", AdditionalImage2 = "add4.jpg" },
        };

        public static List<Product> GetAll() => products;

        public static Product? GetById(int id) => products.FirstOrDefault(p => p.Id == id);
    }
}
