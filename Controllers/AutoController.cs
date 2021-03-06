using Microsoft.AspNetCore.Mvc;
using FisherInsurance.Models;
using System;

public class AutoController : Controller

{
    public IActionResult Index()

    {
        //return Ok("This is the index of the AutoController");

        return View();
    }

    public IActionResult Quote()
    {   
        Quote quote = new Quote
      {
           Id = 345,
           Product = "Auto Insurance",
           ExpireDate = DateTime.Now.AddDays(45),
           Price = 45.00M
      };

        //return Ok("This is the quote of the AutoController");

        return View(quote);

    }

}