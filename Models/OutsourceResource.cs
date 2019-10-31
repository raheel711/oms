using System;
using System.Collections.Generic;

namespace oms.Models
{
    public partial class OutsourceResource
    {
        public int ResourceId { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string Detail { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string CompanyNo { get; set; }
        public int? AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
    }
}
