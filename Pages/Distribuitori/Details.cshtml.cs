using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Bota_Rodica.Data;
using Proiect_Bota_Rodica.Models;

namespace Proiect_Bota_Rodica.Pages.Distribuitori
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect_Bota_Rodica.Data.Proiect_Bota_RodicaContext _context;

        public DetailsModel(Proiect_Bota_Rodica.Data.Proiect_Bota_RodicaContext context)
        {
            _context = context;
        }

      public Distribuitor Distribuitor { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Distribuitor == null)
            {
                return NotFound();
            }

            var distribuitor = await _context.Distribuitor.FirstOrDefaultAsync(m => m.ID == id);
            if (distribuitor == null)
            {
                return NotFound();
            }
            else 
            {
                Distribuitor = distribuitor;
            }
            return Page();
        }
    }
}
