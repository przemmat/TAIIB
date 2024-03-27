using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.DTO.product;
using BLL.Interface;
using WebApplication1;
using WebApplication1.Model;

namespace BLL_EF
{
    public class InterakcjaZProduktem : AddProduct, ActivateProduct, EditProduct, RemoveProduct

    {
        WebshopContext context= new WebshopContext();
        public bool Activate(ProductRequestDTO id,bool state=true)
        {
            var product = context.Products.First(x => x.Id == id.ProductID);
            if (product.IsActive == state) return false;
            product.IsActive= state; 
            context.SaveChanges();
            return true;
            
        }

        public bool add(ProductResponseDTO product)
        {if (product.Price <= 0) return false;
            var prdukt  = new Product { Image= product.Image, IsActive= product.IsActive, Name = product.Name , Price = product.Price };
            context.Products.Add(prdukt);
            context.SaveChanges();
            return true;
        }

        public bool edit(ProductRequestDTO id, ProductResponseDTO product)
        {if(product.Price <= 0) return false;
            var produkt = context.Products.First(x => x.Id == id.ProductID);
            produkt.IsActive = product.IsActive;
            produkt.Name = product.Name;
            produkt.Price = product.Price;
            produkt.Image = product.Image;
            context.SaveChanges();
            return true;
        }

        public bool remove(ProductRequestDTO product)
        {
            var produkt = context.Products.First(x => x.Id == product.ProductID);
            var Order = context.Orders.Where(x=>x.OrderPositions==context.OrderPositions.Where(x=>x.ProductID==product.ProductID));
            foreach (var order in Order)
                if (order.Oplacone != true)
                    return false;
            var BasketPosition = context.BasketPositions;
            if (BasketPosition.Any(x => x.ProductID == product.ProductID)) return false;
            if (Order.Any() ) { Activate(product, false);
                return false;
            }
            context.Products.Remove(produkt);
                 context.SaveChanges();
            return true;

        }
    }
}
