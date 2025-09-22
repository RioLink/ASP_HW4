using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_HW4.Pages.Admin
{
    public class DashboardModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Title"] = "Dashboard";
        }
    }
}
