using System;
using System.Collections.Generic;
using System.Text;

namespace OPRegi_DisplayOnly
{
    public class OrderList
    {
        public string Id { get; set; }
        public string ShopId { get; set; }
        public string TableNumber { get; set; }
        public string CompleteCode { get; set; }
        public string CompleteDate { get; set; }
        public string UserId { get; set; }


        public void SetMockObj(int pattern)
        {
            switch (pattern)
            {
                case 1:
                    this.Id = "1";
                    this.ShopId = "1"; // akiba
                    this.TableNumber = "1";
                    this.CompleteCode = "1";
                    this.CompleteDate = "2017-01-01";
                    this.UserId = "1";
                    break;
                case 2:
                    this.Id = "2";
                    this.ShopId = "2"; // パラ宿
                    this.TableNumber = "35";
                    this.CompleteCode = "1";
                    this.CompleteDate = "2017-12-01";
                    this.UserId = "1";
                    break;
                case 3:
                    this.Id = "3";
                    this.ShopId = "2"; // パラ宿
                    this.TableNumber = "45";
                    this.CompleteCode = "1";
                    this.CompleteDate = "2017-12-12";
                    this.UserId = "1";
                    break;
                case 4:
                    this.Id = "4";
                    this.ShopId = "3"; // シブヤ
                    this.TableNumber = "101";
                    this.CompleteCode = "1";
                    this.CompleteDate = "2017-12-13";
                    this.UserId = "1";
                    break;
                case 5:
                    this.Id = "5";
                    this.ShopId = "2"; // パラ宿
                    this.TableNumber = "11";
                    this.CompleteCode = "1";
                    this.CompleteDate = "2017-12-14";
                    this.UserId = "1";
                    break;
            }
        }
    }
}
