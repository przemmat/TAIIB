using BLL.DTO.Order;
using BLL.DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    internal interface CreateOrder
    {
        public OrderResponseDTO createOrder(UserRequestDTO user);
    }
}
