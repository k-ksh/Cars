using hobbies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace hobbies.Pages
{
   // [HttpGet("Hobby")]
    public class HobbyModel : PageModel
    {
        public List<Hobby>? Hobby { get; private set; }

        public void OnGet()
        {
            // Populate the Hobbies list with your hobbies
            Hobby = new List<Hobby>
        {
            new Hobby { Name = "Hobby 1", Description = "Painting" },
            new Hobby { Name = "Hobby 2", Description = "Travel" },
            // Add more hobbies as needed
        };
        }
    }
}



