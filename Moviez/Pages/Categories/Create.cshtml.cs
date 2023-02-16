using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Moviez.Data;
using Moviez.Model;

namespace Moviez.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public Category Category { get; set; }

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            await _context.Categories.AddAsync(Category);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
