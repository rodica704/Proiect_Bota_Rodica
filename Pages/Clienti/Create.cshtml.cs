using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect_Bota_Rodica.Data;
using Proiect_Bota_Rodica.Models;

namespace Proiect_Bota_Rodica.Pages.Clienti
{
    public class CreateModel : PageModel
    {
        private readonly Proiect_Bota_Rodica.Data.Proiect_Bota_RodicaContext _context;

        public CreateModel(Proiect_Bota_Rodica.Data.Proiect_Bota_RodicaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Client Client { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Client == null || Client == null)
            {
                return Page();
            }

            _context.Client.Add(Client);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
