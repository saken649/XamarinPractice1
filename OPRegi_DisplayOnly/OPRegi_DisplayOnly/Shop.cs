using System;
using System.Collections.Generic;
using System.Text;

namespace OPRegi_DisplayOnly
{
    // とりあえずはモック用→TODO そのまま本番用のモデルに流用したい
    public class Shop
    {
        public string Id { get; set; }
        public string ShopName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
