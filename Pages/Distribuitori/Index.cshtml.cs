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
    public class IndexModel : PageModel
    {
        private readonly Proiect_Bota_Rodica.Data.Proiect_Bota_RodicaContext _context;

        public IndexModel(Proiect_Bota_Rodica.Data.Proiect_Bota_RodicaContext context)
        {
            _context = context;
        }

        public IList<Distribuitor> Distribuitor { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Distribuitor != null)
            {
                Distribuitor = await _context.Distribuitor.ToListAsync();
            }
        }
    }
}
