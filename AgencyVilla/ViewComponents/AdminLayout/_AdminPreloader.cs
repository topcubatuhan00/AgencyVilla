using Microsoft.AspNetCore.Mvc;

namespace AgencyVilla.ViewComponents.AdminLayout;

public class _AdminPreloader : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
