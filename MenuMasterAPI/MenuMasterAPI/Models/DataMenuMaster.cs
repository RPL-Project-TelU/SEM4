using System;
using System.Collections.Generic;

namespace MenuMasterAPI.Models
{
    public partial class DataMenuMaster
    {
        public int IdUser { get; set; }
        public string? NamaUser { get; set; }
        public string? PasswordUser { get; set; }
        public string? ConfirmPassword { get; set; }
        public string? NamaAwal { get; set; }
        public string? NamaAkhir { get; set; }
        public string? Email { get; set; }
    }
}
