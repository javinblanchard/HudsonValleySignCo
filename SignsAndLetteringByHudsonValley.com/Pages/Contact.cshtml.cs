using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace SignsAndLetteringByHudsonValley.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Please enter a valid email.")]
        [EmailAddress]
        public string Email { get; set; }

        [BindProperty]
        [Phone(ErrorMessage = "Please enter a valid phone number.")]
        public string Phone { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Please enter a message.")]
        public string Message { get; set; }

        public bool IsSubmitted { get; set; }

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Process the form: save to DB, send email, etc.
            IsSubmitted = true;

            // Clear the fields (optional)
            ModelState.Clear();

            return Page();
        }
    }
}


