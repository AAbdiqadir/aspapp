using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using aspnetcoreapp.Models;

namespace aspnetcoreapp.Pages;

public class ProductsModel : PageModel
{
    
    
    
    public readonly AppDataContext _db;
        
    public ProductsModel(AppDataContext db)
    {
        _db = db;
    }

    [BindProperty]
    public string search { get; set; }
    
    public IEnumerable<Product> products { get; set; }


    public void OnGet()
        {
            products = _db.Products.ToList();
        }
    
}