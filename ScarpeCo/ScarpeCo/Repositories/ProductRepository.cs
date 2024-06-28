using ScarpeCo.Models;
using System.Collections.Generic;
using System.Linq;

namespace ScarpeCo.Repositories
{
    public static class ProductRepository
    {
        private static List<Product> products = new List<Product>
        {
            new Product
            {
                Id = 1, Name = "Jordan Retro 4", 
                Price = 109.99m, 
                Description = "Jordan Retro 4 White", 
                CoverImage = "/images/Jordan.jpeg", 
                AdditionalImage1 = "/images/Jordan.jpeg", 
                AdditionalImage2 = "/images/Jordan4Retro.jpg"
            },

            new Product
            { 
                Id = 2, Name = "Air Jordan 1 MID ",
                Price = 169.99m,
                Description = "Air Jordan 1 MID Black&Red",
                CoverImage = "/images/Jordan4Retro.jpg",
                AdditionalImage1 = "/images/Jordan4Retro.jpg",
                AdditionalImage2 = "/images/Jordan4Retro.jpg"
            },
        };

        public static List<Product> GetAll() => products;

        public static Product? GetById(int id) => products.FirstOrDefault(p => p.Id == id);
    }
}
