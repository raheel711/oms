using System;
using System.Collections.Generic;

namespace oms.Models
{
    public partial class PartnerAccount
    {
        public int PartnerAccountId { get; set; }
        public int OrderAccountId { get; set; }
        public int? AmountGivenBy { get; set; }
        public double? Amount { get; set; }
        public DateTime? ReceivedAcceptDate { get; set; }
        public int? AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
    }
}
