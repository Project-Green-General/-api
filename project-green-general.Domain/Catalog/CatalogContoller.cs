using Microsoft.AspNetCore.Mvc;
using project.green.general.Domain.Catalog;

namespace project.green.general.Api.Controllers
{
[ApiController]
[Route("controller")]
public class CatalogController : ControllerBase
{

}

   
}

[HttpGet]
public IActionResult GetItems()
{
    return Ok("hello world.")
}