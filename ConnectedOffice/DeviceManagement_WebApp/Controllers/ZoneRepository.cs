using System.Collections.Generic;
using System.ComponentModel;

public class ZoneRepository
{
    private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();

    //GET: Products
    public List<Category> GetAll()
    {
        return _context.Category.ToList();
    }


}