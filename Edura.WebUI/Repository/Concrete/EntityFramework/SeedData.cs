using Edura.WebUI.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Repository.Concrete.EntityFramework
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.GetRequiredService<EduraContext>();


            context.Database.Migrate();
            if (!context.Products.Any())
            {
                var products = new[]
                {
                    new Product(){ProductName="Mustang s25", Price=25622},
                    new Product(){ProductName="Renault Clio", Price=25622},
                    new Product(){ProductName="Ford Focus", Price=25622},
                    new Product(){ProductName="Jeep GrandCharoke", Price=25622}

                };
                context.Products.AddRange(products);
                var categories = new[]
                {
                    new Category(){CategoryName="Amerikan Kası"},
                    new Category(){CategoryName="Alman Kası"},
                    new Category(){CategoryName="Fransız Kası"}
                };
                context.Categories.AddRange(categories);
                var productcategories = new[]
                {
                    new ProductCategory(){Product=products[0],Category=categories[0]},
                    new ProductCategory(){Product=products[1],Category=categories[2]},
                    new ProductCategory(){Product=products[2],Category=categories[1]},
                    new ProductCategory(){Product=products[3],Category=categories[0]},
                };
                context.AddRange(productcategories);
                context.SaveChanges();
            }
        }
    }
}
