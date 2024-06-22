using Microsoft.AspNetCore.Mvc;

namespace AgencyVilla.ViewComponents.AdminLayout;

public class _AdminScripts : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
