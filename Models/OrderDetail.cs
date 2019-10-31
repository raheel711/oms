using System;
using System.Collections.Generic;

namespace oms.Models
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public string Type { get; set; }
        public int ProductId { get; set; }
        public int CustQty { get; set; }
        public double? CustPrice { get; set; }
        public int? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
