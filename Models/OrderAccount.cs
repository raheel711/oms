using System;
using System.Collections.Generic;

namespace oms.Models
{
    public partial class OrderAccount
    {
        public int OrderAccountId { get; set; }
        public int OrderId { get; set; }
        public string Type { get; set; }
        public double ReceviedAmount { get; set; }
        public int? AmountTakenBy { get; set; }
        public string Detail { get; set; }
        public bool? Status { get; set; }
        public int? AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
        public int? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
