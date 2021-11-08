using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kiblah.Models {
    public class ApplicationUser : IdentityUser {
        public string? NamaPenuh { get; set; }
        public string? NamaAkaun { get; set; }
        public DateTime DaftarPada { get; set; }
        public DateTime KemaskiniPada { get; set; }
        public string? Tag { get; set; }
        public bool IsActive { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
    }
}
