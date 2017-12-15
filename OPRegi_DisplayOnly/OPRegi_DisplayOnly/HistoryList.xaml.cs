using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OPRegi_DisplayOnly
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HistoryList : ContentPage
    {
        public HistoryList(Shop selected)
        {
            InitializeComponent();
            List<OrderList> orderList = GetMockList(selected);
            this.BindingContext = orderList;
        }

        private List<OrderList> GetMockList(Shop shop)
        {
            List<OrderList> orderList = new List<OrderList>();
            var patterns = new List<int>();
            switch (shop.Id)
            {
                case "1":
                    patterns.Add(1);
                    break;
                case "2":
                    patterns.Add(2);
                    patterns.Add(3);
                    patterns.Add(5);
                    break;
                case "3":
                    patterns.Add(4);
                    break;
            }
            foreach (int pattern in patterns)
            {
                OrderList OrderList = new OrderList();
                OrderList.SetMockObj(pattern);
                orderList.Add(OrderList);
                OrderList = null;
            }
            return orderList;
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            (sender as ListView).SelectedItem = null;
            if (e.SelectedItem != null)
            {
                await this.Navigation.PushAsync(new HistoryDetail((OrderList)e.SelectedItem));
            }
        }
    }
}