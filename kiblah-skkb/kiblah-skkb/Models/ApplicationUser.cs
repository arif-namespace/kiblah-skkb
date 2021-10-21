using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kiblah.Models {
    public class ApplicationUser : IdentityUser {
        public DateTime DaftarPada { get; set; }
        public DateTime KemaskiniPada { get; set; }
        public string Tag { get; set; }
        public bool IsActive { get; set; }
    }
}
