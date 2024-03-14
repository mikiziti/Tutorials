namespace EntityFramework.Models
{
    public class Order
    {
        public int Id { get; set; }  // Primary Key in the generated database table

        public DateTime OrderPlaced { get; set; } //nullable
        public DateTime? OrderFulfilled { get; set; } //nullable
        public int CustomerId { get; set; }  // Foreign Key in the generated database table
  
        public Customer Customer { get; set; } = null!;

        public ICollection<OrderDetail>OrderDetails { get; set; } = null!; // an order can have many order details
    }
}