using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kiblah.Models {
    public class AuditModel : DefaultId {
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy hh:mm:ss tt}")]
        public DateTime DaftarPada { get; set; }
        public string DaftarOleh { get; set; }
        public DateTime KemaskiniPada { get; set; }
        public string KemaskiniOleh { get; set; }
        public string Tag { get; set; }
        public bool IsActive { get; set; }
    }
}
