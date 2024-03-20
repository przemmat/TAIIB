﻿using BLL.DTO.product;
using BLL.DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    internal interface AddToBasket
    {
        public bool AddToBasket(ProductRequestDTO id, UserRequestDTO user);
    }
}
