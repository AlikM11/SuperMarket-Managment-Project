using System;
using System.Collections.Generic;

#nullable disable

namespace SuperMarket_Managment_Project.Models
{
    public partial class VwStockIn
    {
        public int Id { get; set; }
        public string Refno { get; set; }
        public string Pcode { get; set; }
        public string Pdesc { get; set; }
        public int? Qty { get; set; }
        public DateTime? Sdate { get; set; }
        public string Stockinby { get; set; }
        public string Status { get; set; }
        public string Supplier { get; set; }
    }
}
