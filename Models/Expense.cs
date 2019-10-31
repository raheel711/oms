using System;
using System.Collections.Generic;

namespace oms.Models
{
    public partial class Expense
    {
        public int ExpenseId { get; set; }
        public int? OrderAccountId { get; set; }
        public int? ResourceId { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public DateTime? EDate { get; set; }
        public double? Amount { get; set; }
        public string PaidAmount { get; set; }
        public int? PaidBy { get; set; }
        public string Detail { get; set; }
        public string WorkStatus { get; set; }
        public bool? AmountStatus { get; set; }
        public int? AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
        public int? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
