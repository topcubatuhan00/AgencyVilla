using Microsoft.AspNetCore.Mvc;

namespace AgencyVilla.ViewComponents.AdminLayout;

public class _AdminSidebar : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
