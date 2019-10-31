using System;
using System.Collections.Generic;

namespace oms.Models
{
    public partial class Customer
    {
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string CustEmail { get; set; }
        public string CustContactNo { get; set; }
        public string CustWhatsapp { get; set; }
        public string CustAddress { get; set; }
        public string CustCompany { get; set; }
        public int? AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
