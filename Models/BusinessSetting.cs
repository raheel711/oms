using System;
using System.Collections.Generic;

namespace oms.Models
{
    public partial class BusinessSetting
    {
        public int Id { get; set; }
        public string BusinessName { get; set; }
        public string BusinessSlogon { get; set; }
        public string LogoUrl { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string ReturnPolicy { get; set; }
        public string TermsConditions { get; set; }
    }
}
