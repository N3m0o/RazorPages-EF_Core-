using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Model;

namespace WebApplication1.Pages.MyNotes
{
    public class Note_Delite : PageModel
    {
        private readonly NotesDbContext _context;

        public Note_Delite(NotesDbContext context)
        {
            _context = context;
        }
       public Note Note { get; set; } 

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Note.Remove(Note);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}
