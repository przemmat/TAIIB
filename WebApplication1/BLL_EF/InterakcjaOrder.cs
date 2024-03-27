using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BLL;
using BLL.DTO.Order;
using BLL.DTO.OrderPosition;
using BLL.DTO.product;
using BLL.DTO.User;
using BLL.Interface;
using Microsoft.EntityFrameworkCore;
using WebApplication1;

namespace BLL_EF
{
    internal class InterakcjaOrder : GetAllUserOrders, GetAllOrders, CreateOrder
    {
        private WebshopContext context = new WebshopContext();
        public OrderResponseDTO createOrder(UserRequestDTO user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderResponseDTO> get(UserRequestDTO user)
        {
           
        }

        public IEnumerable<OrderResponseDTO> get()
        {
            var or = context.Orders;
           
            }
    }
}
