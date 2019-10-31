using System;
using System.Collections.Generic;

namespace oms.Models
{
    public partial class Partner
    {
        public int PartnerId { get; set; }
        public string PartnerName { get; set; }
        public string ContactNo { get; set; }
        public string PartnerEmail { get; set; }
        public string PartnerDetail { get; set; }
        public bool? PartnerStatus { get; set; }
        public string SuRoles { get; set; }
        public string SuUsername { get; set; }
        public string SuPassword { get; set; }
        public bool? SuStatus { get; set; }
    }
}
