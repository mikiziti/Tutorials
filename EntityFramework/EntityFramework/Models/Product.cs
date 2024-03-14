using System.ComponentModel.DataAnnotations.Schema;


namespace EntityFramework.Models
{
    public class Product
    {
        public int Id { get; set; }  // Primary Key in the generated database table
        public string Name { get; set; } = null!;

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
    }
}
