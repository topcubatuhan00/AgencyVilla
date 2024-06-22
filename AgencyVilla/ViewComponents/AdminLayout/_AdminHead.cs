using Microsoft.AspNetCore.Mvc;

namespace AgencyVilla.ViewComponents.AdminLayout;

public class _AdminHead : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
