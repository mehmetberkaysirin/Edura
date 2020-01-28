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

            var context = app.ApplicationServices
                .GetRequiredService<EduraContext>();

            context.Database.Migrate();

            if (!context.Products.Any())
            {
                var products = new[]
                {
                    new Product(){ ProductName="Photo Camera", Price=153, Image="product1.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Cybex Sirona sayesinde bebekler 105 cm boyuna erişene kadar, yani ortalama olarak 4 yaşına girene kadar koltuklarında rahat bir şekilde geriye dönük şekilde oturabiliyorlar. Koltuğun tek elle yatış özelliğine sahip olması sayesinde ebeveynler kısa sürede koltuğun pozisyonunu değiştirebiliyorlar. Almanya'da tasarlanan ve 14 kilogram ağırlığına sahip olan Sirona M, entegre lineer, yani yan darbe koruyucu sistemi sayesinde de bebeklerin araca yandan gelebilecek bir darbe durumunda zarar görmemesi için oldukça önemli bir avantaj sağlamaktadır.",HtmlContent="Cybex Sirona sayesinde bebekler 105 cm boyuna erişene kadar, yani ortalama olarak 4 yaşına girene kadar koltuklarında rahat bir şekilde geriye dönük şekilde oturabiliyorlar. Koltuğun tek elle yatış özelliğine sahip olması sayesinde ebeveynler kısa sürede koltuğun pozisyonunu değiştirebiliyorlar. Almanya'da tasarlanan ve 14 kilogram ağırlığına sahip olan Sirona M, entegre lineer, yani yan darbe koruyucu sistemi sayesinde de bebeklerin araca yandan gelebilecek bir <b> darbe durumunda zarar görmemesi için oldukça önemli bir avantaj sağlamaktadır.</b>",DateAded=DateTime.Now.AddDays(-10)},
                    new Product(){ ProductName="Wood Chair", Price=99, Image="product2.jpg",IsHome=false,IsApproved=true,IsFeatured=true,Description="Cybex Sirona sayesinde bebekler 105 cm boyuna erişene kadar, yani ortalama olarak 4 yaşına girene kadar koltuklarında rahat bir şekilde geriye dönük şekilde oturabiliyorlar. Koltuğun tek elle yatış özelliğine sahip olması sayesinde ebeveynler kısa sürede koltuğun pozisyonunu değiştirebiliyorlar. Almanya'da tasarlanan ve 14 kilogram ağırlığına sahip olan Sirona M, entegre lineer, yani yan darbe koruyucu sistemi sayesinde de bebeklerin araca yandan gelebilecek bir darbe durumunda zarar görmemesi için oldukça önemli bir avantaj sağlamaktadır.",HtmlContent="Cybex Sirona sayesinde bebekler 105 cm boyuna erişene kadar, yani ortalama olarak 4 yaşına girene kadar koltuklarında rahat bir şekilde geriye dönük şekilde oturabiliyorlar. Koltuğun tek elle yatış özelliğine sahip olması sayesinde ebeveynler kısa sürede koltuğun pozisyonunu değiştirebiliyorlar. Almanya'da tasarlanan ve 14 kilogram ağırlığına sahip olan Sirona M, entegre lineer, yani yan darbe koruyucu sistemi sayesinde de bebeklerin araca yandan gelebilecek bir <b> darbe durumunda zarar görmemesi için oldukça önemli bir avantaj sağlamaktadır.</b>",DateAded=DateTime.Now.AddDays(-15)},
                    new Product(){ ProductName="Comfortable Sofa", Price=526, Image="product3.jpg",IsHome=true,IsApproved=false,IsFeatured=true,Description="Cybex Sirona sayesinde bebekler 105 cm boyuna erişene kadar, yani ortalama olarak 4 yaşına girene kadar koltuklarında rahat bir şekilde geriye dönük şekilde oturabiliyorlar. Koltuğun tek elle yatış özelliğine sahip olması sayesinde ebeveynler kısa sürede koltuğun pozisyonunu değiştirebiliyorlar. Almanya'da tasarlanan ve 14 kilogram ağırlığına sahip olan Sirona M, entegre lineer, yani yan darbe koruyucu sistemi sayesinde de bebeklerin araca yandan gelebilecek bir darbe durumunda zarar görmemesi için oldukça önemli bir avantaj sağlamaktadır.",HtmlContent="Cybex Sirona sayesinde bebekler 105 cm boyuna erişene kadar, yani ortalama olarak 4 yaşına girene kadar koltuklarında rahat bir şekilde geriye dönük şekilde oturabiliyorlar. Koltuğun tek elle yatış özelliğine sahip olması sayesinde ebeveynler kısa sürede koltuğun pozisyonunu değiştirebiliyorlar. Almanya'da tasarlanan ve 14 kilogram ağırlığına sahip olan Sirona M, entegre lineer, yani yan darbe koruyucu sistemi sayesinde de bebeklerin araca yandan gelebilecek bir <b> darbe durumunda zarar görmemesi için oldukça önemli bir avantaj sağlamaktadır.</b>",DateAded=DateTime.Now.AddDays(-1)},
                    new Product(){ ProductName="Hand Bag", Price=125, Image="product4.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Cybex Sirona sayesinde bebekler 105 cm boyuna erişene kadar, yani ortalama olarak 4 yaşına girene kadar koltuklarında rahat bir şekilde geriye dönük şekilde oturabiliyorlar. Koltuğun tek elle yatış özelliğine sahip olması sayesinde ebeveynler kısa sürede koltuğun pozisyonunu değiştirebiliyorlar. Almanya'da tasarlanan ve 14 kilogram ağırlığına sahip olan Sirona M, entegre lineer, yani yan darbe koruyucu sistemi sayesinde de bebeklerin araca yandan gelebilecek bir darbe durumunda zarar görmemesi için oldukça önemli bir avantaj sağlamaktadır.",HtmlContent="Cybex Sirona sayesinde bebekler 105 cm boyuna erişene kadar, yani ortalama olarak 4 yaşına girene kadar koltuklarında rahat bir şekilde geriye dönük şekilde oturabiliyorlar. Koltuğun tek elle yatış özelliğine sahip olması sayesinde ebeveynler kısa sürede koltuğun pozisyonunu değiştirebiliyorlar. Almanya'da tasarlanan ve 14 kilogram ağırlığına sahip olan Sirona M, entegre lineer, yani yan darbe koruyucu sistemi sayesinde de bebeklerin araca yandan gelebilecek bir <b> darbe durumunda zarar görmemesi için oldukça önemli bir avantaj sağlamaktadır.</b>",DateAded=DateTime.Now.AddDays(-7)},
                    new Product(){ ProductName="Sofa", Price=250, Image="product3.jpg",IsHome=true,IsApproved=true,IsFeatured=true,Description="Cybex Sirona sayesinde bebekler 105 cm boyuna erişene kadar, yani ortalama olarak 4 yaşına girene kadar koltuklarında rahat bir şekilde geriye dönük şekilde oturabiliyorlar. Koltuğun tek elle yatış özelliğine sahip olması sayesinde ebeveynler kısa sürede koltuğun pozisyonunu değiştirebiliyorlar. Almanya'da tasarlanan ve 14 kilogram ağırlığına sahip olan Sirona M, entegre lineer, yani yan darbe koruyucu sistemi sayesinde de bebeklerin araca yandan gelebilecek bir darbe durumunda zarar görmemesi için oldukça önemli bir avantaj sağlamaktadır.",HtmlContent="Cybex Sirona sayesinde bebekler 105 cm boyuna erişene kadar, yani ortalama olarak 4 yaşına girene kadar koltuklarında rahat bir şekilde geriye dönük şekilde oturabiliyorlar. Koltuğun tek elle yatış özelliğine sahip olması sayesinde ebeveynler kısa sürede koltuğun pozisyonunu değiştirebiliyorlar. Almanya'da tasarlanan ve 14 kilogram ağırlığına sahip olan Sirona M, entegre lineer, yani yan darbe koruyucu sistemi sayesinde de bebeklerin araca yandan gelebilecek bir <b> darbe durumunda zarar görmemesi için oldukça önemli bir avantaj sağlamaktadır.</b>",DateAded=DateTime.Now.AddDays(-8)}
                };

                context.Products.AddRange(products);

                var categories = new[]
                {
                    new Category(){ CategoryName="Electronics"},
                    new Category(){ CategoryName="Accessories"},
                    new Category(){ CategoryName="Furniture"}
                };

                context.Categories.AddRange(categories);

                var productcategories = new[]
                {
                    new ProductCategory(){ Product=products[0],Category=categories[0]},
                    new ProductCategory(){ Product=products[1],Category=categories[0]},
                    new ProductCategory(){ Product=products[3],Category=categories[2]},
                    new ProductCategory(){ Product=products[2],Category=categories[1]}
                };

                context.AddRange(productcategories);

                var images = new[]
                {
                    new Images(){ ImageName="product1.jpg",Product=products[0]},
                    new Images(){ ImageName="product1.jpg",Product=products[0]},
                    new Images(){ ImageName="product1.jpg",Product=products[0]},
                    new Images(){ ImageName="product1.jpg",Product=products[0]},

                    new Images(){ ImageName="product2.jpg",Product=products[1]},
                    new Images(){ ImageName="product2.jpg",Product=products[1]},
                    new Images(){ ImageName="product2.jpg",Product=products[1]},
                    new Images(){ ImageName="product2.jpg",Product=products[1]},

                    new Images(){ ImageName="product3.jpg",Product=products[2]},
                    new Images(){ ImageName="product3.jpg",Product=products[2]},
                    new Images(){ ImageName="product3.jpg",Product=products[2]},
                    new Images(){ ImageName="product3.jpg",Product=products[2]},

                    new Images(){ ImageName="product4.jpg",Product=products[3]},
                    new Images(){ ImageName="product4.jpg",Product=products[3]},
                    new Images(){ ImageName="product4.jpg",Product=products[3]},
                    new Images(){ ImageName="product4.jpg",Product=products[3]},

                    new Images(){ ImageName="product5.jpg",Product=products[4]},
                    new Images(){ ImageName="product5.jpg",Product=products[4]},
                    new Images(){ ImageName="product5.jpg",Product=products[4]},
                    new Images(){ ImageName="product5.jpg",Product=products[4]}
                };
                context.Images.AddRange(images);


                var attributes = new[]
                {
                    new ProductAttribute(){Attribute="Display",Value="15.6",Product=products[0]},
                    new ProductAttribute(){Attribute="Processor",Value="Intel i7",Product=products[0]},
                    new ProductAttribute(){Attribute="Ram Memory",Value="15 GB",Product=products[0]},
                    new ProductAttribute(){Attribute="Hard Disk",Value="1 TB",Product=products[0]},
                    new ProductAttribute(){Attribute="Color",Value="Black",Product=products[0]},

                    new ProductAttribute(){Attribute="Display",Value="15.6",Product=products[1]},
                    new ProductAttribute(){Attribute="Processor",Value="Intel i7",Product=products[1]},
                    new ProductAttribute(){Attribute="Ram Memory",Value="15 GB",Product=products[1]},
                    new ProductAttribute(){Attribute="Hard Disk",Value="1 TB",Product=products[1]},
                    new ProductAttribute(){Attribute="Color",Value="Black",Product=products[1]},


                    new ProductAttribute(){Attribute="Display",Value="15.6",Product=products[2]},
                    new ProductAttribute(){Attribute="Processor",Value="Intel i7",Product=products[2]},
                    new ProductAttribute(){Attribute="Ram Memory",Value="15 GB",Product=products[2]},
                    new ProductAttribute(){Attribute="Hard Disk",Value="1 TB",Product=products[2]},
                    new ProductAttribute(){Attribute="Color",Value="Black",Product=products[2]},


                    new ProductAttribute(){Attribute="Display",Value="15.6",Product=products[3]},
                    new ProductAttribute(){Attribute="Processor",Value="Intel i7",Product=products[3]},
                    new ProductAttribute(){Attribute="Ram Memory",Value="15 GB",Product=products[3]},
                    new ProductAttribute(){Attribute="Hard Disk",Value="1 TB",Product=products[3]},
                    new ProductAttribute(){Attribute="Color",Value="Black",Product=products[3]},


                    new ProductAttribute(){Attribute="Display",Value="15.6",Product=products[4]},
                    new ProductAttribute(){Attribute="Processor",Value="Intel i7",Product=products[4]},
                    new ProductAttribute(){Attribute="Ram Memory",Value="15 GB",Product=products[4]},
                    new ProductAttribute(){Attribute="Hard Disk",Value="1 TB",Product=products[4]},
                    new ProductAttribute(){Attribute="Color",Value="Black",Product=products[4]}
                };
                context.Attributes.AddRange(attributes);
                context.SaveChanges();

            }
        }
    }
}
