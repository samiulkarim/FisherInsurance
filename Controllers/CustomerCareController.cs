using Microsoft.AspNetCore.Mvc;

[Route("customer")]


public class CustomerCareController : Controller

{
    public IActionResult Index()

    {
        return Ok("This is the index of the CustomerCareController");
    }

    [RouteAttribute("fileclaim")]


    public IActionResult NewClaim()

    {
        return Ok("This is the new claim of the CustomerCareController");
    }

    [RouteAttribute("myclaims")]

    public IActionResult ClaimHistory()

    {
        return Ok("This is the claim history of the CustomerCareController");
    }
    

}