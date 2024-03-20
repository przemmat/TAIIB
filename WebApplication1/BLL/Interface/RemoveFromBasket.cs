using BLL.DTO.product;
using BLL.DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    internal interface RemoveFromBasket
    {
        public bool RemoveFromBasket(ProductRequestDTO product, UserRequestDTO user);
    }
}
