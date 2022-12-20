using Microsoft.AspNetCore.Mvc;
using ViewComponentApp.Model;

namespace ViewComponentApp.ViewComponents
{
    public class GridViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync (PersonGridModel grid)
        {
            return View("Sample", grid);
        }
    }
}
