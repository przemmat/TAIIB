﻿using BLL.DTO.OrderPosition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.Order
{
    internal class OrderResponseDTO
    {
        public DateTime Date { get; init; }
        public IEnumerable<OrderPositionResponseDTO> OrderPositions { get; init; }
    }
}
