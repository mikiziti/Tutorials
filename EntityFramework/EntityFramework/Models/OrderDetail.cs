namespace EntityFramework.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
         // Primary Key in the generated database table
         public int Quantity { get; set; }
        public int ProductId { get; set; } // Foreign Key in the generated database table
        public int OrderId { get; set; } // Foreign Key in the generated database table
        public Product Product { get; set; } = null!;
        public Order Order { get; set; } = null!;
    }   
}