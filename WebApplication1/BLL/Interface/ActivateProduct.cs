using BLL.DTO.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    internal interface ActivateProduct
    {
        public bool Activate(ProductRequestDTO id);
    }
}
