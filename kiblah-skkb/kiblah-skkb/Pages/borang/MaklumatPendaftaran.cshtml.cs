using kiblah.Models;
using kiblah_skkb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace kiblah_skkb.Pages.borang
{
    public class MaklumatPendaftaranModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public MaklumatPendaftaranModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Pendaftaran Pendaftaran { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pendaftaran = await _context.Pendaftarans.FirstOrDefaultAsync(m => m.Id == id);

            if (Pendaftaran == null)
            {
                return NotFound();
            }
            return Page();
        }

    }
}
