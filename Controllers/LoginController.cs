using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using TestePaulo.Models;
using TestePaulo.Repository;
using TestePaulo.Repository.Interfaces;

namespace TestePaulo.Controllers;

[Produces("application/json")]
[Route("api/[controller]")]
[ApiController]
public class LoginController : Controller
{
    private readonly IUserRepository _iUserRepository;

    public LoginController(IUserRepository iUserRepository)
    {
        _iUserRepository = iUserRepository;
    }

    [HttpPost]
    public IActionResult Login(User login)
    {
        try
        {
            User userFinded = _iUserRepository.Login(login.Username, login.Senha);

            if (userFinded == null)
            {
                return Unauthorized("Email e/ou senha invalidos");
            }
            else
            {
                return Ok();
            }




        }
        catch (Exception e)
        {

            throw new Exception();
        }
    }
}