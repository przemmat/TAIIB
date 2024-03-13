using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey(nameof(UserID))]
        public User? User { get; set; }
        public IEnumerable<OrderPosition> OrderPositions { get; set; }
    }
}
