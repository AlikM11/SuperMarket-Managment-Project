using System;
using System.Collections.Generic;

#nullable disable

namespace SuperMarket_Managment_Project.Models
{
    public partial class VwCancelItem
    {
        public string Transno { get; set; }
        public string Pcode { get; set; }
        public string Pdesc { get; set; }
        public decimal? Price { get; set; }
        public int? Qty { get; set; }
        public decimal? Total { get; set; }
        public DateTime? Sdate { get; set; }
        public string Voidby { get; set; }
        public string Cancelledby { get; set; }
        public string Reason { get; set; }
        public string Action { get; set; }
    }
}
