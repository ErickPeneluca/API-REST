using TestePaulo.Data;
using TestePaulo.Models;

namespace TestePaulo.Repository;

public class ItemRepository
{
    private readonly Context _context;

    public ItemRepository(Context context)
    {
        _context = context;
    }

    public List<Item> List()
    {
        return _context.Items.ToList();
    }
}