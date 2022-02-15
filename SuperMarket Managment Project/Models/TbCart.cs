using System;
using System.Collections.Generic;

#nullable disable

namespace SuperMarket_Managment_Project.Models
{
    public partial class TbCart
    {
        public int Id { get; set; }
        public string Transno { get; set; }
        public string Pcode { get; set; }
        public decimal? Price { get; set; }
        public int? Qty { get; set; }
        public decimal? DiscPercent { get; set; }
        public decimal? Disc { get; set; }
        public decimal? Total { get; set; }
        public DateTime? Sdate { get; set; }
        public string Status { get; set; }
        public string Cashier { get; set; }

        public virtual TbProduct PcodeNavigation { get; set; }
    }
}
