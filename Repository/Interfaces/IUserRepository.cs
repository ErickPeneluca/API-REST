using TestePaulo.Models;

namespace TestePaulo.Repository.Interfaces;

public interface IUserRepository
{
    User Login(string username, string senha);
}