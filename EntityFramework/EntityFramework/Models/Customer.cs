namespace EntityFramework.Models
{
    public class Customer
    {
        public int Id { get; set; }  // Primary Key in the generated database table
        public string FirstName { get; set; } = null!; // Not null
        public string LastName { get; set; } = null!; // Not null
        public string? Address { get; set; } // Nullable
        public string? Phone { get; set; } // Nullable

        public string? Email { get; set; } // Nullable
        public ICollection<Order> Orders { get; set; } = null!; // a customer can have many orders
    }
}
