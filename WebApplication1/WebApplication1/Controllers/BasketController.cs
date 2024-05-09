using BLL.DTO.BasketPosition;
using BLL.DTO.product;
using BLL.DTO.User;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_EF.Controllers
{

    [ApiController]
    [Route("/api/[controller]")]
    public class BasketController : ControllerBase
    {
        readonly InterakcjaZKoszykiem interakcjaZKoszykiem;
        public BasketController(InterakcjaZKoszykiem interakcjaZKoszykiem)
        {
            this.interakcjaZKoszykiem = interakcjaZKoszykiem;
        }
        [HttpPost]
        [Route("/add")]
        public bool Post([FromQuery] ProductRequestDTO id,[FromQuery] UserRequestDTO user)
        {
            return interakcjaZKoszykiem.AddToBasket(id, user);
        }
        [HttpPost]
        [Route("/change/{amount}")]
        public bool Change([FromQuery] ProductRequestDTO id, [FromQuery] UserRequestDTO user, [FromRoute] int amount)
        {
        return    interakcjaZKoszykiem.ChangeAmount(id, user,amount);
        }
        [HttpGet]
      
        public IEnumerable<BasketPositionResponseDTO> getuser(  UserRequestDTO user)
        {
            return interakcjaZKoszykiem.get(user);
        }
        [HttpDelete]
        public bool remove([FromQuery] UserRequestDTO user, [FromQuery] ProductRequestDTO product)
        {
            return interakcjaZKoszykiem.RemoveFromBasket(product,user);
        }
    }
}
