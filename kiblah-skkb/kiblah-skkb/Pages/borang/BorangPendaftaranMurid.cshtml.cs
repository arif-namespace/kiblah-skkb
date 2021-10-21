using kiblah.Models;
using kiblah_skkb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace kiblah_skkb.Pages.borang
{
    public class BorangPendaftaranMuridModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public BorangPendaftaranMuridModel(ApplicationDbContext context) {
            _context = context;
        }

        public void OnGet() {
        }

        [BindProperty]
        public Pendaftaran Pendaftaran { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

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
