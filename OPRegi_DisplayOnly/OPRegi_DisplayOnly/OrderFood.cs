using System;
using System.Collections.Generic;
using System.Text;

namespace OPRegi_DisplayOnly
{
    class OrderFood
    {
        public string Id { get; set; }
        public string OrderListId { get; set; }
        public string FoodId { get; set; }
        public string FoodName { get; set; }
        public string FoodPrice { get; set; }
        public string FoodCount { get; set; }

        public void SetMockObj(int pattern)
        {
            switch (pattern)
            {
                case 1:
                    this.Id = "1";
                    this.OrderListId = "1";
                    this.FoodId = "1";
                    this.FoodName = "レッドフラッシュ";
                    this.FoodPrice = "500";
                    this.FoodCount = "5";
                    break;
                case 2:
                    this.Id = "2";
                    this.OrderListId = "2";
                    this.FoodId = "2";
                    this.FoodName = "レッドフラッシュパフェ";
                    this.FoodPrice = "1000";
                    this.FoodCount = "2";
                    break;
                case 3:
                    this.Id = "3";
                    this.OrderListId = "3";
                    this.FoodId = "3";
                    this.FoodName = "パラ宿サンデー";
                    this.FoodPrice = "1200";
                    this.FoodCount = "1";
                    break;
            }
        }
    }
}
