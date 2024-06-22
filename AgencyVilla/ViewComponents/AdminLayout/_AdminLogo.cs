using Microsoft.AspNetCore.Mvc;

namespace AgencyVilla.ViewComponents.AdminLayout;

public class _AdminLogo : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
