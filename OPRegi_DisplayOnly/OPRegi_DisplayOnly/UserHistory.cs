using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace OPRegi_DisplayOnly
{
    public class UserHistory
    {
        public string ShopName { private set; get; }

        public static ObservableCollection<Shop> Shops { get; set; }

        /**
         * TODO モック状態なので要動的取得
         * ユーザーが行ったことあるお店を取得して返す
         */
        static UserHistory()
        {
            // TODO namespaceを変更
            Shops = new ObservableCollection<OPRegi_DisplayOnly.Shop>();

            List<Shop> all = new List<Shop>();
            // モック
            //String[] mock = new string[] { "PrismStone アキバ店", "PrismStone パラ宿店", "PrismStone シブヤ店" };
            //foreach (string name in mock)
            //{
            //    UserHistory userHistory = new UserHistory
            //    {
            //        ShopName = name
            //    };

            //    all.Add(userHistory);
            //}

            // モックその2 (オブジェクト版)
            int[] mock = new int[] { 1, 2, 3 };
            foreach (int mockNum in mock)
            {
                all.Add(GetMockObj(mockNum));
            }
            All = all;
        }

        private static Shop GetMockObj(int pattern)
        {
            Shop Shop = new Shop();
            switch (pattern)
            {
                case 1:
                    Shop.Id = "1";
                    Shop.ShopName = "PrismStone アキバ店";
                    Shop.Address = "アキバ";
                    Shop.PhoneNumber = "000-000-0000";
                    break;
                case 2:
                    Shop.Id = "2";
                    Shop.ShopName = "PrismStone パラ宿店";
                    Shop.Address = "パラ宿";
                    Shop.PhoneNumber = "000-000-0000";
                    break;
                case 3:
                    Shop.Id = "3";
                    Shop.ShopName = "PrismStone シブヤ店";
                    Shop.Address = "シブヤ";
                    Shop.PhoneNumber = "000-000-0000";
                    break;
            }
            return Shop;
        }

        public static IEnumerable<Shop> All { private set; get; }
    }
}
