namespace E_commerse_Model_Practice.Models;

public class Orders
{
    public int? OrderNumber { get; set; }
    public DateTime OrderDate { get; set; }
    public List<Product> ListOfProducts { get; set; }
    public double InvoicePrice { get; set; }
}