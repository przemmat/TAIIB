﻿using BLL.DTO;
using BLL.DTO.product;
using BLL.Interface;
using WebApplication1;

namespace BLL_EF
{
    
    public class ProductGets : GetProductsASCDSC, GetProductsIsActive, GetProductsName, GetProductsStronnicowo
    {
        public WebshopContext context = new WebshopContext();
        public IEnumerable<ProductResponseDTO> get(bool ascending)
        {
            var tmp = context.Products;
            if (!ascending)
                tmp.OrderByDescending(x => x.Name);
            else tmp.OrderBy(x => x.Name);
            List<ProductResponseDTO> list = tmp.Select(p=>new ProductResponseDTO {ID=p.Id, Name = p.Name, Price=p.Price, Image = p.Image, IsActive = p.IsActive}).ToList();
            return list;
           
        }

        public IEnumerable<ProductResponseDTO> getPoNazwie(string name)
        {
            var tmp = context.Products.Where(x=>x.Name == name);
            List<ProductResponseDTO> list = tmp.Select(p=>new ProductResponseDTO { ID = p.Id, Name = p.Name, Price = p.Price, Image = p.Image, IsActive = p.IsActive }).ToList();
            return list;
        }

        public IEnumerable<ProductResponseDTO> getStronnicowo(int strona = 0)
        {
            var tmp = context.Products.OrderBy(x=>x.Name).Skip(20*strona).Take(20);
            List<ProductResponseDTO> list = tmp.Select(p => new ProductResponseDTO { ID = p.Id, Name = p.Name, Price = p.Price, Image = p.Image, IsActive = p.IsActive }).ToList();
            return list;
        }

        public IEnumerable<ProductResponseDTO> getactive(bool IsActive = true)
        {
            var tmp = context.Products.Where((x)=>x.IsActive==IsActive).OrderBy(x=>x.Name);
            List<ProductResponseDTO> list = tmp.Select(p => new ProductResponseDTO { ID = p.Id, Name = p.Name, Price = p.Price, Image = p.Image, IsActive = p.IsActive }).ToList();
            return list;
        }
    }
}