using System.ComponentModel.DataAnnotations;

namespace E_commerse_Model_Practice.Models;

public class Orders
{
    [Range(minimum:1, maximum:99999, ErrorMessage = "Order Number Out Of Range (1-99999)")]
    public int? OrderNumber { get; set; }
    public DateTime OrderDate { get; set; }
    public List<Product> ListOfProducts { get; set; }
    public double InvoicePrice { get; set; }
}