using Microsoft.AspNetCore.Mvc;
using Olympus.Commerce.Product.Services;

namespace Olympus.Commerce.Product.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : Controller
{
    private readonly IProductService _service;

    public ProductsController(IProductService service)
    {
        _service = service;
    }

    public IActionResult Get()
    {
        return Ok();
    }
}
