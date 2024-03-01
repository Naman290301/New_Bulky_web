using BulkyWebRazor.Data;
using Microsoft.AspNetCore.Mvc;
using BulkyWebRazor.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public List<Category> CategoryList { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            CategoryList=_db.Categories.ToList();

        }
    }
}
