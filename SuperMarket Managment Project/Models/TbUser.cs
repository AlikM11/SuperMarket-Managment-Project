using System;
using System.Collections.Generic;

#nullable disable

namespace SuperMarket_Managment_Project.Models
{
    public partial class TbUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Name { get; set; }
        public string Isactivate { get; set; }
    }
}
