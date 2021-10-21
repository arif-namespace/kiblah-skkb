using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kiblah.Models
{
    public class Pendaftaran : AuditModel {
        [Display(Name = "Kod : ")]
        public string? Kod { get; set; }

        [Display(Name ="Pusat Pengajian : ")]
        public string? Pusat { get; set; }

        [Required(ErrorMessage ="Masukkan Nama Anda")]
        [Display(Name = "Nama Pelajar : ")]
        public string? NamaPelajar { get; set; }

        [Required(ErrorMessage = "Masukkan Kad Pengenalan Atau No Passport Anda")]
        [Display(Name = "Kad Pengenalan / No Passort (Luar Negara ) : ")]
        public string? KadPengenalan { get; set; }

        [Required(ErrorMessage ="Sila Masukkan Umur Pada Tahun 2022")]
        [Display(Name = "Umur Pada Tahun 2022 : ")]
        [MaxLength(2)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya Digit Sahaja DiBenarkan")]
        public string? Umur { get; set; }

        [Required(ErrorMessage = "Masukkan Email")]
        [Display(Name = "Email : ")]
        [EmailAddress(ErrorMessage ="Format Email Tidak Sah")]
        public string? Email { get; set; }

        [Required(ErrorMessage ="Masukkan Nombor Telefon Anda")]
        [Display(Name = "No Telefon : ")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya Digit Sahaja DiBenarkan")]
        public string? NoTelefon { get; set; }

        [Required(ErrorMessage = "Masukkan Nama Bapa / Penjaga")]
        [Display(Name = "Nama Bapa / Penjaga : ")]
        public string? NamaBapa { get; set; }

        [Required(ErrorMessage = "Masukkan Nama Ibu / Penjaga")]
        [Display(Name = "Nama Ibu / Penjaga : ")]
        public string? NamaIbu { get; set; }

        [Required(ErrorMessage = "Masukkan Email Bapa / Penjaga")]
        [EmailAddress(ErrorMessage = "Format Email Tidak Sah")]
        [Display(Name = "Email Bapa : ")]
        public string? EmailBapa { get; set; }

        [Required(ErrorMessage = "Masukkan Email Ibu / Penjaga")]
        [EmailAddress(ErrorMessage = "Format Email Tidak Sah")]
        [Display(Name = "Email Ibu : ")]
        public string? EmailIbu { get; set; }

        [Required(ErrorMessage ="No Telefon Bapa / Penjaga DiPerlukan")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya Digit Sahaja DiBenarkan")]
        [Display(Name = "Nombor Telefon Bapa : ")]
        public string? NoTelefonBapa { get; set; }

        [Required(ErrorMessage ="No Telefon Ibu / Penjaga DiPerlukan")]
        [Display(Name = "Nombor Telefon Ibu : ")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya Digit Sahaja DiBenarkan")]
        public string? NoTelefonIbu { get; set; }

        [Required(ErrorMessage ="Sila Pilih Kursus")]
        [Display(Name = "Kursus Yang Ingin DiPohon : ")]
        public string? KursusDiPohon { get; set; }

        [Required(ErrorMessage ="Pilih Sumber Maklumat")]
        [Display(Name = "Sumber Maklumat Mengenai Kumpulan KIBLAH : ")]
        public string? SumberMaklumat { get; set; }

        [Required(ErrorMessage ="Maklumat Ini DiPerlukan")]
        [Display(Name = "Saya Memilih KIBLAH Kerana..")]
        public string? MemilihKblah { get; set; }
    }
}
