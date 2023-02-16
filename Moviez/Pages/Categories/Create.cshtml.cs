using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Moviez.Model;

namespace Moviez.Pages.Categories
{
    public class CreateModel : PageModel
    {
        public Category Category { get; set; }
        public void OnGet()
        {
        }
    }
}
