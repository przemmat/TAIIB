using BLL.DTO.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    internal interface GetAllOrders
    {
        public IEnumerable<OrderResponseDTO> get();
    }
}
