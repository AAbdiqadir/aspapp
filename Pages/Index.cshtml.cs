using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using aspnetcoreapp.Models;

namespace aspnetcoreapp.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public Product Products { get; set; }

    public readonly AppDataContext _db;

    public IndexModel(AppDataContext db)
        {
            _db = db;
        }
    
    public IActionResult OnPost()
        {

            _db.Products.Add(Products);
            _db.SaveChanges();
            return RedirectToPage("/Index");
        }
    public string Message { get; private set; } = "PageModel in C#";

    public void OnGet()
        {
            Message += $" Server time is { DateTime.Now }";
        }
    
}
