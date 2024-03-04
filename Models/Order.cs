using System.ComponentModel.DataAnnotations;

namespace E_commerse_Model_Practice.Models;

public class Order
{
    [Range(minimum:1, maximum:99999, ErrorMessage = "Order Number Out Of Range (1-99999)")]
    public int? OrderNumber { get; set; }
    [Required]
    public DateTime OrderDate { get; set; }
    [Required]
    public List<Product> Products { get; set; }
    [Required]
    public double InvoicePrice { get; set; }
}