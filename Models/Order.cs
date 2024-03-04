using System.ComponentModel.DataAnnotations;

namespace E_commerse_Model_Practice.Models;

public class Order : IValidatableObject
{
    [Range(minimum:1, maximum:99999, ErrorMessage = "Order Number Out Of Range (1-99999)")]
    public int? OrderNumber { get; set; }
    [Required(ErrorMessage = "Order date can't be blank.")]
    public DateTime OrderDate { get; set; }
    [Required(ErrorMessage = "Must have at least one product in your list of products.")]
    public List<Product> Products { get; set; }
    [Required(ErrorMessage = "Invoice price cannot be blank.")]
    public double InvoicePrice { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        double sumOfProducts = 0;
        
        foreach(var product in Products)
        {
            sumOfProducts += product.Price;
        }

        if (InvoicePrice != sumOfProducts)
        {
            yield return new ValidationResult("Invoice price does not match sum of products price.");
        }
    }
}