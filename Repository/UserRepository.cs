using TestePaulo.Data;
using TestePaulo.Models;
using TestePaulo.Repository.Interfaces;

namespace TestePaulo.Repository;

public class UserRepository : IUserRepository
{
    private readonly Context _context;

    public UserRepository(Context context)
    {
        _context = context;
    }
    
    
    public User Login(string username, string senha)
    {
        return _context.Users.FirstOrDefault(user => user.Username == username && user.Senha == senha);
    }
}