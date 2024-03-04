using System.Runtime.InteropServices.JavaScript;
using E_commerse_Model_Practice.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_commerse_Model_Practice.Controllers;

public class Ecommerce : Controller
{

    [Route("/order")]
    public IActionResult PostOrder(Order thisOrder)
    {
        if (ModelState.IsValid)
        {
            Random rnd = new Random();
            thisOrder.OrderNumber = rnd.Next(1, 99999);
            return Ok(thisOrder.OrderNumber);
        }
        else
        {
            return BadRequest(ModelState.Values);
        }
    }
}   