using Microsoft.AspNetCore.Mvc;
using TestePaulo.Repository;

namespace TestePaulo.Controllers;

[Produces("application/json")]
[Route("api/[controller]")]
[ApiController]

public class ItemController : Controller
{
    private readonly ItemRepository _itemRepository;

    public ItemController(ItemRepository itemRepository)
    {
        _itemRepository = itemRepository;
    }

    [HttpGet]
    public IActionResult List()
    {
        try
        {
            return Ok(_itemRepository.List());
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

}