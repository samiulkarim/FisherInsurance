using Microsoft.AspNetCore.Mvc;
using FisherInsurance.Models;
using System;

public class HouseController : Controller

{

    [RouteAttribute("home")]   
    public IActionResult Index()

    {
        //return Ok("This is the index of the HouseController");
        
        return View();
    }

     [RouteAttribute("home/quote")]
    public IActionResult Quote()
    { 
        Quote quote = new Quote
            {
                Id = 345,
                Product = "Home Insurance",
                ExpireDate = DateTime.Now.AddDays(45), 
                Price = 45.00M 
            }; 

        //return Ok("This is the quote of the HouseController");

        return View(quote);
    }
    
}