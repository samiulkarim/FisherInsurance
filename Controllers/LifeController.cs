using Microsoft.AspNetCore.Mvc;
using FisherInsurance.Models;
using System;

public class LifeController : Controller

{
    public IActionResult Index()

    {
        //return Ok("This is the index of the LifeController");

        return View();
    }

public IActionResult Quote()

    { 
        Quote quote = new Quote
            {
                Id = 345,
                Product = "Life Insurance",
                ExpireDate = DateTime.Now.AddDays(45), 
                Price = 45.00M 
            };
           
        //return Ok("This is the quote of the LifeController");

        return View(quote);     
    }
}