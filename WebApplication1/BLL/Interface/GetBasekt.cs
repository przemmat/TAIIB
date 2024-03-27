﻿using BLL.DTO.BasketPosition;
using BLL.DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface GetBasekt
    {
        public IEnumerable<BasketPositionResponseDTO> get(UserRequestDTO user);
    }
}
