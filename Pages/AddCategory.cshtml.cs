using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
public class AddCategoryModel : PageModel
{
    public void OnGet() {}
    public IActionResult OnPost()
    {
        // Логика обработки
        return RedirectToPage("Index");
        { }
    }
}
