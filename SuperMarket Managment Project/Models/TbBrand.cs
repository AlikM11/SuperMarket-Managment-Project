using System;
using System.Collections.Generic;

#nullable disable

namespace SuperMarket_Managment_Project.Models
{
    public partial class TbBrand
    {
        public TbBrand()
        {
            TbProducts = new HashSet<TbProduct>();
        }

        public int Id { get; set; }
        public string Brand { get; set; }

        public virtual ICollection<TbProduct> TbProducts { get; set; }
    }
}
