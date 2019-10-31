using System;
using System.Collections.Generic;

namespace oms.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Detail { get; set; }
        public double? EstimatePrice { get; set; }
        public int? AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
        public int? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
