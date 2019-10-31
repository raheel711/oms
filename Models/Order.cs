using System;
using System.Collections.Generic;

namespace oms.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int CustId { get; set; }
        public int? OrderTakenBy { get; set; }
        public int? OrderAssignTo { get; set; }
        public double? OpeningAmount { get; set; }
        public double? CurrentAmount { get; set; }
        public string PriceIsFinal { get; set; }
        public double? PaidAmount { get; set; }
        public double? ExpenseAmount { get; set; }
        public double? ExtraAmount { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string Link { get; set; }
        public string Detail { get; set; }
        public bool? Status { get; set; }
        public int? AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
        public int? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
