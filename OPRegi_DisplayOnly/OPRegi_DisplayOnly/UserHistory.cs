using System;
using System.Collections.Generic;
using System.Text;

namespace OPRegi_DisplayOnly
{
    public class UserHistory
    {
        public string ShopName { private set; get; }

        /**
         * TODO モック状態なので要動的取得
         * ユーザーが行ったことあるお店を取得して返す
         */
        static UserHistory()
        {
            List<UserHistory> all = new List<UserHistory>();
            // モック
            String[] mock = new string[] { "PrismStone アキバ店", "PrismStone パラ宿店", "PrismStone シブヤ店" };
            foreach (string name in mock)
            {
                UserHistory userHistory = new UserHistory
                {
                    ShopName = name
                };

                all.Add(userHistory);
            }
            All = all;
        }

        public static IEnumerable<UserHistory> All { private set; get; }
    }
}
