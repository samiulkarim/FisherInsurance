using Microsoft.AspNetCore.Mvc;

public class HouseController : Controller

{
    public IActionResult Index()

    {
        //return Ok("This is the index of the HouseController");
        
        return View();
    }

    public IActionResult Quote()

    {
        //return Ok("This is the quote of the HouseController");

        return View();
    }
    
}