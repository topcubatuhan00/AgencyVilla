using Microsoft.AspNetCore.Mvc;

namespace AgencyVilla.ViewComponents.AdminLayout;

public class _AdminNavbar : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
