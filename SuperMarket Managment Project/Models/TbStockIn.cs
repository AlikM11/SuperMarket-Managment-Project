using System;
using System.Collections.Generic;

#nullable disable

namespace SuperMarket_Managment_Project.Models
{
    public partial class TbStockIn
    {
        public int Id { get; set; }
        public string Refno { get; set; }
        public string Pcode { get; set; }
        public int? Qty { get; set; }
        public DateTime? Sdate { get; set; }
        public string Stockinby { get; set; }
        public string Status { get; set; }
        public int? Supplierid { get; set; }

        public virtual TbProduct PcodeNavigation { get; set; }
        public virtual TbSupplier Supplier { get; set; }
    }
}
