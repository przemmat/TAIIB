using BLL.DTO.BasketPosition;
using BLL.DTO.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.User
{
    internal class UserResponseDTO
    {
        public IEnumerable<BasketPositionResponseDTO> BasketPositions { get; init; }
        public IEnumerable<OrderResponseDTO> Orders { get; init; }
        public bool IsActive { get; init; }
    }
}
