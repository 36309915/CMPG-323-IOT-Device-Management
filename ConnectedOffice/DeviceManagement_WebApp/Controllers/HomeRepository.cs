using System.Collections.Generic;
using System.ComponentModel;

public class HomeRepository
{
    private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();

    //GET: Products
    public List<Category> GetAll()
    {
        return _context.Category.ToList();
    }


}