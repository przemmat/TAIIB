using BLL.DTO.product;
using BLL_EF;
using Microsoft.AspNetCore.Mvc;

namespace DAL.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProductsController : ControllerBase
    {
      readonly  InterakcjaZProduktem interakcjaZProduktem;
        readonly ProductGets productGets;
        public ProductsController(InterakcjaZProduktem interakcjaZProduktem,ProductGets productGets)
        {
            this.interakcjaZProduktem = interakcjaZProduktem;
            this.productGets = productGets;
        }

        [HttpPost]
        [Route("/{state}")]
        public bool activate([FromQuery] ProductRequestDTO id, bool state)
        {
         return   interakcjaZProduktem.Activate(id, state);
        }
        [HttpPost]
        [Route("/product/add")]
        public bool add([FromQuery] ProductResponseDTO product)
        {
            return interakcjaZProduktem.add(product);
        }
        [HttpPost]
        public bool edit([FromQuery]ProductRequestDTO product, [FromQuery] ProductResponseDTO productResponseDTO) {

            return interakcjaZProduktem.edit(product, productResponseDTO);
        }
        [HttpDelete]
        public bool remove([FromQuery]ProductRequestDTO id)
        {
            return interakcjaZProduktem.remove(id);
        }
        [HttpGet]
        [Route("/asc/{ascending}")]
        public IEnumerable<ProductResponseDTO> get([FromRoute] bool ascending)
        {
            return productGets.get(ascending);
        }
        [HttpGet]
        [Route("/name/{name}")]
        public IEnumerable<ProductResponseDTO> gegetPoNazwiet([FromRoute] string name)
        {
            return productGets.getPoNazwie(name);
        }
        [HttpGet]
        [Route("/strona/{strona}")]
        public IEnumerable<ProductResponseDTO> getStronnicowo([FromRoute] int strona)
        {
            return productGets.getStronnicowo(strona);
        }
        [HttpGet]
        [Route("/state/{state}")]
        public IEnumerable<ProductResponseDTO> getactive([FromRoute] bool state)
        {
            return productGets.getactive(state);
        }

    }
}
