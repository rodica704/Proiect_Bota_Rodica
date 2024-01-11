using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Bota_Rodica.Data;
using Proiect_Bota_Rodica.Models;

namespace Proiect_Bota_Rodica.Pages.Produse
{
    public class IndexModel : PageModel
    {
        private readonly Proiect_Bota_Rodica.Data.Proiect_Bota_RodicaContext _context;

        public IndexModel(Proiect_Bota_Rodica.Data.Proiect_Bota_RodicaContext context)
        {
            _context = context;
        }

        public IList<Produs> Produs { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Produs != null)
            {
                Produs = await _context.Produs.ToListAsync();
            }
        }
    }
}
