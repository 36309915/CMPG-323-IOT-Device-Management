using System.Collections.Generic;
using System.ComponentModel;

public class DevicesRepository {
	private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();

	//GET: Products
	public List<Devices> GetAll() 
	{
		return _context.Devices.ToList();
	}

	public List<Devices> GetById()
	{
		return _context.Devices.ToList();
	}


}