using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model
{
    public class OrderPosition
    {
        public int Id { get; set; }
        public int OrderID { get; set; }
        public int Amount { get; set; }
        [Precision(10,2)]
        public decimal Price { get; set; }
        [ForeignKey(nameof(OrderID)),Required]
        public Order Order { get; set; }
    }
}
