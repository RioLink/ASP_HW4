namespace ASP_HW4.Pages
{
    using ASP_HW4.Models;
    using Microsoft.AspNetCore.Mvc.RazorPages;

    public class ProfileModel : PageModel
    {
        public User CurrentUser { get; set; } = new User
        {
            Id = 1,
            Name = "Іван Петренко",
            Email = "ivan@example.com",
            AvatarUrl = "/images/avatar1.png"
        };

        public void OnGet()
        {
        }
    }
}
