using kiblah.Models;
using kiblah_skkb.Data;
using kiblah_skkb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace kiblah_skkb.Pages.borang
{
    public class BorangPendaftaranMuridModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public BorangPendaftaranMuridModel(ApplicationDbContext context) {
            _context = context;
        }

        public SelectList NegeriList { get; set; }

        public async Task<IActionResult> OnGet() {
            NegeriList = new SelectList(_context.Negeri, nameof(Negeri.NamaNegeri), nameof(Negeri.NamaNegeri));
            return Page();
        }
      
        [BindProperty]
        public Pendaftaran Pendaftaran { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                NegeriList = new SelectList(_context.Negeri, nameof(Negeri.NamaNegeri), nameof(Negeri.NamaNegeri));

                return Page();
            }

            NegeriList = new SelectList(_context.Negeri, nameof(Negeri.NamaNegeri), nameof(Negeri.NamaNegeri));

            var validateRecords = await _context.Pendaftarans.AnyAsync(a => a.KadPengenalan == Pendaftaran.KadPengenalan);

            if (validateRecords) {
                ViewData["error"] = $"Terdapat Rekod Pendaftaran Untuk : {Pendaftaran.KadPengenalan}";
                return Page();
            }
            Pendaftaran.Kod = "SKKB";
            Pendaftaran.Pusat = "SRI KIBLAH KOTA BHARU";
            Pendaftaran.Email = Pendaftaran.Email.ToLower();
            Pendaftaran.EmailBapa = Pendaftaran.EmailBapa.ToLower();
            Pendaftaran.EmailIbu = Pendaftaran.EmailIbu.ToLower();
            Pendaftaran.DaftarPada = DateTime.Now;
            Pendaftaran.DaftarOleh = Pendaftaran.KadPengenalan;
            Pendaftaran.IsActive = true;

            _context.Pendaftarans.Add(Pendaftaran);
            await _context.SaveChangesAsync();

            return RedirectToPage("./MaklumatPendaftaran", new { id = Pendaftaran.Id });
        }
    
}
}
