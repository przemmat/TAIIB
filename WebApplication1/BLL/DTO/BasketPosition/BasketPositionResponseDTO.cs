﻿using BLL.DTO.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.BasketPosition
{
    public class BasketPositionResponseDTO
    {

        public int Amount { get; init; }
        public ProductResponseDTO Product { get; init; }
    }
}
