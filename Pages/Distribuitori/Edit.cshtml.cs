using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proiect_Bota_Rodica.Data;
using Proiect_Bota_Rodica.Models;

namespace Proiect_Bota_Rodica.Pages.Distribuitori
{
    public class EditModel : PageModel
    {
        private readonly Proiect_Bota_Rodica.Data.Proiect_Bota_RodicaContext _context;

        public EditModel(Proiect_Bota_Rodica.Data.Proiect_Bota_RodicaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Distribuitor Distribuitor { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Distribuitor == null)
            {
                return NotFound();
            }

            var distribuitor =  await _context.Distribuitor.FirstOrDefaultAsync(m => m.ID == id);
            if (distribuitor == null)
            {
                return NotFound();
            }
            Distribuitor = distribuitor;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Distribuitor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DistribuitorExists(Distribuitor.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DistribuitorExists(int id)
        {
          return (_context.Distribuitor?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
