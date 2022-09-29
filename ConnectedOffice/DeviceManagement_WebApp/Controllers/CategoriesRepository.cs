using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Permissions;

public class CategoriesRepository {
	private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();

	//GET: Products
	public List<Category> GetAll() 
	{
		return _context.Category.ToList();
	}

	public Category GetById(int CategoryID) 
	{
		return _context.Category.Find(CategoryID);
	}

	public void Insert(Category category)
	{
		category.CreateDate = DateTime.Now;
		_context.Category.Add(category);
	}

	public void Update(Category category)
	{
		category.ModifiedDate = DateTime.Now;
		_context.Entry(category).State = EntityState.Modified;
	}

	public void Delete(int CategoryID)
	{
		Category category = _context.Category.Find(CategoryID);
		_context.Category.Remove(category);
	}


}