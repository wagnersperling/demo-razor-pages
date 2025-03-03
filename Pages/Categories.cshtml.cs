using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages
{
    public class CategoriesModel : PageModel
    {
        public List<Category> Categories { get; set; } = new List<Category>();
        public void OnGet(int skip = 0, int take = 25)
        {
            var temp = new List<Category>();
            //await Task.Delay(5000);
            for (int i = 0; i <= 1999; i++)
            {
                temp.Add(
                    new Category(i,
                     $"Categoria {i}",
                     i * 18.95M)
                    );
            }
            Categories = temp.Skip(skip).Take(take).ToList();
        }
    }
    public record Category(
      int Id,
      string Title,
      decimal Price);
}
