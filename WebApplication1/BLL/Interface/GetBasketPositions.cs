using BLL.DTO.BasketPosition;
using BLL.DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    internal interface GetBasketPositions
    {
        public IEnumerable<BasketPositionResponseDTO> get(UserRequestDTO user);
    }
}
